/*Crie a classe Fracao, que representa uma fração matemática. Esta classe deve ser capaz de armazenar o
numerador e o denominador da fração. Ela ainda deve ter métodos que recebem uma fração como parâmetro,
multiplicam ambas as frações, e retornam uma nova fração como resultado.
Crie um programa simples que instancia duas frações, define seus valores, calcula o valor da multiplicação entre
elas e mostra o resultado.
Dica: a multiplicação de 2 frações éfeita através da multiplicação dos numeradores e dos denominadores das
frações, e o valor resultante éuma terceira fração.*/


public class Fracao {
    public int numerador;
    public int denominador;

    public void fracao(int num, int den){
        numerador = num;
        denominador = den;
        System.out.println(num + "/" + den );
    }

    public void multiplicacao( int x, int y )
    {
        numerador = numerador * x;
        denominador = denominador * y;
        System.out.println("O resultado da multiplicacao das duas fracoes eh: " + numerador + "/" + denominador );
    }




}
