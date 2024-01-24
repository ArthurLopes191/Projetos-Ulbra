public class Retangulo implements AreaCalculavel{

    private int base;
    private int altura;

    public Retangulo(int base, int altura){
        this.base = base;
        this.altura = altura;
    }
    public double calcularArea(){
        return base * altura;
    }
}
