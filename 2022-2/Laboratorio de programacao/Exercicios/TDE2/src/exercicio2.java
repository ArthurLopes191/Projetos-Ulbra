/*2 - Neste exercício, você deve completar 4 tarefas:
a. Imprima todos os números inteiros de 10 a 25 utilizando uma estrutura de
repetição.
b. Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).
c. Começando em 0, imprima os números seguintes, enquanto a soma dos números já impressos for menor que 100.
d. Imprima a tabuada do 9 (até o décimo valor).*/

import java.util.Scanner;

public class exercicio2{
    public static void main(String[] args) {
        String op;

        Scanner scan = new Scanner(System.in);

        System.out.println("Digite a opção que deseja:");
        System.out.println("a. Imprima todos os números inteiros de 10 a 25 utilizando uma estrutura de repetição.");
        System.out.println("b. Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).");
        System.out.println("c. Começando em 0, imprima os números seguintes, enquanto a soma dos números já impressos for menor que 100.");
        System.out.println("d. Imprima a tabuada do 9 (até o décimo valor)");
        op = scan.nextLine();

        switch (op) {
            case "a":
                for (int i = 10; i <= 25; i++) {
                    System.out.println(i);
                };
            break;

            case "b":
                int soma = 0;
                int i;
                for (i = 1; i <= 100; i++){
                     i = i+1;
                    soma = soma + i;
                }

                System.out.println(soma);
            break;

            case "c":
                int j = 0;
                int r = 0;
                while (j + r < 100){
                    System.out.println(r);
                    j += r;
                    r++;
                }
            break;

            case "d":
                for (i = 0; i <= 10; i++){
                    int tabuada = 9;
                    tabuada = tabuada * i;
                    System.out.println("9 * " + i + " = " + tabuada);
                }
            break;
            default:

        }

    }
}
