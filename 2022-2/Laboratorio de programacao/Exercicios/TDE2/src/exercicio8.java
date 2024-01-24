/*Escrever uma programa em que leia dois valores para as variáveis A e B, e
efetuar as trocas dos valores de forma que a variável A passe a possuir o valor
da variável B e a variável B passe a possuir o valor da variável A. Apresentar
os valores trocados.
Lembrando que temos que ter 3 variáveis para que uma haja como variável
de armazenamento, ou seja, para evitar que o valor original de a se perca é
necessário associar a uma outra variável (denominada usualmente de
variável auxiliar) tal valor, estabelecer uma associação de a com o valor em b
e, por último, associar b ao valor "salvo" na variável auxiliar.*/

import java.util.Scanner;

public class exercicio8 {
    public static void main(String[] args){
        int a;
        int b;
        int auxiliar;
        Scanner scan = new Scanner(System.in);

        System.out.println("Informe o valor de A:");
        a = scan.nextInt();
        System.out.println("Informe o valor de B:");
        b = scan.nextInt();

        auxiliar = a;
        a = b;
        b = auxiliar;

        System.out.println("Agora A vale: " + a);
        System.out.println("Agora B vale: " + b);
    }
}
