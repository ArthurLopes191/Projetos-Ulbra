class ArvoreBinaria {
    public No raiz;

    public ArvoreBinaria() {
        this.raiz = null;
    }

    public void adicionar(int valor) {
        raiz = adicionarNo(raiz, valor);
    }

    private No adicionarNo(No no, int valor) {
        if(no == null){
            return new No(valor);
        }
        if(valor < no.valor){
            no.esquerda = adicionarNo(no.esquerda, valor);
        }else if (valor > no.valor){
            no.direita = adicionarNo(no.direita, valor);
        }
        return no;
    }

    public void remover(int valor) {
        raiz = removerNo(raiz, valor);
    }

    private No removerNo(No no, int valor) {
        if (no == null) {
            return null;
        }

        if (valor < no.valor) {
            no.esquerda = removerNo(no.esquerda, valor);
        } else if (valor > no.valor) {
            no.direita = removerNo(no.direita, valor);
        } else {
            if (no.esquerda == null) {
                return no.direita;
            } else if (no.direita == null) {
                return no.esquerda;
            }

            no.valor = encontrarMinimoValor(no.direita);
            no.direita = removerNo(no.direita, no.valor);
        }

        return no;
    }

    private int encontrarMinimoValor(No no) {
        int minimoValor = no.valor;
        while (no.esquerda != null) {
            minimoValor = no.esquerda.valor;
            no = no.esquerda;
        }
        return minimoValor;
    }

    public void percorrer() {
        percorrerEmOrdem(raiz);
    }

    public void percorrerEmOrdem(No no) {
        if (no != null) {
            percorrerEmOrdem(no.esquerda);
            System.out.print(no.valor + " ");
            percorrerEmOrdem(no.direita);
        }
    }
    public void percorrerPreOrdem(No no) {
        if (no != null) {
            System.out.print(no.valor + " ");
            percorrerPreOrdem(no.esquerda);
            percorrerPreOrdem(no.direita);
        }
    }

    public void percorrerPosOrdem(No no) {
        if (no != null) {
            percorrerPosOrdem(no.esquerda);
            percorrerPosOrdem(no.direita);
            System.out.print(no.valor + " ");
        }
    }

    public void mostrarArvore() {
        mostrarArvoreRecursivamente(raiz, "");
    }

    private void mostrarArvoreRecursivamente(No no, String prefixo) {

    if (no == null){
        return;
    }
        mostrarArvoreRecursivamente(no.direita, prefixo + "   /");
        System.out.println(prefixo + "--" + no.valor);
        mostrarArvoreRecursivamente(no.esquerda, prefixo + "   \\");
    }

}
