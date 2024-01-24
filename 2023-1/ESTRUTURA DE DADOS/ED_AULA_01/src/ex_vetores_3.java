/*Crie uma classe que armazena os 12 meses do ano em um array. A seguir, gere um valor randômico entre 0 e 11 e apresente o mês correspondente ao valor sorteado. Considere que o valor 0 corresponde ao mês de janeiro e o valor 11, ao mês de dezembro.*/
public class ex_vetores_3 {
    public static void main(String[] args) {
        int[] anos = new int[12];
        int i  = (int) (Math.random() * anos.length);

        switch(i) {
        case 0:
            System.out.println("Janeiro");
        break;

        case 1:
            System.out.println("Fevereiro");
        break;

        case 2:
            System.out.println("Marco");
        break;

        case 3:
            System.out.println("Abril");
        break;

        case 4:
            System.out.println("Maio");
        break;

        case 5:
            System.out.println("Junho");
        break;

        case 6:
            System.out.println("Julho");
        break;

        case 7:
            System.out.println("Agosto");
        break;

        case 8:
            System.out.println("Setembro");
        break;

        case 9:
            System.out.println("Outubro");
        break;

        case 10:
            System.out.println("Novembro");
        break;

        case 11:
            System.out.println("Dezembro");
        break;

        }

    }
}
