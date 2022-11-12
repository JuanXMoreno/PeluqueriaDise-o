async function DetectarInicio() {
    Carga = document.querySelector("#app > div > div > div.g0rxnol2.lk9bdx0e.d9lyu8cj.qlylaf53.d4g41f7d > progress");
    Home = document.querySelector("#main > footer > div._2BU3P.tm2tP.copyable-area > div > span:nth-child(2) > div > div._2lMWa > div.p3_M1");
    Exito = false;

    if (Carga) {
        console.log("[Cargando]");
    }
    else if (Home) {
        console.log("[EXITO]");
        Exito = true;
    }
    else if(!Home)
    {
        console.log("No se encontro donde volcal el contenido.");
    }
    return Exito;
}
DetectarInicio();