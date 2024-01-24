/*Escrever um programa que leia o nome de um aluno e as notas das três
provas que ele obteve no semestre. No final informar o nome do aluno e a
sua média (aritmética).*/

import java.util.Scanner;
import java.text.DecimalFormat;

public class exercicio7 {
    public static void main(String[] args){
        String aluno;
        float prova1;
        float prova2;
        float prova3;
        float media;
        Scanner scan = new Scanner(System.in);
        DecimalFormat formatador = new DecimalFormat("0.00");

        System.out.println("Informe o nome do aluno:");
        aluno = scan.nextLine();
        System.out.println("Informe a nota da primeira prova do aluno:");
        prova1 = scan.nextFloat();
        System.out.println("Informe a nota da segunda prova do aluno:");
        prova2 = scan.nextFloat();
        System.out.println("Informe a nota da terceira prova do aluno:");
        prova3 = scan.nextFloat();

        media = (prova1 + prova2 + prova3)/3;

        System.out.println("A media do aluno " + aluno + " eh: " + formatador.format(media));
    }
}
