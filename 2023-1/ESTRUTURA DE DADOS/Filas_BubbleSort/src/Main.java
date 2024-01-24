import java.util.Scanner;

/*Crie uma fila em Java e implemente uma função que receba como entrada uma lista de números inteiros e retorne uma nova lista com os mesmos números,
mas em ordem crescente. Utilize o algoritmo de ordenação bubble sort.*/
public class Main {

    public static void main(String[] args) {

    Scanner scan = new Scanner(System.in);
    int temp, num, count = 0;

        System.out.println("informe o tamanho do array: ");
        num = scan.nextInt();
        Fila opFila = new Fila(num);

        do {
            count++;
            System.out.println("Informe o numero da posicao: " + count);
            int posicao = scan.nextInt();
            opFila.add(posicao);
        }while(count < num);

        for(int i = 0; i < opFila.vetor.length-1; i++){
            for(int j = 0; j < opFila.vetor.length-i-1; j++){
                if(opFila.vetor[j] > opFila.vetor[j+1]){
                    temp = opFila.vetor[j+1];
                    opFila.vetor[j+1] = opFila.vetor[j];
                    opFila.vetor[j] = temp;
                }
            }
        }

        opFila.list();

    }
}