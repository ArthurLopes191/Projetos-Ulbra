/*Solicitar a idade de um número indefinido de pessoas e imprimir a média de idade lidas. O programa se encerra quando a média de idade for superior a 20 anos ou que tenha lido 10 pessoas.*/
import java.util.Scanner;

public class ex_lacos_2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int pessoas = 0, soma = 0, idade = 0;
        float media = 0;

        while(pessoas < 2) {
            System.out.println("Informe um numero definido de pessoas que seja maior que 2: ");
            pessoas = scan.nextInt();
        }

        for(int i = 1; i <= pessoas; i++){
            System.out.println("Informe a idade da pessoa " + i + ":");
            idade = scan.nextInt();
            soma += idade;
            media = soma/pessoas;

        }
        System.out.println("A media de idades das" + pessoas + "pessoas eh:" + media);
    }
}
