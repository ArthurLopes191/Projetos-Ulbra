public class Circunferencia implements AreaCalculavel {

    private int raio;

    //construtor
    public Circunferencia(int raio){
        this.raio = raio;
    }

    public double calcularArea(){
        return Math.PI * Math.pow(raio, 2);
    }



}
