/*EX2 - Leia um conjunto de notas, cuja quantidade seja determinada pelo usuário. Calcule a média de todas elas. Exiba o conjunto das notas maiores do que a média calculada. Em seguida, de forma agrupada, exiba o outro conjunto de notas (menores do que a média).Utilize vetores*/
import java.util.Scanner;

public class Notas {
    Scanner scan = new Scanner(System.in);

    private double[] Notas;
    private int Qtd;
    private double Media = 0;

    public void LerNotas() {
        System.out.println("Digite a quantidade de notas: ");
        Qtd = scan.nextInt();
        Notas = new double[Qtd];
        for (int i = 0; i <= Qtd-1; i++) {
            System.out.println("Informe a nota " + (i + 1) + ": ");
            Notas[i] = scan.nextDouble();
        }
    }

    public double CalcularMediaNotas() {
        for (int i = 0; i < Qtd-1; i++) {
            Media += Notas[i];
        }
        Media /= Qtd-1;
        return this.Media;
    }

    public void VerificarNotasAcimaMedia() {
        for (int i = 0; i < Qtd-1; i++) {
            if (Notas[i] > Media) {
                System.out.println("A nota: " + Notas[i] + " acima da media: " + Media);
            }
        }

    }

    public void VerificarNotasAbaixoMedia() {
        for (int i = 0; i < Qtd-1; i++) {
            if (Notas[i] < Media) {
                System.out.println("A nota: " + Notas[i] + " abaixo da media: " + Media);
            }
        }
    }

}