import java.util.Scanner;

public class exercicioArrays9 {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        float[] vetorA = new float[10];
        float[] vetorB = new float[vetorA.length];
        float[] vetorC = new float[vetorA.length];

        for (int i = 0; i < vetorA.length; i++) {
            System.out.println("Entrar com um valor para o vetorA na posicao:" + i);
            vetorA[i] = scan.nextFloat();

        }

        for (int i = 0; i < vetorA.length; i++) {
            System.out.println("Entrar com um valor para o vetorB na posicao:" + i);
            vetorB[i] = scan.nextFloat();

        }

        for (int i = 0; i < vetorA.length; i++) {
            vetorC[i] = vetorA[i] / vetorB[i];
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
