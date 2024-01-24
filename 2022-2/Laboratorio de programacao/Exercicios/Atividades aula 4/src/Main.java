/*1 - Crie uma classe que simule a jogada de um dado de seis lados (números
de 1 a 6) por três vezes. Ao final some seus valores e apresente o resultado
das três jogadas.*/

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int Soma = 0;
        for (int i = 1; i <= 3; i++) {
            int SorteioDado = (int) (Math.random() * 6);
            System.out.println("Na jogada " + i + " o lado sorteado do dado foi: " + SorteioDado);
            Soma = SorteioDado + Soma;
        }
            System.out.println("O resultado da soma das tres jogadas eh: " + Soma );
    }
}