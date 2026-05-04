const API_BOOKS = "https://localhost:7151/api/books";
const API_BORROW = "https://localhost:7151/api/borrow";

let allBooks = [];
let selectedBook = null;

async function loadBooks(){
    const res = await fetch(API_BOOKS);
    const data = await res.json();
    allBooks = data;
    render(data);
}

function render(books){
    let html="";

    books.forEach(b=>{
        let img = b.imagePath 
            ? "https://localhost:7151"+b.imagePath
            : "https://via.placeholder.com/300";

        html += `
        <div class="col-md-2">
            <div class="book-card" onclick='openModal(${JSON.stringify(b)})'>
                <img src="${img}" class="book-img">
                <div class="overlay">${b.title}</div>
            </div>
        </div>`;
    });

    bookGrid.innerHTML = html;
}

function openModal(book){
    selectedBook = book;
    modal.style.display="block";
    modalImg.src = "https://localhost:7151"+book.imagePath;
    modalTitle.innerText = book.title;
}

function borrowNow(){
    borrowBook(selectedBook.bookId);
}

async function borrowBook(id){
    let user = JSON.parse(localStorage.getItem("user"));

    await fetch(API_BORROW,{
        method:"POST",
        headers:{"Content-Type":"application/json"},
        body: JSON.stringify({
            userId:user.userId,
            bookId:id,
            borrowDate:new Date(),
            dueDate:new Date()
        })
    });

    alert("Borrowed!");
}

function filterBooks(){
    let s = searchInput.value.toLowerCase();
    render(allBooks.filter(b=>b.title.toLowerCase().includes(s)));
}

loadBooks();