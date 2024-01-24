using OperacoesMatematicas;
class Program{
    static void Main(string[] args){
        int op = 0;

        do{
            Console.WriteLine("Digite 1 para Somar: ");
            Console.WriteLine("Digite 2 para Subtrair: ");
            op = Convert.ToInt32(Console.ReadLine());
        }while(op < 1 || op > 2);

        switch(op){
            case 1:
                var somar = new Calculadora();
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                var resultSoma = somar.Somar(num1, num2);

                Console.WriteLine("A soma entre " + num1 + " e " + num2 + " é: " + resultSoma);
            break;

            case 2:
                var subtrair = new Calculadora();
                Console.WriteLine("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                var resultSubtracao = subtrair.Subtrair(num1, num2);

                Console.WriteLine("A subtração entre " + num1 + " e " + num2 + " é: " + resultSubtracao);
            break;
        }
    }
}
