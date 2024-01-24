/*Leia um conjunto de alunos, cada uma com o nome e a nota. Em seguida exiba o nome dos alunos que possuem a nota maior do que a média da turma*/
import java.util.Scanner;

public class Aluno {
    Scanner scan = new Scanner(System.in);
    private String[] Nomes;
    private double[] Notas;
    private double Media = 0;
    private int Qtd;

    public void LerAlunos() {

        System.out.println("Digite a quantidade de alunos: ");
        Qtd = scan.nextInt();
        Nomes = new String[Qtd];
        Notas = new double[Qtd];

        for (int i = 0; i < Qtd; i++) {
            System.out.println("Informe o nome do aluno " + (i + 1) + ": ");
            Nomes[i] = scan.next();
            System.out.println("Informe a nota do aluno " + (i + 1) + ": ");
            Notas[i] = scan.nextDouble();

        }
    }

    public double VerificarMediaAluno() {
        for (int i = 0; i < Qtd-1; i++) {
            Media += Notas[i];
        }
        Media /= Qtd-1;
        return this.Media;
    }

    public void VerificarAlunoAcimaMedia(){
        for (int i = 0; i < Qtd-1; i++){
            if(Notas[i] > Media){
                System.out.println("Aluno " + Nomes[i] + " com nota: " + Notas[i] + " passou acima da media: " + Media);
            }
        }

    }
}
