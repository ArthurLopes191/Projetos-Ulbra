public class Main {
    public static void main(String[] args) {
        Lista lista = new Lista();
        Ordenacao ordenacao = new Ordenacao();

        Elemento e1 = new Elemento(2);
        lista.addFirst(e1);
        Elemento e2 = new Elemento(3);
        lista.addFirst(e2);
        Elemento e3 = new Elemento(8);
        lista.addFirst(e3);
        Elemento e4 = new Elemento(5);
        lista.addFirst(e4);
        Elemento e5 = new Elemento(7);
        lista.addEnd(e5);

        System.out.println("Lista:");
        lista.showAllLista();

        System.out.println("Inserindo elemento pela posicao: ");
        Elemento e6 = new Elemento(6);
        lista.addAfterPosition(2, e6);
        lista.showAllLista();

        System.out.println("Ordenando de forma CRESCENTE utilizando Bubble Sort");
        Lista listaCrescente = ordenacao.bubbleSortCrescente(lista);
        listaCrescente.showAllLista();

        System.out.println("Ordenando de forma DECRESCENTE utilizando Selection Sort");
        Lista listaDecrescente = ordenacao.selectionSortDecrescente(lista);
        listaDecrescente.showAllLista();

        System.out.println("Lista normal:");
        lista.showAllLista();
    }
}