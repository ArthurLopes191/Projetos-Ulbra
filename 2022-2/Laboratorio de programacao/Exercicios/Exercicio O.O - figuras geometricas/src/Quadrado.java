public class Quadrado {
    public double lado;
    public double area;

    double calcularArea(){
        area = Math.pow (lado, 2);
        System.out.println("A area do Quadrado eh: " + area);
        return area;
    }
}
