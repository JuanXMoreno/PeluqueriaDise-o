async function enviarScript(scriptText){
    const lines = scriptText.split(/[\n\t]+/);
    textarea = document.querySelector("#main > footer > div._2BU3P.tm2tP.copyable-area > div > span:nth-child(2) > div > div._2lMWa > div.p3_M1");

    if(textarea)
    {
        console.log("[Chat Abierto]");
        for(const line of lines){            
            textarea.focus();
            document.execCommand('insertText', false, line+`                
                            
                            
                                                            
                            
            `);
            textarea.dispatchEvent(new Event('change', {bubbles: true}));
            
            if(lines.indexOf(line) !== lines.length - 1) await new Promise(resolve => setTimeout(resolve, 250));
        }
    }
    else
    {
        console.log("No se encontro chat");
    }
    setTimeout(() => {
        (main.querySelector(`[data-testid="send"]`) || main.querySelector(`[data-icon="send"]`)).click();
    }, 100);
    return scriptText.length;
}
