public class Quadrado implements AreaCalculavel{
    private int lado;

    public Quadrado(int lado){
        this.lado = lado;
    }

    public double calcularArea(){
        return Math.pow(lado, 2);
    }


}
