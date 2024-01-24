import java.util.Scanner;

/*Elabore uma classe que receba 5 notas de alunos por meio, armazene essas notas em um array de cinco elementos, apresente em tela as cinco notas em ordem decrescente (da maior para a menor) e a média aritmética das notas.*/
public class ex_vetores_2 {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        double[] notasArray = new double[5];
        double soma = 0;
        double media = 0;

        for(int i = 0; i < notasArray.length; i++){
            System.out.println("Digite a nota " + (i+1));
            notasArray[i] = scan.nextDouble();
            soma += notasArray[i];

        }

        for(int i = 0; i < notasArray.length-1; i++){
            for(int j = 0; j < notasArray.length-i-1; j++){
                if(notasArray[j] < notasArray[j+1]){
                    double notaTemp = notasArray[j+1];
                    notasArray[j+1] = notasArray[j];
                    notasArray[j] = notaTemp;
                }
            }
        }

        System.out.println("NOTAS EM ORDEM DECRESCENTE: ");
        for(int i = 0; i < notasArray.length; i++) {
            System.out.println(notasArray[i]);
        }

        media = soma / notasArray.length;
        System.out.println("A media eh: " + media);
    }
}
