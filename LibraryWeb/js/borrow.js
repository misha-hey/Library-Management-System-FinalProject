const API =
    "https://localhost:7151/api/borrow";

const RETURN =
    "https://localhost:7151/api/return";

/* USER */
let user =
    JSON.parse(localStorage.getItem("user"));

/* DATA */
let borrowData = [];

/* CHECK LOGIN */
if(!user){

    location.href = "login.html";
}

/* LOAD BORROWED BOOKS */
async function loadBorrow(){

    try{

        const res =
            await fetch(`${API}/user/${user.id}`);

        const data =
            await res.json();

        borrowData = data;

        render(data);

        notify(data);
    }
    catch(err){

        console.log(err);

        alert("Failed to load borrowed books");
    }
}

/* STATUS */
function getStatus(b){

    const now =
        new Date();

    const due =
        new Date(b.dueDate);

    if(b.status === "Returned")
        return "Returned";

    if(now > due)
        return "Late";

    return "Borrowed";
}

/* RENDER */
function render(data){

    let table = "";

    if(data.length === 0){

        table = `
        <tr>

            <td colspan="5"
                style="text-align:center;padding:40px;">

                No borrowed books 📚

            </td>

        </tr>`;

        document.getElementById("borrowTable")
        .innerHTML = table;

        return;
    }

    data.forEach(b => {

        const status =
            getStatus(b);

        let badge = "";

        if(status === "Borrowed"){

            badge =
            `<span class="status borrowed">
                Borrowed
            </span>`;
        }

        else if(status === "Late"){

            badge =
            `<span class="status late">
                Late
            </span>`;
        }

        else{

            badge =
            `<span class="status returned">
                Returned
            </span>`;
        }

        table += `
        <tr>

            <td>${b.bookTitle}</td>

            <td>
                ${date(b.borrowDate)}
            </td>

            <td>
                ${date(b.dueDate)}
            </td>

            <td>
                ${badge}
            </td>

            <td>

                ${status !== "Returned"

                ? `<button onclick="returnBook(${b.borrowId})">
                        Return
                   </button>`

                : ""}
            </td>

        </tr>`;
    });

    document.getElementById("borrowTable")
    .innerHTML = table;
}
/* FILTER */
function filterHistory(){

    const search =
        document.getElementById("searchHistory")
        .value
        .toLowerCase();

    const status =
        document.getElementById("statusFilter")
        .value;

    const filtered =
        borrowData.filter(b => {

            const st =
                getStatus(b);

            return b.bookTitle
                .toLowerCase()
                .includes(search)

                &&

                (status === "" ||
                 st === status);
        });

    render(filtered);
}

/* RETURN BOOK */
async function returnBook(id){

    try{

        const res =
            await fetch(RETURN,{

                method:"POST",

                headers:{
                    "Content-Type":"application/json"
                },

                body: JSON.stringify({

                    borrowId:id,

                    returnDate:new Date()
                })
            });

        const msg =
            await res.text();

        alert(msg);

        loadBorrow();
    }
    catch(err){

        console.log(err);

        alert("Return failed");
    }
}

/* NOTIFICATIONS */
function notify(data){

    let html = "";

    const now =
        new Date();

    data.forEach(b => {

        const due =
            new Date(b.dueDate);

        const diff =
            (due - now) /
            (1000 * 60 * 60 * 24);

        if(b.status !== "Returned"){

            if(diff < 0){

                html += `
                <div class="alert alert-danger">

                    OVERDUE:
                    ${b.bookTitle}

                </div>`;
            }

            else if(diff <= 1){

                html += `
                <div class="alert alert-success">

                    Due soon:
                    ${b.bookTitle}

                </div>`;
            }
        }
    });

    document.getElementById("notifications")
    .innerHTML = html;
}

/* DATE FORMAT */
function date(d){

    return new Date(d)
    .toLocaleDateString();
}

/* START */
loadBorrow();