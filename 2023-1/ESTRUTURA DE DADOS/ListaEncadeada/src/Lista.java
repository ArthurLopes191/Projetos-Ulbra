public class Lista {
    Elemento primeiro, ultimo;
    int tamanho;

    public boolean add(Elemento e){
        if(this.primeiro == null) {
            this.primeiro = e;
            this.tamanho ++;
        }else{
            e.proximo = this.primeiro;
            this.primeiro = e;
            this.tamanho ++;
        }
        return true;
    }

    public boolean addFirst(Elemento e){
        this.primeiro = e;
        this.tamanho ++;
        return true;
    }

    public boolean addEnd(Elemento e){
        if(this.primeiro == null){
            addFirst(e);
        }else{
            Elemento aux = primeiro;
            while(aux.proximo !=null){
                aux=aux.proximo;
            }
            aux.proximo = e;
            ultimo = e;
            this.tamanho++;
        }
        return true;
    }

    public int getTamanho(){
        return this.tamanho;
//        int tam = 0;
//        Elemento e = this.primeiro;
//        while(e != null){
//            tam++;
//            e = e.proximo;
//        }
//        return tam;
    }
}
