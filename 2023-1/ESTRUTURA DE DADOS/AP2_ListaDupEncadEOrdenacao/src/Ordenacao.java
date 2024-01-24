public class Ordenacao {

    public Lista bubbleSortCrescente(Lista lista) {
        Lista ListaOrdenada = copiarLista(lista); //Aqui  cria uma cópia da lista original usando o método copiarLista que está mais abaixo como private pois só vai ter acesso nesta classe

        // Aplicar o algoritmo Bubble Sort na lista ordenada

        boolean ordenada = false;
        while (!ordenada) {
            ordenada = true;
            Elemento atual = ListaOrdenada.inicio;
            while (atual != null && atual.getProx() != null) {
                Elemento next = atual.getProx();
                if (atual.getElemento() > next.getElemento()) {
                    // Trocar os elementos
                    int temp = atual.getElemento();
                    atual.setElemento(next.getElemento());
                    next.setElemento(temp);
                    ordenada = false;
                }
                atual = next;
            }
        }

        return ListaOrdenada;
    }

    public Lista selectionSortDecrescente(Lista lista) {
        Lista listaOrdenada = new Lista();

        // Cria uma cópia da lista original
        Lista listaCopia = copiarLista(lista);

        while (listaCopia.inicio != null) {
            Elemento max = findMaxAndRemove(listaCopia); // Chama o metodo findMaxAndRemove que está mais abaixo como private pois só vai ter acesso nesta classe
            listaOrdenada.addEnd(new Elemento(max.getElemento()));
        }

        return listaOrdenada;
    }

    private Elemento findMaxAndRemove(Lista lista) {
        Elemento max = lista.inicio;
        Elemento maxAnt = null;
        Elemento atual = lista.inicio;
        Elemento ant = null;

        while (atual != null) {
            if (atual.getElemento() > max.getElemento()) {
                max = atual;
                maxAnt = ant;
            }
            ant = atual;
            atual = atual.getProx();
        }

        // Remove o elemento máximo da lista
        if (maxAnt == null) {
            lista.inicio = max.getProx();
        } else {
            maxAnt.setProx(max.getProx());
        }

        return new Elemento(max.getElemento()); // Retorna uma nova instância do elemento máximo
    }

    private Lista copiarLista(Lista lista) {
        Lista listaCopia = new Lista();
        Elemento atual = lista.inicio;

        while (atual != null) {
            listaCopia.addEnd(new Elemento(atual.getElemento()));
            atual = atual.getProx();
        }

        return listaCopia;
    }





}