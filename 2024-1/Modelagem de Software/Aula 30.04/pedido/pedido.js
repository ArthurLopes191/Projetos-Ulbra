class Pedido{
    constructor(status, valorTotal, cliente) {
        this.status = status
        this.valorTotal = valorTotal
        this.cliente = cliente
    }

    emitir(){
        let pedido = {
            status: this.status,
            valorTotal: this.valorTotal,
            cliente: this.cliente
        }

        return pedido
    }
}

class Item{
    constructor(quantidade, pedido, produto){
        this.quantidade = quantidade
        this.pedido = pedido
        this.produto = produto
    }

    salvar(){
        //salvar no banco de dados
        let item = {
            quantidade: this.quantidade,
            pedido: this.pedido,
            produto: this.pedido
        }

        return item
    }
}

class Produto{
    constructor(nome, valor){
        this.valor = valor
        this.nome = nome
    }

    salvar(){
        //salvar no banco de dados
        let produto = {
            nome: this.nome,
            valor: this.valor
        }

        return produto
    }
}






