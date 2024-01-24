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

    public void addEnd(Elemento e){
        if (inicio == null) {
            addFirst(e);
        } else {
            fim.setProx(e);
            e.setAnt(fim);
            fim = e;
        }
    }


    public boolean removeFirst(){
        if(inicio != null){
            inicio = inicio.getProx();
            quantidade--;
            if(quantidade ==0){
                fim=null;
            }
            return true;
        }else{
            return false;
        }
    }

    public boolean removeEnd(){
        if(inicio != null){
            fim = fim.getAnt();
            quantidade--;
            if(quantidade ==0){
                inicio=null;
            }
            return true;
        }else{
            return false;
        }
    }


    public int getElementoByPosition(int posicao){
        if (posicao < 0 || posicao >= quantidade) {
            throw new IndexOutOfBoundsException("Posição inválida");
        }

        Elemento atual = inicio;
        for(int i = 0; i < posicao-1; i++){ // botei posicao -1 pois o loop mostrava o proximo valor da posicao que buscamos, desta forma mostra o exato valor
            atual = atual.getProx();
        }

        return atual.getElemento();
    }

    public void showAllLista(){
        Elemento atual = inicio;
        while(atual != fim.getProx()){ //Botei fim.getProx pois o loop só mostrava até o anterior ao fim
            System.out.println(atual.getElemento());
            atual = atual.getProx();
        }
    }

    public void showAllListaAoContrario(){
        Elemento atual = fim;
        while(atual != inicio.getAnt()){ //Botei get.Ant pois o loop só mostrava até o anterior (no caso o proximo do inicio já que estamos decrementando) ao inicio
            System.out.println(atual.getElemento());
            atual = atual.getAnt();
        }
    }



}
