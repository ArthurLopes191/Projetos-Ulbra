public class Main {
    public static void main(String[] args) {
        SaladeAula sala1 = new SaladeAula();
        sala1.reservar(10);
        sala1.reservar(new Date());
        sala1.reservar("livro1");
    }
}