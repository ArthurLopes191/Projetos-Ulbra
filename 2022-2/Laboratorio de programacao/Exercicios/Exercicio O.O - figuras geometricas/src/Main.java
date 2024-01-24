import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int op;

        do {
            do {
                System.out.println("------------------------------------------------------------");
                System.out.println("Selecione opcao 1 para calcular area do Triangulo ");
                System.out.println("Selecione opcao 2 para calcular area do Quadrado ");
                System.out.println("Selecione opcao 3 para calcular area do Circunferencia ");
                System.out.println("Selecione opcao 4 para calcular area do Trapezio ");
                System.out.println("Selecione opcao 5 para SAIR ");
                System.out.println("------------------------------------------------------------");
                op = scan.nextInt();
            } while (op < 0 || op > 5);

            switch (op) {
                case 1:
                    Triangulo triangulo = new Triangulo();

                    System.out.println("Informe base do Triangulo");
                    triangulo.base = scan.nextDouble();
                    System.out.println("Informe altura Triangulo");
                    triangulo.altura = scan.nextDouble();

                    triangulo.calcularArea();

                    break;

                case 2:
                    Quadrado quadrado = new Quadrado();

                    System.out.println("Informe o lado do Quadrado");
                    quadrado.lado = scan.nextDouble();

                    quadrado.calcularArea();

                    break;

                case 3:
                    Circunferencia circunferencia = new Circunferencia();

                    System.out.println("Informe o raio da Circunferencia");
                    circunferencia.raio = scan.nextDouble();

                    circunferencia.calcularArea();

                    break;

                case 4:
                    Trapezio trapezio = new Trapezio();

                    System.out.println("Informe a base maior do Trapezio");
                    trapezio.baseMaior = scan.nextDouble();
                    System.out.println("Informe a base menor do Trapezio");
                    trapezio.baseMenor = scan.nextDouble();
                    System.out.println("Informe altura Trapezio");
                    trapezio.altura = scan.nextDouble();

                    trapezio.calcularArea();

                    break;

                case 5:
                    System.exit(0);
                    break;
            }
        }while(op != 5);
    }
}