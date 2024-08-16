class Sorveteria{
    constructor(endereco, nome, telefone){
        this.endereco = endereco
        this.nome = nome
        this.telefone = telefone
    }

    salvar(){
        let sorveteria = {
            endereco: this.endereco,
            nome: this.nome,
            telefone: this.telefone
        }
        return sorveteria
    }
}


class Cliente{
    constructor(nome, cidade, cpf, telefone){
        this.nome = nome
        this.cidade = cidade
        this.cpf = cpf
        this.telefone = telefone
    }

    salvar(){
        let cliente = {
            nome : this.nome,
            cidade : this.cidade,
            cpf : this.cpf,
            telefone : this.telefone
        }
        return cliente
    }
}

class Atendente{
    constructor(nome, funcao, cpf){
        this.nome = nome
        this.funcao = funcao
        this.cpf = cpf
    }

    salvar(){
        let atendente = {
            nome : this.nome,
            funcao : this.funcao,
            cpf : this.cpf,
        }
        return atendente
    }
}


module.exports = Sorveteria;
module.exports = Cliente;
module.exports = Atendente;