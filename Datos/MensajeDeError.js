async function NumNotExiting()
{
    ErrorMSJ = document.querySelector("#app > div > span:nth-child(2) > div > span > div > div > div > div > div > div._2Nr6U");
    ErMSJ = ErrorMSJ.innerHTML;

    if(ErrorMSJ)
    {
        console.log("[Se encontro un error.]");
        console.log(ErMSJ);
    }
    else
    {
        console.log("[No se encontro nada.]");
    }
    return true;
}
NumNotExiting();