/*Faça uma classe chamada Mes que possua um método chamado
getMesPorExtenso que recebe um número inteiro, referente ao mês do
ano, um código referente ao idioma (1 para português e 2 para inglês) e
retorne o mês por extenso. A tabela a seguir ilustra alguns exemplos. Faça
também outra classe para testar o método.*/

import java.util.Scanner;

public class Mes {

        public static void getMesPorExtenso() {
                Scanner scan = new Scanner(System.in);
                int op;
                int mes;

                do{
                        System.out.println("Digite o numero do mes de 1 a 12 que deseja ver:");
                        mes = scan.nextInt();
                }while(mes < 1 || mes > 12);

                do{
                        System.out.println("Digite a opcao 1 para portugues ou opcao 2 para ingles:");
                        op = scan.nextInt();
                }while(op < 1 || op > 2);

                switch (op){
                        case 1:
                             if(mes == 1){
                                     System.out.println("Janeiro");
                             }else if(mes == 2){
                                     System.out.println("Fevereiro");
                             }else if(mes == 3){
                                     System.out.println("Marco");
                             }else if(mes == 4){
                                     System.out.println("Abril");
                             }else if(mes == 5){
                                     System.out.println("Maio");
                             }else if(mes == 6){
                                     System.out.println("Junho");
                             }else if(mes == 7){
                                     System.out.println("Julho");
                             }else if(mes == 8){
                                     System.out.println("Agosto");
                             }else if(mes == 9){
                                     System.out.println("Setembro");
                             }else if(mes == 10){
                                     System.out.println("Outubro");
                             }else if(mes == 11){
                                     System.out.println("Novembro");
                             }else if(mes == 12){
                                     System.out.println("Dezembro");
                             }
                        break;

                        case 2:
                                if(mes == 1){
                                        System.out.println("January");
                                }else if(mes == 2){
                                        System.out.println("February");
                                }else if(mes == 3){
                                        System.out.println("March");
                                }else if(mes == 4){
                                        System.out.println("April");
                                }else if(mes == 5){
                                        System.out.println("May");
                                }else if(mes == 6){
                                        System.out.println("June");
                                }else if(mes == 7){
                                        System.out.println("July");
                                }else if(mes == 8){
                                        System.out.println("August");
                                }else if(mes == 9){
                                        System.out.println("September");
                                }else if(mes == 10){
                                        System.out.println("October");
                                }else if(mes == 11){
                                        System.out.println("November");
                                }else if(mes == 12){
                                        System.out.println("December");
                                }
                        break;
                }
        }
}
