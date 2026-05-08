const API = "https://localhost:7151/api/auth";

function showRegister(){
    loginDiv.style.display="none";
    registerDiv.style.display="block";
}

function showLogin(){
    registerDiv.style.display="none";
    loginDiv.style.display="block";
}

async function register(){
    if(!regName.value || !regEmail.value || !regPassword.value){
        alert("Complete all fields");
        return;
    }

    try{
        const res = await fetch(API+"/register",{
            method:"POST",
            headers:{"Content-Type":"application/json"},
            body: JSON.stringify({
                name:regName.value,
                email:regEmail.value,
                password:regPassword.value,
                role:"Borrower"
            })
        });

        alert(await res.text());
        showLogin();

    }catch{
        alert("Register failed");
    }
}

async function login(){
    if(!loginEmail.value || !loginPassword.value){
        alert("Enter email & password");
        return;
    }

    try{
        const res = await fetch(API+"/login",{
            method:"POST",
            headers:{"Content-Type":"application/json"},
            body: JSON.stringify({
                email:loginEmail.value,
                password:loginPassword.value
            })
        });

        if(!res.ok){
            alert("Invalid login");
            return;
        }

        const user = await res.json();

        // IMPORTANT: ensure consistent structure
       localStorage.setItem("user", JSON.stringify({

      id: user.userId,
      name: user.name,
     email: user.email
        }   ));
       location.href="books.html";

    }catch{
        alert("Server error");
    }
}