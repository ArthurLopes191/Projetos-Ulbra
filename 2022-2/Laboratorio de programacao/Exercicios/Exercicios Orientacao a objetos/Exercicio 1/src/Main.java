public class Main {
    public static void main(String[] args) {

        Relogio r1 = new Relogio();

        r1.acertarRelogio(3, 30, 50);

        System.out.println("Posicao da hora: " + r1.ponteiroHora.posicao);
        System.out.println("Posicao do minuto:"  + r1.ponteiroMinuto.posicao);
        System.out.println("Posicao do segundo: " + r1.ponteiroSegundo.posicao);

        int hora = r1.lerHora();
        int minuto = r1.lerMinuto();
        int segundo = r1.lerSegundo();


        System.out.println("Hora: " + hora);
        System.out.println("Minuto: " + minuto);
        System.out.println("Segundo:" + segundo);


        Relogio r2 = new Relogio();

        r2.acertarRelogio(22, 0, 0);

        System.out.println("Valor da hora " + r2.lerHora());
    }
}