/*2 - Uma farmácia precisa ajustar os preços de seus produtos em 12%.
Elabore uma classe que receba o valor do produto e aplique o percentual
de acréscimo. O novo valor a ser calculado deve ser arredondado para mais
ou para menos usando o método round. A classe deve também conter um
laço de repetição que encerre o programa quando o usuário fornecer o
valor zero
(0) para o valor do produto. Dessa forma, o usuário digita o valor do
produto, a classe calcula e mostra o valor com acréscimo, a seguir solicita
um novo valor. Esse processo continua enquanto o valor do produto for
diferente de zero; caso contrário o programa será encerrado*/

import java.util.Scanner;

public class exercicio2 {
    public static void main(String[] args){
        double precoProduto;
        double acrescimo = 12.0/100.0;
        double valorFinal;
        Scanner scan = new Scanner(System.in);

        do{
            System.out.println("Informe o preco do produto: ");
            precoProduto = scan.nextDouble();
            valorFinal = precoProduto + (acrescimo * precoProduto);
            System.out.println("O preco do produto com reajuste de 12% eh: " + (Math.round(valorFinal)));
        }while(precoProduto != 0);
    }
}
