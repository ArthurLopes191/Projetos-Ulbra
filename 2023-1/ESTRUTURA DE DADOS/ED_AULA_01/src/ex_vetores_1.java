/*Escreva um programa que crie um array de inteiros data e use um laço for para criar um novo String que exiba o conteúdo do array data entre chaves e separado por vírgulas. Por exemplo, se o array data tiver tamanho 4 e armazenar os valores 3, 4, 1, 5, o String “{3, 4, 1, 5}” deve ser criado e exibido.*/
public class ex_vetores_1 {
    public static void main(String[] args) {

         int[] data = {3,4,1,5};
         String string = "{";
         for(int i = 0; i < data.length; i++){
             string +=  + data[i] + ",";
         }
        string += "}";
        System.out.println(string);
    }
}
