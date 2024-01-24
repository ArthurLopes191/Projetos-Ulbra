/*Faça um programa que calcula a que distância, em pés, um ouvinte está da queda de
um relâmpago. O som viaja a aproximadamente 1.100 pés por segundo pelo ar. Logo,
conhecer o intervalo entre o momento em que você viu um relâmpago e o momento em
que o som o alcançou lhe permitirá calcular a distância do relâmpago. Para este projeto,
considere que o intervalo seja de 7,2 segundos.*/

import java.text.DecimalFormat;

public class Main{
    public static void main(String[] args){
        DecimalFormat formatador = new DecimalFormat("0.00");
        double SomRelampago = 1.100;
        double IntervaloTempo = 7.2;
        double distancia;

        distancia = SomRelampago * IntervaloTempo;
        System.out.println("O som do trovao viaja a 1.100 pes por segundo e voce esta a 7,2 segundos. A distancia do relampago ate voce e de:" + formatador.format(distancia) + "pes");
    }
}