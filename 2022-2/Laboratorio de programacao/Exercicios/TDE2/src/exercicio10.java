/*Faça um programa que receba o preço de custo de um produto e mostre o
valor de venda. Sabe-se que o preço de custo receberá um acréscimo de
acordo com um percentual informado pelo usuário.*/

import java.util.Scanner;
public class exercicio10 {
    public static void main(String[] args){
        float precoCusto;
        float acrescimo;
        float precoFinal;
        Scanner scan = new Scanner(System.in);

        System.out.println("Informe o preco de custo do produto: ");
        precoCusto = scan.nextFloat();

        System.out.println("Informe a porcentagem de acrescimo");
        acrescimo = scan.nextFloat();

        acrescimo = precoCusto * (acrescimo/100);
        precoFinal = precoCusto + acrescimo;

        System.out.println("O valor da venda com o acrescimo de " +acrescimo+ "% eh: R$" +precoFinal);
    }
}
