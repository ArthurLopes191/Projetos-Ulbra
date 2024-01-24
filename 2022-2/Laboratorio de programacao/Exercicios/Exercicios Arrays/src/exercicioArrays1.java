import java.util.Scanner;

public class exercicioArrays1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner (System.in);
        int[] vetorA = new int[5];
        int[] vetorB = new int[vetorA.length];

        for(int i = 0; i < vetorA.length; i++) {
            System.out.println("Entrar com um valor na posicao:" + i);
            vetorA[i] = scan.nextInt();

        }

        for(int i = 0; i < vetorA.length; i++){
            vetorB[i] = vetorA[i];
        }

        System.out.println("Vetor A=");
        for (int i = 0; i<vetorA.length;i++){
            System.out.println(vetorA[i] + " ");
        }
        System.out.println();
        System.out.println("vetor B = ");
        for (int i = 0; i<vetorA.length;i++){
            System.out.println(vetorB[i] + " ");
        }
    }
}
