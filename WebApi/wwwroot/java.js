let num=0
const checkPassword = async () => {


    const password = document.querySelector("#password").value

    try {
        const response = await fetch('api/Password', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(password)
        });


        if (response.ok) {
            const res = await response.json();

            const prog = document.querySelector("#prog")
            prog.value = res
            num = res;

            if (res < 2) {
                alert("your password is ")
            }


        }
        else {
            throw Error("error")
        }


    }

    catch (e) {
        alert(e.message)
    }




}
const postData = async () => {
   
    const name =document.querySelector("#name").value
    const lastName = document.querySelector("#lastName").value
    const email =document.querySelector("#email").value
    const password = document.querySelector("#password").value

    console.log(email)

    const user = {
        name,
        lastName,
        email,
        password

    };
    if (num < 2) {
        alert("the passwors is low!")
        return
    }
    try {
        const response = await fetch('api/Users', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });

        const currentUser = await response.json();
        
        if (response.ok)
        {
            alert("your sign was succsed")
           
        }
        else {
            throw Error("error")
        }


    }

    catch (e) {
        alert("error")
    }
    



}
const getUser = async () => {

  
    const email = document.querySelector("#email2").value
    const password = document.querySelector("#password2").value

    console.log(email)

    const userlogin = {
       
        email,
        password

    };

  
    try {
        const response = await fetch('api/Users/Login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(userlogin)
        });

        const currentUser = await response.json();
        if (response.ok)
        {
            alert("your login was succsess")
            sessionStorage.setItem("currentUser", JSON.stringify(currentUser));
            window.location.href = "UserDetails.html";
        }
        else {
            throw Error("the user not connected")
        }


    }

    catch (e) {
        alert("the user not connected")
    }




}