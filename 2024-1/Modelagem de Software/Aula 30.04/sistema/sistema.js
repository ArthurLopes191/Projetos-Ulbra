class Cliente{
    constructor(nome){
        this.nome = nome
    }

    salvar(){
        let cliente = {
            nome: this.nome
        }
        return cliente
    }   
}

class Restaurante{
    constructor(nome, cnpj, endereco){
        this.nome = nome
        this.cnpj = cnpj
        this.endereco = endereco
    }

    salvar(){
        let restaurante = {
            nome: this.nome,
            cnpj: this.cnpj,
            endereco: this. endereco
        }
        return restaurante
    }   
}