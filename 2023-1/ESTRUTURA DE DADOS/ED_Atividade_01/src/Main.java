import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int op = 0;
        while(op < 1 || op > 7){
            System.out.println("Digite 1 para mostrar o EX 1 ");
            System.out.println("Digite 2 para mostrar o EX 2 ");
            System.out.println("Digite 3 para mostrar o EX 3 ");
            System.out.println("Digite 4 para mostrar o EX 4 ");
            System.out.println("Digite 5 para mostrar o EX 5 ");
            System.out.println("Digite 6 para mostrar o EX 6 ");
            System.out.println("Digite 7 para mostrar o EX 7 ");
            op = scan.nextInt();
        }

        switch (op){
            case 1:
                Turma turma = new Turma();
                double media = turma.VerificarMedia();
                System.out.println("Media da turma: " + media);
                turma.VerificarTurmaAcimaMedia();
            break;

            case 2:
                Notas notas = new Notas();
                notas.LerNotas();
                media = notas.CalcularMediaNotas();
                System.out.println("A media das notas deu: " + media);
                notas.VerificarNotasAcimaMedia();
                notas.VerificarNotasAbaixoMedia();
            break;

            case 3:
                Aluno aluno = new Aluno();
                aluno.LerAlunos();
                media = aluno.VerificarMediaAluno();
                System.out.println("A media das notas deu: " + media);
                aluno.VerificarAlunoAcimaMedia();
            break;

            case 4:
                Inversao inversao = new Inversao();
                inversao.VerValores();
                inversao.ValoresInvertidos();
            break;

            case 5:
                VetorOrdenado vetorOrdenado = new VetorOrdenado();
                vetorOrdenado.PreencherNumerosOrdenados();
            break;

            case 6:
                VetorRandom vetorRandom = new VetorRandom();
                vetorRandom.PreencherNumerosRandom();
            break;

            case 7:
                Scanner sc = new Scanner(System.in);
                int[][] matriz = new int[5][5];
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5; j++) {
                        System.out.printf("Digite o valor da posicao [%d][%d]: ", i, j);
                        matriz[i][j] = sc.nextInt();
                    }
                }
                Estatistica estatistica = new Estatistica(matriz);
                estatistica.mostrarEstatisticas();
            break;
        }


    }
}