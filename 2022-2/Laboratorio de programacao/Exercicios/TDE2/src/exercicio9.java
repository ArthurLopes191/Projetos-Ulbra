/*A Loja Mamão com Açúcar está vendendo seus produtos em 5 (cinco)
prestações sem juros. Faça um programa que receba um valor de uma compra
e mostre o valor das prestações*/

import java.util.Scanner;
public class exercicio9 {
    public static void main(String[] args){
        float valorCompra;
        float valorPrestacoes;
        Scanner scan = new Scanner(System.in);

        System.out.println("Informe o valor da compra: ");
        valorCompra = scan.nextFloat();

        valorPrestacoes = valorCompra/5;

        System.out.println("O valor do produto eh: R$" +valorCompra);
        System.out.println("O valor das prestacoes eh: R$" +valorPrestacoes);
    }
}
