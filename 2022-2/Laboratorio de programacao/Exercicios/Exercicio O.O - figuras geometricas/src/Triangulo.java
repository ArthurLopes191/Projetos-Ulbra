public class Triangulo {
    public double base;
    public double altura;
    public double area;

    double calcularArea(){
     area = (base * altura)/2;
        System.out.println("A area do Traingulo eh: " + area);
     return area;
    }
}
