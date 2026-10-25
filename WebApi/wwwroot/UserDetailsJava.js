const title = document.querySelector(".title");
const updateDetails = document.querySelector(".updateDetails");
const details = document.querySelector(".details");

const User = sessionStorage.getItem("currentUser");
const nameUser1 = JSON.parse(User).name;
const lastName1 = JSON.parse(User).lastName;
const email1 = JSON.parse(User).email;
const password1 = JSON.parse(User).password;
const id = JSON.parse(User).id;

title.textContent = "hi!" +" "+ nameUser1;

const writeTheUser = () => {
    details.style.display = "block"

    const name3 = document.querySelector("#name")
    const lastName3 = document.querySelector("#lastName")
    const email3 = document.querySelector("#email")
    const password3 = document.querySelector("#password")

    name3.value = nameUser1;
    lastName3.value = lastName1;
    email3.value = email1;
    password3.value = password1;




}
const put = async () => {
    const name = document.querySelector("#name").value
    const lastName = document.querySelector("#lastName").value
    const email = document.querySelector("#email").value
    const password = document.querySelector("#password").value
    

    console.log(email)

    const user = {
        name,
        lastName,
        email,
        password,
        id

        

    };
    try {
        const response = await fetch(`api/Users/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        window.location.href = "AfterTheUpdate.html";
       

    }

    catch (e) {
        alert(e.message)
    }




}