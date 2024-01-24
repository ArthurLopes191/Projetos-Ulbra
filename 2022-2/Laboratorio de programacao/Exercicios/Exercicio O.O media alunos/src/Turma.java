public class Turma {

        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();
        double mediaTurma;


        public double calcularMediaTurma() {
            mediaTurma = (aluno1.media + aluno2.media + aluno3.media)/3;
            System.out.println("A media da turma eh: " + mediaTurma);
            return mediaTurma;
        }



}
