public class Prova {
    private double notaParte1;
    private double notaParte2;
    double notaTotal;

    public double calcularNotaTotal(double nota1, double nota2){
        this.notaParte1 = nota1;
        this.notaParte2 = nota2;
        notaTotal = notaParte1 + notaParte2;
        if(notaTotal > 10){
            notaTotal = 10;
        }
        System.out.println("A nota total da prova do aluno eh:" + notaTotal);
        return notaTotal;
    }
}
