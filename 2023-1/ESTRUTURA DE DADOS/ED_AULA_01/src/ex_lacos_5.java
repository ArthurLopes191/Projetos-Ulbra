import java.util.Scanner;

/*Escrever um programa, que leia valores inteiros até ser lido o valor-99. Quando isso acontecer o programa deverá escrever a soma e a média dos valores lidos
 */
public class ex_lacos_5 {

    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int valor, soma = 0;
    float media = 0;
    int count = 0;

        do{
        count++;
        System.out.println("Informe um valor inteiro: ");
        valor = scan.nextInt();
        if (valor == -99){
            count--;
            soma -= -99;
        }
        soma = soma + valor;
        media = soma/count;

        }while (valor != -99);

        System.out.println("Programa encerrado apos ser digitado -99");
        System.out.println("A soma dos valores eh: " + soma);
        System.out.println("A media dos valores eh: " + media);

    }
}
