import java.util.Scanner;

public class exercicioArrays7 {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int[] vetorA = new int[10];
        int[] vetorB = new int[vetorA.length];
        int[] vetorC = new int[vetorA.length];

        for (int i = 0; i < vetorA.length; i++) {
            System.out.println("Entrar com um valor para o vetorA na posicao:" + i);
            vetorA[i] = scan.nextInt();

        }

        for (int i = 0; i < vetorA.length; i++) {
            System.out.println("Entrar com um valor para o vetorB na posicao:" + i);
            vetorB[i] = scan.nextInt();

        }

        for (int i = 0; i < vetorA.length; i++) {
            vetorC[i] = vetorA[i] - vetorB[i];
        }

        System.out.println("Vetor A=");
        for (int i = 0; i < vetorA.length; i++) {
            System.out.println(vetorA[i] + " ");
        }
        System.out.println();
        System.out.println("vetor B = ");
        for (int i = 0; i < vetorA.length; i++) {
            System.out.println(vetorB[i] + " ");
        }

        System.out.println("vetor C = ");
        for (int i = 0; i < vetorA.length; i++) {
            System.out.println(vetorC[i] + " ");
        }
    }
}


