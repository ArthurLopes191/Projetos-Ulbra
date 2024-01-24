/*Escreva um código que crie uma lista encadeada com 5 elementos,
imprima a lista, remova o elemento de valor 3 e,
em seguida, imprima novamente a lista resultante.*/
public class Main {
    public static void main(String[] args) {
        Elemento a = new Elemento();
        a.valor = 1;
        Elemento b = new Elemento();
        b.valor = 2;
        Elemento c = new Elemento();
        c.valor = 3;
        Elemento d = new Elemento();
        d.valor = 4;
        Elemento e = new Elemento();
        e.valor = 5;


        Lista minhaLista = new Lista();
        minhaLista.addInicio(a);
        minhaLista.addInicio(b);
        minhaLista.addInicio(c);
        minhaLista.addInicio(d);
        minhaLista.addInicio(e);
        minhaLista.mostrar();
        System.out.println(" ");
        minhaLista.removerValor(3);
        minhaLista.mostrar();
    }
}