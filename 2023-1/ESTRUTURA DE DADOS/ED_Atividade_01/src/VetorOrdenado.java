public class VetorOrdenado {
    private int[] Numeros = new int[50];

    public void PreencherNumerosOrdenados(){
        Numeros[0] = 101;
        for(int i = 1; i < Numeros.length; i++){
            Numeros[i]+= Numeros[0] + i;
        }

        for(int i = 0; i < Numeros.length; i++){
            System.out.println(Numeros[i]);
        }

    }
}
