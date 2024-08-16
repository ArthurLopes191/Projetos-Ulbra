class Projeto{
    constructor(nome, descricao, prazoEntrega){
        this.nome = nome;
        this.descricao = descricao;
        this.prazoEntrega
    }

    salvar(){
        //salvar no banco de dados
        let projeto = {
            id:"12312ed123d23e567",
            nome : "RU",
            descricao : "Aplicativo para o restaurante",
            prazoEntrega: "29/04"
        }
           return Projeto;
    }

    atualizar(){
    let projeto = {
        id:"12312ed123d23e567",
        nome : "RU",
        descricao : "Aplicativo para o restaurante",
        prazoEntrega: "29/04"
    }
       return Projeto;
    }

    remover(){
        return "Removido com sucesso"
    }

}

const projeto = new Projeto("Projeto Teste", "descricao", "23/10")