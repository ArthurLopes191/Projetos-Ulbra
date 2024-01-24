import java.util.Scanner;

public class ex_slides_1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] temperatura = new int[8];
        int soma = 0, media;

        for(int i = 0; i <= temperatura.length -1 ; i++) {
            System.out.println("Informe a temperatura do dia: " + i+1);
            temperatura[i] = scan.nextInt();
            soma += temperatura[i];
        }

        media = soma/temperatura.length-1;

        for(int i = 0; i <= temperatura.length-1 ; i++) {
            if (temperatura[i] > media){
                System.out.println("A temperatura do dia " + i + " foi maior que a media");
            }
        }
        System.out.println();
    }
}
