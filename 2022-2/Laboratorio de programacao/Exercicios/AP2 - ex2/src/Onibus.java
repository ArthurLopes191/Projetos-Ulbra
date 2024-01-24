public class Onibus extends Veiculo {

    @Override
    public void ligar() {
        super.ligar();
        System.out.println("Onibus ligado");
    }

    @Override
    public void desligar() {
        super.desligar();
        System.out.println("Onibus desligado");
    }
}
