public class Aluno {

  Prova prova1 = new Prova();

  Prova prova2 = new Prova();

  double media;

    public double calcularMedia() {
        media = (prova1.notaTotal + prova2.notaTotal)/2;
        System.out.println("A media do aluno eh: " + media);
        return media;
    }

}
