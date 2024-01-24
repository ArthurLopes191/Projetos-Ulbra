import java.util.Scanner;

/*Crie um deque em Java e implemente uma função que receba como entrada uma lista de números inteiros e retorne a média móvel dos últimos K números da lista,
onde K é um número inteiro fornecido como parâmetro. A média móvel é calculada somando os últimos K números e dividindo pelo número K.*/
public class Main {

    public static void main(String[] args) {

    Scanner scan = new Scanner(System.in);
    int soma = 0, num, k, count = 0;
    double media = 0;

        System.out.println("informe o tamanho do array: ");
        num = scan.nextInt();
        Deque opFila = new Deque(num);


        System.out.println("Informe o numero da posicao 1 ");
        int posicao = scan.nextInt();
        opFila.addFirst(posicao);


        do {
            count++;
            System.out.println("Informe o numero da posicao: " + (count+1));
            posicao = scan.nextInt();
            opFila.addLast(posicao);

        }while(count < num-1);

        do{
        System.out.println("Informe o numero do indice K");
        k = scan.nextInt();
        }while(k < 0 || k > num);

        for(int i = opFila.vetor.length-1 ; i >= (num - k) ; i--){
            soma += opFila.vetor[i];
            media = soma/k;
        }

        System.out.println("-------------------------");
        System.out.println("DEQUE:");
        opFila.list();

        System.out.println("A media movel dos ultimos " + k + " numero eh: " + media);



    }
}