public class Main {
    public static void main(String[] args) {
        Elemento a = new Elemento();
        a.valor = 10;
        a.valor = 12;
        Elemento b = new Elemento();
        b.valor = 10;
        b.valor = 12;
        Elemento c = new Elemento();
        c.valor = 200;

        Lista minhaLista = new Lista();
        minhaLista.add(a);
        minhaLista.add(b);
        minhaLista.addEnd(c);

        System.out.println(minhaLista.getTamanho());
    }
}