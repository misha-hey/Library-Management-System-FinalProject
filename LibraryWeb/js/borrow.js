const API =
"https://localhost:7151/api/borrow";

const RETURN =
"https://localhost:7151/api/return";

/* USER */

let user =
JSON.parse(
    localStorage.getItem("user")
);

/* DATA */

let borrowData = [];

/* LOGIN CHECK */

if(!user){

    location.href = "login.html";
}

/* LOAD BORROWED BOOKS */

async function loadBorrow(){

    try{

        const res =
        await fetch(
            `${API}/user/${user.id}`
        );

        const data =
        await res.json();

        borrowData = data;

        render(data);

        notify(data);

        updateStats(data);
    }
    catch(err){

        console.log(err);

        showAlert(
            "Failed to load borrowed books",
            "danger"
        );
    }
}

/* STATUS */

function getStatus(book){

    const now =
    new Date();

    const due =
    new Date(book.dueDate);

    if(book.status === "Returned"){

        return "Returned";
    }

    if(now > due){

        return "Late";
    }

    return "Borrowed";
}

/* RENDER TABLE */

function render(data){

    const table =
    document.getElementById("borrowTable");

    /* EMPTY STATE */

    if(data.length === 0){

        table.innerHTML = `

        <tr>

            <td colspan="5">

                <div class="empty-state">

                    <h2>
                        No borrowed books 📚
                    </h2>

                    <p>
                        Borrow books to see them here.
                    </p>

                </div>

            </td>

        </tr>
        `;

        return;
    }

    let html = "";

    data.forEach(book => {

        const status =
        getStatus(book);

        /* STATUS BADGES */

        let badge = "";

        if(status === "Borrowed"){

            badge =

            `
            <span class="status borrowed">

                📖 Borrowed

            </span>
            `;
        }

        else if(status === "Late"){

            badge =

            `
            <span class="status late">

                ⚠ Late

            </span>
            `;
        }

        else{

            badge =

            `
            <span class="status returned">

                ✅ Returned

            </span>
            `;
        }

        /* ACTION BUTTON */

        let action = "";

        if(status !== "Returned"){

            action =

            `
            <button
            onclick="returnBook(${book.borrowId})">

                Return

            </button>
            `;
        }

        else{

            action =

            `
            <button
            disabled
            class="btn-disabled">

                Completed

            </button>
            `;
        }

        html += `

        <tr>

            <td>

                <strong>

                    ${book.bookTitle}

                </strong>

            </td>

            <td>

                ${formatDate(book.borrowDate)}

            </td>

            <td>

                ${formatDate(book.dueDate)}

            </td>

            <td>

                ${badge}

            </td>

            <td>

                ${action}

            </td>

        </tr>
        `;
    });

    table.innerHTML = html;
}

/* FILTER */

function filterHistory(){

    const search =

    document.getElementById(
        "searchHistory"
    )
    .value
    .toLowerCase();

    const statusFilter =

    document.getElementById(
        "statusFilter"
    )
    .value;

    const filtered =

    borrowData.filter(book => {

        const status =
        getStatus(book);

        const matchSearch =

            book.bookTitle
            .toLowerCase()
            .includes(search);

        const matchStatus =

            statusFilter === ""

            ||

            status === statusFilter;

        return matchSearch && matchStatus;
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

        if(!res.ok){

            showAlert(
                msg,
                "danger"
            );

            return;
        }

        showAlert(
            msg,
            "success"
        );

        loadBorrow();
    }
    catch(err){

        console.log(err);

        showAlert(
            "Return failed",
            "danger"
        );
    }
}

/* NOTIFICATIONS */

function notify(data){

    let html = "";

    const now =
    new Date();

    data.forEach(book => {

        const due =
        new Date(book.dueDate);

        const diff =
        (due - now)
        /
        (1000 * 60 * 60 * 24);

        if(book.status !== "Returned"){

            /* OVERDUE */

            if(diff < 0){

                html += `

                <div class="alert alert-danger">

                    ⚠ OVERDUE:
                    ${book.bookTitle}

                </div>
                `;
            }

            /* DUE SOON */

            else if(diff <= 1){

                html += `

                <div class="alert alert-success">

                    📅 Due Soon:
                    ${book.bookTitle}

                </div>
                `;
            }
        }
    });

    document.getElementById(
        "notifications"
    )
    .innerHTML = html;
}

/* UPDATE STATS */

function updateStats(data){

    let borrowed = 0;

    let returned = 0;

    let late = 0;

    data.forEach(book => {

        const status =
        getStatus(book);

        if(status === "Borrowed"){

            borrowed++;
        }

        else if(status === "Returned"){

            returned++;
        }

        else if(status === "Late"){

            late++;
        }
    });

    document.getElementById(
        "borrowedCount"
    ).innerText = borrowed;

    document.getElementById(
        "returnedCount"
    ).innerText = returned;

    document.getElementById(
        "lateCount"
    ).innerText = late;
}

/* ALERT */

function showAlert(message,type){

    const div =
    document.createElement("div");

    div.className =
    `alert alert-${type}`;

    div.innerText =
    message;

    document.querySelector(".dashboard")
    .prepend(div);

    setTimeout(() => {

        div.remove();

    },3000);
}

/* DATE FORMAT */

function formatDate(date){

    return new Date(date)
    .toLocaleDateString();
}

/* START */

loadBorrow();