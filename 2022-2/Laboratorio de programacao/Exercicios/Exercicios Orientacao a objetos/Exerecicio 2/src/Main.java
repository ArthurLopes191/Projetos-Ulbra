import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Fracao f1 = new Fracao();

        System.out.println("Informe o numerador da primeira fracao: ");
        int num = scan.nextInt();
        System.out.println("Informe o denominador da primeira fracao: ");
        int den = scan.nextInt();

        f1.fracao(num, den);

        System.out.println("Informe o numerador da segunda fracao: ");
        int x = scan.nextInt();
        System.out.println("Informe o denominador da segunda fracao: ");
        int y = scan.nextInt();

        f1.multiplicacao( x, y );

    }
}