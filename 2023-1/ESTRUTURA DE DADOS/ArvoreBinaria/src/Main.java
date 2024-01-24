public class Main {
    public static void main(String[] args) {
        ArvoreBinaria arvore = new ArvoreBinaria();

        arvore.adicionar(50);
        arvore.adicionar(30);
        arvore.adicionar(20);
        arvore.adicionar(40);
        arvore.adicionar(70);
        arvore.adicionar(60);
        arvore.adicionar(80);

        // Percorrer em ordem
        System.out.println("Percorrer em Ordem:");
        arvore.percorrerEmOrdem(arvore.raiz);

        // Percorrer em pré-ordem
        System.out.println("Percorrer em Pré-Ordem:");
        arvore.percorrerPreOrdem(arvore.raiz);

        // Percorrer em pós-ordem
        System.out.println("Percorrer em Pós-Ordem:");
        arvore.percorrerPosOrdem(arvore.raiz);

        System.out.println("Mostrar arvore");

        arvore.mostrarArvore();

        arvore.remover(30);
        arvore.remover(80);

        System.out.println("Mostrar arvore após remoção");
        arvore.mostrarArvore();
    }
}