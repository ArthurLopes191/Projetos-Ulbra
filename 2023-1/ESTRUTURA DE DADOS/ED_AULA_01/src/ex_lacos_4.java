/*Escrever um programa que receba vários números inteiros no teclado e no final imprimir a média dos números múltiplos de 3. Para sair digitar 0(zero).*/
import java.util.Scanner;

public class ex_lacos_4 {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int valor, soma = 0;
        float media = 0;
        int count = 0;

        do{
            System.out.println("Informe um valor inteiro: ");
            valor = scan.nextInt();
            if (valor == 0){
                count--;
            } else if (valor%3 == 0){
                count++;
                soma = soma + valor;
                media = soma/count;
            }


        }while (valor != 0);
        System.out.println("Programa encerrado apos ser digitado 0");
        System.out.println("A media dos valores multiplos de 3 eh: " + media);

    }
}
