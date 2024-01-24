

/*Implemente uma fila de String com as operações básicas de uma fila num vetor de 10 elementos.
 */
public class Main {

    public static void main(String[] args) {
    Fila opFila = new Fila(5);
    opFila.add("Arthur");
    opFila.add("Joao");
    opFila.add("Claudio");
    opFila.add("Paulo");
    opFila.add("Jose");
    opFila.list();
    System.out.println("-------------------------");
    opFila.remove();
    opFila.list();

    }
}