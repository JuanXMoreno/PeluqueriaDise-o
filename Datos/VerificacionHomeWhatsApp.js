function VerificarInicio()
{
    Home = document.querySelector('div[class="_3ArsE"]');   
    Chats = Home.querySelector('div[class="ldL67 _2i3T7 _1cpSb"]');
    HomeWhats = Home.querySelector('div[class="ldL67 _3sh5K"]');
    HomeWhats1 = HomeWhats.querySelector('div[class="zaKsw"]');

    if(Chats)
    {
        console.log("Listo");
    }
    else
    {
        console.log("NO");
    }
    return true;
}

VerificarInicio();