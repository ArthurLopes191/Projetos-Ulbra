/*EX 1 - Escreva uma classe que Leia 5 nomes e notas de uma turma, calcula e exibe a média das notas da turma e em seguida exibe a relação de nomes cuja nota é superior a esta média. Utilize vetores para armazenar as notas.*/
import java.util.Scanner;

public class Turma {
    private String[] Nomes = new String[5];
    private double[] Notas = new double[5];
    private double Media = 0;

    public double VerificarMedia() {
        Scanner scan = new Scanner(System.in);
        for (int i = 0; i < 5; i++) {
            System.out.println("Informe o nome do aluno " + (i+1) + ": ");
            Nomes[i] = scan.nextLine();
            System.out.println("Informe a nota do aluno " + (i+1) + ": ");
            Notas[i] = scan.nextDouble();
            scan.nextLine();
            Media += Notas[i];
        }
        Media /= Nomes.length;
        return this.Media;
    }

    public void VerificarTurmaAcimaMedia(){
        for (int i = 0; i < 5; i++){
            if(Notas[i] > Media){
                System.out.println("Aluno " + Nomes[i] + " com nota: " + Notas[i] + " passou acima da media: " + Media);
            }
        }

    }
}
