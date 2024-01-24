public class Trapezio {
    public double baseMaior;

    public double baseMenor;

    public double altura;
    public double area;

    double calcularArea(){
        area = ((baseMaior + baseMenor)/2) * altura;
        System.out.println("A area do Trapezio eh: " + area);
        return area;
    }
}
