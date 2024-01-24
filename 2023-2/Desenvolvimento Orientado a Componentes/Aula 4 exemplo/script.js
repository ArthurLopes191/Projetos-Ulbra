function ready(){
    home()
    document.getElementById("sobre").addEventListener("click", sobre)
    document.getElementById("home").addEventListener("mouseover", home)

}


function home(){
    const sessao = document.getElementById("sessao")

    let nome = "Arthur"
    console.log(sessao)

    sessao.innerHTML= `
    <h1>Olá ${nome}</h1>
    `
}


function sobre(){
    const sessao = document.getElementById("sessao")

    
    console.log(sessao)

    sessao.innerHTML= `
    <h1>Pagina Sobre</h1>
    `
}