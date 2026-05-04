const API = "https://localhost:7151/api/borrow";
const RETURN = "https://localhost:7151/api/return";

let user = JSON.parse(localStorage.getItem("user"));

async function loadBorrow(){
    const res = await fetch(`${API}/user/${user.userId}`);
    const data = await res.json();

    let html="";

    data.forEach(b=>{
        html += `
        <tr>
            <td>${b.bookTitle}</td>
            <td>${new Date(b.borrowDate).toLocaleDateString()}</td>
            <td>${new Date(b.dueDate).toLocaleDateString()}</td>
            <td>${b.status}</td>
            <td>
                ${b.status!="Returned"
                ? `<button onclick="returnBook(${b.borrowId})">Return</button>`
                : "Returned"}
            </td>
        </tr>`;
    });

    borrowTable.innerHTML = html;
}

async function returnBook(id){
    await fetch(RETURN,{
        method:"POST",
        headers:{"Content-Type":"application/json"},
        body: JSON.stringify({
            borrowId:id,
            returnDate:new Date()
        })
    });

    alert("Returned!");
    loadBorrow();
}

loadBorrow();