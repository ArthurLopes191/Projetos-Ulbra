public class Automovel extends Veiculo {

    @Override
    public void ligar() {
        super.ligar();
        System.out.println("Automovel Ligado");
    }

    @Override
    public void desligar() {
        super.desligar();
        System.out.println("Automovel Desligado");
    }
}
