const API_RECENT =
"https://localhost:7151/api/borrow/recent";

async function loadRecentBorrowed()
{
    try{

        const user =
        JSON.parse(
            localStorage.getItem("user")
        );

        const res =
        await fetch(

            `${API_RECENT}/${user.id}`

        );

        const books =
        await res.json();

        const container =
        document.getElementById(
            "recentBorrowed"
        );

        if(books.length === 0){

            container.innerHTML = `

                <p class="empty-text">

                    No borrowed books yet 📚

                </p>

            `;

            return;
        }

        let html = "";

        books.forEach(book => {

            const img =

                book.imagePath

                ?

                "https://localhost:7151"
                + book.imagePath

                :

                "https://via.placeholder.com/100x150";

            html += `

            <div class="borrow-item">

                <div class="borrow-left">

                    <img src="${img}">

                    <div>

                        <h3>
                            ${book.title}
                        </h3>

                        <p>
                            ${book.author}
                        </p>

                    </div>

                </div>

                <span class="status borrowed">

                    Borrowed

                </span>

            </div>
            `;
        });

        container.innerHTML = html;
    }

    catch(err){

        console.log(err);
    }
}

loadRecentBorrowed();