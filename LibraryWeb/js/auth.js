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
}

async function login(){
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
    localStorage.setItem("user", JSON.stringify(user));

    location.href="dashboard.html";
}