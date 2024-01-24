public class Main {
    public static void main(String[] args) {
        Circunferencia circulo = new Circunferencia(2);
        System.out.println(circulo.calcularArea());

        Quadrado quadrado = new Quadrado(5);
        System.out.println(quadrado.calcularArea());

        Retangulo retangulo = new Retangulo(8, 10);
        System.out.println(retangulo.calcularArea());
    }
}