class PedidoSorvete{
    constructor(sabor, clienteId, valorTotal, atendenteId){
        this.sabor = sabor
        this.clienteId = clienteId,
        this.valorTotal = valorTotal,
        this.atendenteId = atendenteId
    }

    salvar(){
        let pedidoSorvete = {
            sabor: this.sabor,
            clienteId: this.clienteId, 
            valorTotal: this.valorTotal,
            atendenteId: this.atendenteId
        }
    }
}

class Producao{
    constructor(idSorvete, idAtendente){
        this.idSorvete = idSorvete
        this.idAtendente = idAtendente
    }

    salvar(){
        let producao = {
            idSorvete: this.idSorvete,
            idAtendente: this.idAtendente
        }
    }
}
class Estoque{
    constructor(quantidade, saborId){
        this.quantidade = quantidade
        this.saborId = saborId
    }

    salvar(){
        let estoque = {
            quantidade: this.quantidade,
            saborId: this.saborId
        }
    }
}

class Sabor{
    constructor(nome){
        this.nome = nome
    }

    salvar(){
        let sabor = {
            nome: this.nome,
        }
    }
}




module.exports = PedidoSorvete;
module.exports = Producao;
module.exports = Estoque;
module.exports = Sabor;