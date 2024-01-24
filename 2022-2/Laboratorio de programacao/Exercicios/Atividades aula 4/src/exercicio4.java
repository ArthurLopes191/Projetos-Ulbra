/* 4 - Construa uma classe que receba uma frase qualquer e mostre essa
frase de trás para a frente e sem espaços em branco */

import java.util.Scanner;
public class exercicio4 {
    public static void main(String[] args){
        String frase;
        String reverso = "";
        Scanner scan = new Scanner(System.in);

        System.out.println("Escreva uma frase:");
        frase = scan.nextLine();
        String fraseSemEspaco = frase.replaceAll("\\s+","");

        for(int i = fraseSemEspaco.length()-1; i >=0; i--){
            reverso +=String.valueOf(fraseSemEspaco.charAt(i));
        }
        System.out.println(reverso);
    }
}
