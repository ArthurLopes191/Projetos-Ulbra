public class Elemento {
    int dado;

    Elemento prox, ant;

    public Elemento (int dado) {
        this.dado = dado;
    }

    /*Retorna o elemento deste nó*/
    public int getElemento(){
        return dado;
    }

    /*Retorna o nodo anterior a este */
    public Elemento getAnt(){
        return ant;
    }

    /*Retorna o nodo posterior a este */
    public Elemento getProx(){
        return prox;
    }

    /*Atribui o elemento deste nó*/
    public void setElemento(int e){
        dado = e;
    }

    /*Atribui o nodo anterior deste nodo*/
    public void setAnt(Elemento a){
        ant = a;
    }

    /*Atribui o nodo seguinte a este nodo*/
    public void setProx(Elemento p){
        prox = p;
    }
}

