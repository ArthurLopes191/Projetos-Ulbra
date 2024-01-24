public class Main {
    public static void main(String[] args) {
        Turma turma1 = new Turma();

        System.out.println("ALUNO 1");
        turma1.aluno1.prova1.calcularNotaTotal(4.0, 2.5);
        turma1.aluno1.prova2.calcularNotaTotal(1.0, 7.0);
        turma1.aluno1.calcularMedia();
        System.out.println("--------------------------------");

        System.out.println("ALUNO 2");
        turma1.aluno2.prova1.calcularNotaTotal(6.5, 3.5);
        turma1.aluno2.prova2.calcularNotaTotal(0.0, 3.0);
        turma1.aluno2.calcularMedia();

        System.out.println("--------------------------------");

        System.out.println("ALUNO 3");
        turma1.aluno3.prova1.calcularNotaTotal(5.0, 4.0);
        turma1.aluno3.prova2.calcularNotaTotal(6.0, 1.5);
        turma1.aluno3.calcularMedia();

        System.out.println("--------------------------------");

        turma1.calcularMediaTurma();
    }
}
