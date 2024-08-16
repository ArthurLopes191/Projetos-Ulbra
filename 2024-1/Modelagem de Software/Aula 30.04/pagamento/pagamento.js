class Pagamento{
    cconstructor(valor, pedido){
        this.valor = valor;
        this.pedido = pedido;
    }

    salvar(){
        //salvar no banco de dados
        let pagamento = {
            valor: this.valor,
            pedido: this.pedido
        }
    }
}