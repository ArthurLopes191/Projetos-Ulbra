public class Main {
    public static void main(String[] args) {
        Lista lista = new Lista();

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

        System.out.println("Lista após remover o elemento do inicio da lista");
        lista.removeFirst();
        lista.showAllLista();

        System.out.println("Mostrando o valor que está na posicao 2 da lista:");
        System.out.println(lista.getElementoByPosition(2));

        System.out.println("Removendo o elemento do final da lista:");
        lista.removeEnd();
        lista.showAllLista();

        System.out.println("Mostrando a lista ao contrário: ");
        lista.showAllListaAoContrario();

    }
}