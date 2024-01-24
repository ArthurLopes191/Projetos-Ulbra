public class SaladeAula {
    private int numAlunos;

    public saladeAula(int numAlunos){
        this.numAlunos = numAlunos;
    }

    public SaladeAula(){

    }

    public int reservar(int dias){
        return dias;
    }

    public void reservar(int dias){
        System.out.println(dias);
    }

    public int reservar(Date data){
        return 1;
    }

    public void reservar(String nome){
        System.out.println(nome);
    }
}
