public class Main {
    public static void main(String[] args) {
        Recursividade recursividade = new Recursividade();

        int n = 5;
        System.out.println(recursividade.calcularFatorial(n));

        int vetor[] = {1, 7, 10, 10};

        System.out.println(recursividade.somaRecursivaElementos(vetor, 0));

        String p = "tenet";
        boolean result = recursividade.verificarPalindromo(p);
        System.out.println("Eh um palindromo?: " + result);
    }
}