const API_BOOKS = "https://localhost:7151/api/books";
const API_BORROW = "https://localhost:7151/api/borrow";

let allBooks=[];

async function loadBooks(){
    try{
        const res = await fetch(API_BOOKS);
        const data = await res.json();
        allBooks = data;
        renderBooks(data);
    }catch(e){
        console.error(e);
        alert("Cannot connect to API");
    }
}

function renderBooks(books){
    let html="";

    books.forEach(b=>{
        let img = b.imagePath 
            ? "https://localhost:7151" + b.imagePath
            : "https://via.placeholder.com/200";

        let desc = b.description || "No description";

        html+=`
        <div class="card">
            <img src="${img}">
            <div style="padding:10px">
                <b>${b.title}</b><br>
                <small>${desc}</small><br>
                <small>${b.author}</small><br>

                <button onclick="borrow(${b.bookId})"
                ${b.quantity<=0?"disabled":""}>
                ${b.quantity<=0?"Out":"Borrow"}
                </button>
            </div>
        </div>`;
    });

    document.getElementById("bookGrid").innerHTML = html;
}

async function borrow(id){
    let user = JSON.parse(localStorage.getItem("user"));

    if(!user){
        alert("Login first");
        return;
    }

    await fetch(API_BORROW,{
        method:"POST",
        headers:{"Content-Type":"application/json"},
        body: JSON.stringify({
            userId:user.userId,
            bookId:id,
            borrowDate:new Date().toISOString(),
            dueDate:new Date().toISOString()
        })
    });

    alert("Borrowed!");
}

function filterBooks(){
    let s = document.getElementById("searchInput").value.toLowerCase();
    let filtered = allBooks.filter(b => b.title.toLowerCase().includes(s));
    renderBooks(filtered);
}

loadBooks();