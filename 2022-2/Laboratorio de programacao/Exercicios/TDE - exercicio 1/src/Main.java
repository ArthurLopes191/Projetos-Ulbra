/*A gravidade da Lua é cerca de 17% a da Terra. Crie um programa que calcule seu
peso na Lua.*/
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main{
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        DecimalFormat formatador = new DecimalFormat("0.00");
        double Peso;
        double GravidadeTerra= 9.81;
        double GravidadeLua= 1.62;
        double PesoLua;

        System.out.println("Oi, qual é seu peso em kg?");
        Peso = scan.nextFloat();
        PesoLua = (Peso / GravidadeTerra) * GravidadeLua;

        System.out.println("Seu peso na Lua é:" + formatador.format(PesoLua));
    }
}

