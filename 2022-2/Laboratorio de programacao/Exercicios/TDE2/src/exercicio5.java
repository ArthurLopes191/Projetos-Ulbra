/*Escrever um programa em java para calcular o consumo médio de um automóvel sendo
fornecida a distância total percorrida pelo automóvel e o total de combustível gasto.*/

import java.util.Scanner;

public class exercicio5 {
    public static void main(String[] args){
        float distancia;
        float gasto;
        float media;
        Scanner scan = new Scanner(System.in);

        System.out.println("Digite a distancia total percorrida pelo automovel");
        distancia = scan.nextInt();
        System.out.println("Digite o total de combustivel gasto");
        gasto = scan.nextInt();

        media = distancia/gasto;

        System.out.println("O consumo medio de combustivel eh: " + media + " litros");
    }
}



