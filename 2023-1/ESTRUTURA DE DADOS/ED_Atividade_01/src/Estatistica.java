import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Estatistica {
    private int[][] matriz;

    public Estatistica(int[][] matriz) {
        this.matriz = matriz;
    }

    public void mostrarEstatisticas() {
        int[] array = toArray();
        System.out.println("Moda: " + moda(array));
        System.out.println("Mediana: " + mediana(array));
        System.out.println("Media: " + media(array));
    }

    private int[] toArray() {
        int[] array = new int[25];
        int k = 0;
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                array[k++] = matriz[i][j];
            }
        }
        return array;
    }

    private int moda(int[] array) {
        Map<Integer, Integer> frequencias = new HashMap<>();
        for (int i = 0; i < array.length; i++) {
            int elemento = array[i];
            if (frequencias.containsKey(elemento)) {
                int freq = frequencias.get(elemento);
                frequencias.put(elemento, freq + 1);
            } else {
                frequencias.put(elemento, 1);
            }
        }
        int moda = 0;
        int maxFreq = 0;
        for (Map.Entry<Integer, Integer> entry : frequencias.entrySet()) {
            int elemento = entry.getKey();
            int freq = entry.getValue();
            if (freq > maxFreq) {
                moda = elemento;
                maxFreq = freq;
            }
        }
        return moda;
    }

    private double mediana(int[] array) {
        Arrays.sort(array);
        int n = array.length;
        if (n % 2 == 0) {
            return (array[n / 2 - 1] + array[n / 2]) / 2.0;
        } else {
            return array[n / 2];
        }
    }

    private double media(int[] array) {
        double soma = 0;
        for (int i = 0; i < array.length; i++) {
            soma += array[i];
        }
        return soma / array.length;
    }
}