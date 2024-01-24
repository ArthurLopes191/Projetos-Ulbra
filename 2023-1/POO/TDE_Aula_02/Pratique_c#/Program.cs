

using System.Globalization;
using Pratique_c_;

class Program{
    static void Main(string[] args){
        int op = 0;
        do{
            Console.WriteLine("Digite 1 para verificar se um número é impar ou par");
            Console.WriteLine("Digite 2 para verificar a media de 3 notas");
            Console.WriteLine("Digite 3 para informar um numero e verificar todos o numeros pares até ele");
            op = Convert.ToInt32(Console.ReadLine());
        }while(op > 3 || op < 1);

        switch (op){
            case 1:
                Console.WriteLine("Verificiar - IMPAR OU PAR");
                Console.WriteLine("Digite um número inteiro: ");
                int num = Convert.ToInt32(Console.ReadLine());
                var imparPar = new ImparPar();
                var result = imparPar.Verificar(num);
            break;

            case 2:
                Console.WriteLine("Verificar MEDIA DE 3 NOTAS");
                var mediaNotas = new MediaNotas();
                var media = mediaNotas.VerificarMedia();
                Console.WriteLine("A média das notas é: " + media.ToString("F1")); 
        
            break;

            case 3:
                Console.WriteLine("Verificar TODOS OS NÚMEROS PARES ATÉ O NÚMERO INFORMADO");
                Console.Write("Digite um número inteiro positivo: ");
                var num2 = Convert.ToInt32(Console.ReadLine());
                var numerosPares = new NumerosPares();
                numerosPares.VerificarPares(num2);
            break;
        }

        
    }
}