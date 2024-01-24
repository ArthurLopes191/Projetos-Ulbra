public class Circunferencia {

    public double raio;
    public double area;

    double calcularArea(){
        area = Math.PI * Math.pow(raio, 2);
        System.out.println("A area da Circunferencia eh: " + area);
        return area;
    }
}
