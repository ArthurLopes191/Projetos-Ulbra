const pessoas = [{nome: "Arthur", idade: 21, img:"https://blog.cobasi.com.br/wp-content/uploads/2021/08/orangotango-1.jpg"},{nome: "João", idade: 23, img:"https://greenbond.com.br/wp-content/uploads/2021/01/WhatsApp-Image-2021-01-29-at-10.49.18.jpeg"}, {nome: "Jaiminho", idade: 70, img:"https://www.filatelista-tematico-blog.net/wp-content/uploads/Jaiminho_o_carteiro_um_personagem_do_seriado_chaves_chamada.jpg"}]

function iniciando(){
    document.getElementById("lista")
    ListaDePessoas(pessoas)
}



function ListaDePessoas(data){
    const listaNova = pessoas.map(pessoas => { 
        
        return `<li>${pessoas.nome} - ${pessoas.idade}</li>
        <img src="${pessoas.img}">` 
        
        
    })
    
    
    lista.innerHTML = listaNova.join("");
}