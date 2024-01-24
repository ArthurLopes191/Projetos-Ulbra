public class Main {
    public static void main(String[] args) {
       Automovel automovel = new Automovel();
       Motocicleta motocicleta= new Motocicleta();
       Onibus onibus = new Onibus();

       automovel.ligar();
       automovel.getIsLigado();
       automovel.desligar();
       automovel.getIsLigado();

       motocicleta.ligar();
       motocicleta.getIsLigado();
       motocicleta.desligar();
       motocicleta.getIsLigado();

       onibus.ligar();
       onibus.getIsLigado();
       onibus.desligar();
       onibus.getIsLigado();
    }
}