class Pagamento{
    constructor(pedidoSorveteId, valor, data, formaPagamentoId){
        this.PedidoSorveteId = pedidoSorveteId
        this.valor = valor,
        this.data = data,
        this.formaPagamentoId = formaPagamentoId
    }

    salvar(){
        let pagamento = {
            PedidoSorveteId: this.PedidoSorveteId,
            valor: this.valor, 
            data: this.data,
            formaPagamentoId: this.formaPagamentoId
        }
    }
}

class FormaPagamento{
    constructor(tipo){
        this.PedidoStipoorveteId = tipo
        
    }

    salvar(){
        let formaPagamento = {
            tipo: this.tipo
        }
    }
}


module.exports = Pagamento;
module.exports = FormaPagamento;