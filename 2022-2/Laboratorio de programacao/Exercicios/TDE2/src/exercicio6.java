/*Escrever um programa que leia o nome de um vendedor, o seu salário fixo e o
total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este
vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o
seu nome, o salário fixo e salário no final do mês.*/

import java.util.Scanner;
import java.text.DecimalFormat;

public class exercicio6 {
    public static void main(String[] args){
        String vendedor;
        float salario;
        float vendas;
        float comissao;
        float salarioFinal;
        Scanner scan = new Scanner(System.in);
        DecimalFormat formatador = new DecimalFormat("0.00");

        System.out.println("Informe o nome do vendedor:");
        vendedor = scan.nextLine();
        System.out.println("Informe o salario fixo do vendedor: ");
        salario = scan.nextInt();
        System.out.println("Informe o valor total em vendas do cliente:");
        vendas = scan.nextInt();

        comissao = vendas * 0.15f;
        salarioFinal = salario + comissao;

        System.out.println("Vendedor: " + vendedor);
        System.out.println("Salario: R$" + formatador.format(salario));
        System.out.println("Comissao: R$" + formatador.format(comissao));
        System.out.println("Salario Final: R$" + formatador.format(salarioFinal));

    }

}
