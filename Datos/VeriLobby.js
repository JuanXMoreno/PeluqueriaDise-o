async function Login() {
    Login = document.querySelector("#app > div > div > div.landing-window > div.landing-main > div > div._2WuPw > div");
    Exmsj = Login.innerText;

    if (Login) {
        console.log("[/lobby]");
        console.log(Exmsj);
        return true;
    }
    else {
        console.log("[/not lobby]");
        return false;
    }
}
Login();