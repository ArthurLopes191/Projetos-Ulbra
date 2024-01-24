import java.util.Random;
public class VetorRandom {
    Random random = new Random();
    private int[] Numeros = new int[50];

    public void PreencherNumerosRandom(){
        for(int i = 1; i < Numeros.length; i++){
            Numeros[i]+= random.nextInt(100);
        }

        for(int i = 0; i < Numeros.length; i++){
            System.out.println(Numeros[i]);
        }

    }
}
