/*5 - Elabore uma classe que receba uma frase e verique que se essa frase
possui palavras impróprias. As palavras impróprias são: sexo e sexual. Caso
encontre uma dessas palavras, emita em tela a mensagem “conteúdo
impróprio”, caso contrário “conteúdo liberado”,*/

import java.util.Scanner;

public class exercicio5 {
    public static void main(String[] args) {
        String frase;
        Scanner scan = new Scanner(System.in);
        System.out.println("Escreva uma frase:");
        frase = scan.nextLine();

        if (frase.contains("sexo")||frase.contains("sexual")) {
            System.out.println("conteudo improprio");
        }else{
            System.out.println("Conteudo liberado");
        }
    }
}
