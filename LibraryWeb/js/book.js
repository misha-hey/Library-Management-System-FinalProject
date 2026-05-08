const API_BOOKS = "https://localhost:7151/api/books";

const API_BORROW = "https://localhost:7151/api/borrow";

let allBooks = [];

/* LOAD BOOKS */
async function loadBooks(){

    try{

        const res = await fetch(API_BOOKS);

        const data = await res.json();

        allBooks = data;

        applyFilters();
    }
    catch(err){

        console.log(err);

        alert("Failed to load books");
    }
}

/* SEARCH FILTER */
function applyFilters(){

    const search =
        document.getElementById("searchInput")
        .value
        .toLowerCase();

    const filtered = allBooks.filter(b =>

        b.title.toLowerCase().includes(search)
    );

    render(filtered);
}

/* RENDER BOOKS */
function render(data){

    let html = "";

    data.forEach(b => {

        const img = b.imagePath

            ? "https://localhost:7151" + b.imagePath

            : "https://via.placeholder.com/150";

        html += `
        <div class="card">

            <img src="${img}">

            <div class="card-body">

                <h3>${b.title}</h3>

                <p>${b.author}</p>

                <p>
                    Quantity:
                    ${b.quantity}
                </p>

                <button onclick="borrowBook(${b.bookId})">

                    Borrow

                </button>

            </div>

        </div>`;
    });

    document.getElementById("bookGrid").innerHTML =
        html;
}

/* BORROW BOOK */
async function borrowBook(bookId){

    try{

        const user =
            JSON.parse(localStorage.getItem("user"));

        if(!user){

            alert("Login first");

            location.href = "login.html";

            return;
        }

        const res = await fetch(API_BORROW,{

            method:"POST",

            headers:{
                "Content-Type":"application/json"
            },

            body: JSON.stringify({

                userId: user.id,

                bookId: bookId
            })
        });

        const msg = await res.text();

        if(!res.ok){

            alert(msg);

            return;
        }

        alert(msg);

        loadBooks();
    }
    catch(err){

        console.log(err);

        alert("Borrow failed");
    }
}

/* START */
loadBooks();