public class Recursividade {
    public static int calcularFatorial(int n){
        if(n==0){
            return 1;
        }
        return n * calcularFatorial(n - 1);
    }

    public static int somaRecursivaElementos (int[] vetor, int i){
        if(i == vetor.length){
            return 0;
        }
        return vetor[i] + somaRecursivaElementos(vetor, i+1);
    }

    public static boolean verificarPalindromo(String palavra) {
        // Caso base: palavra vazia ou com apenas um caractere é um palíndromo
        if (palavra.length() <= 1) {
            return true;
        }

        if (palavra.charAt(0) == palavra.charAt(palavra.length() - 1)) {

            return verificarPalindromo(palavra.substring(1, palavra.length() - 1));
        } else {
            return false;
        }
    }
}
