public class Lista {
    int quantidade;
    Elemento inicio;
    Elemento fim;

    public void addFirst(Elemento e) {
        if (inicio == null) {
            inicio = e;
            fim = e;
        } else {
            Elemento aux = inicio;
            e.setProx(aux);
            aux.setAnt(e);
            inicio = e;
        }
        quantidade++;
    }

    public void addAfterPosition(int posicao, Elemento valor){
        if (posicao < 0 || posicao >= quantidade) {
            throw new IndexOutOfBoundsException("Posição inválida");
        }

        Elemento atual = inicio;
        for(int i = 0; i < posicao-1; i++){ // botei posicao -1 pois o loop mostrava o proximo valor da posicao que buscamos, desta forma mostra o exato valor
            atual = atual.getProx();
        }

        valor.setProx(atual.getProx());
        valor.setAnt(atual);
        if (atual.getProx() != null){
            atual.getProx().setAnt(valor);
        }

        atual.setProx(valor);

        quantidade++;
    }

    public void addEnd(Elemento e){
        if (inicio == null) {
            addFirst(e);
        } else {
            fim.setProx(e);
            e.setAnt(fim);
            fim = e;
            quantidade++;
        }

    }

    public void showAllLista(){
        Elemento atual = inicio;
        while(atual != null){
            System.out.println(atual.getElemento());
            atual = atual.getProx();
        }
    }
}
