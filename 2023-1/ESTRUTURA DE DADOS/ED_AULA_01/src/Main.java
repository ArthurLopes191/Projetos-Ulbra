/*Solicitar a idade de um número indefinido de  pessoas e imprimir a média de idade lidas. O programa se encerra quando a média de idade for superior a 20 anos.*/
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int idade, soma = 0;
        float media = 0;
        int count = 0;

        do{
            count++;
            System.out.println("Informe uma idade: ");
            idade = scan.nextInt();
            soma = soma + idade;
            media = soma/count;

        }while (media < 20);
        System.out.println("A media passou de 20 com valor: " + media);
        System.out.println("Programa encerrado");
    }
}


