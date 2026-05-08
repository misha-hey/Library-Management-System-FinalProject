const API_BOOKS =
"https://localhost:7151/api/books";

const API_BORROW =
"https://localhost:7151/api/borrow";

let allBooks = [];

/* LOAD BOOKS */

async function loadBooks(){

    try{

        const res =
        await fetch(API_BOOKS);

        const data =
        await res.json();

        allBooks = data;

        applyFilters();
    }
    catch(err){

        console.log(err);

        showAlert(
            "Failed to load books",
            "danger"
        );
    }
}

/* APPLY FILTERS */

function applyFilters(){

    const search =
    document.getElementById("searchInput")
    .value
    .toLowerCase();

    const category =
    document.getElementById("categoryFilter")
    .value;

    const filtered =
    allBooks.filter(book => {

        const matchSearch =

            book.title
            .toLowerCase()
            .includes(search)

            ||

            book.author
            .toLowerCase()
            .includes(search);

        const matchCategory =

            category === "all"

            ||

            book.category === category;

        return matchSearch && matchCategory;
    });

    renderBooks(filtered);
}

/* RENDER BOOKS */

function renderBooks(data){

    const bookGrid =
    document.getElementById("bookGrid");

    /* EMPTY STATE */

    if(data.length === 0){

        bookGrid.innerHTML = `

        <div class="empty-state">

            <h2>
                No books found 📚
            </h2>

            <p>
                Try another search or category.
            </p>

        </div>
        `;

        return;
    }

    let html = "";

    data.forEach(book => {

        const img =

            book.imagePath

            ?

            "https://localhost:7151"
            + book.imagePath

            :

            "https://via.placeholder.com/300x420?text=No+Image";

        /* STATUS */

        const available =
        book.quantity > 0;

        const statusBadge =

            available

            ?

            `
            <span class="status returned">
                🟢 Available
            </span>
            `

            :

            `
            <span class="status late">
                🔴 Not Available
            </span>
            `;

        /* BUTTON */

        const button =

            available

            ?

            `
            <button
            onclick="borrowBook(${book.bookId})">

                Borrow Book

            </button>
            `

            :

            `
            <button disabled
                    class="btn-disabled">

                Out of Stock

            </button>
            `;

        html += `

        <div class="card">

            <img src="${img}">

            <div class="card-body">

                <h3>
                    ${book.title}
                </h3>

                <p>
                    ${book.author}
                </p>

                <p>
                    Category:
                    ${book.category || "General"}
                </p>

                ${statusBadge}

                <br><br>

                ${button}

            </div>

        </div>
        `;
    });

    bookGrid.innerHTML = html;
}

/* BORROW BOOK */

async function borrowBook(bookId){

    try{

        const user =
        JSON.parse(
            localStorage.getItem("user")
        );

        if(!user){

            location.href =
            "login.html";

            return;
        }

        const res =
        await fetch(API_BORROW,{

            method:"POST",

            headers:{
                "Content-Type":"application/json"
            },

            body: JSON.stringify({

                userId:user.id,

                bookId:bookId
            })
        });

        const msg =
        await res.text();

        if(!res.ok){

            showAlert(msg,"danger");

            return;
        }

        showAlert(msg,"success");

        loadBooks();
    }
    catch(err){

        console.log(err);

        showAlert(
            "Borrow failed",
            "danger"
        );
    }
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

/* START */

loadBooks();