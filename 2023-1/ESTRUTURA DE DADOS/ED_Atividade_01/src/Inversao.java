/*Leia um conjunto de valores inteiros e em seguida os exiba-os na ordem inversa do que foram digitados.*/
import java.util.Scanner;

public class Inversao {
    Scanner scan = new Scanner(System.in);
    private int[] Numeros;
    private int Qtd;

    public void VerValores() {
        System.out.println("Digite a quantidade de numeros: ");
        Qtd = scan.nextInt();
        Numeros = new int[Qtd];
        for (int i = 0; i < Qtd; i++) {
            System.out.println("Digite os nomero nas posicao: " + (i+1));
            Numeros[i] = scan.nextInt();
        }
    }

    public void ValoresInvertidos(){
            for(int i = Qtd - 1; i >= 0; i--){
                System.out.println(Numeros[i]);
            }
        }
}

