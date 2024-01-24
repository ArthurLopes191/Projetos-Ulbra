using TransacoesBancarias;

class Program{
    static void Main(string[] args){
        int op = 0;
        ContaBancaria conta = new ContaBancaria(12, 2000);  
        
        while(op != 3){
        do{
        Console.WriteLine("Digite 1 para DEPOSITAR: ");
        Console.WriteLine("Digite 2 para SACAR: ");
        Console.WriteLine("Digite 3 para SAIR: ");
        op = Convert.ToInt32(Console.ReadLine());
        }while(op < 1 || op > 3);

        switch(op){
                case 1:
                    Console.WriteLine(" ");
                    Console.WriteLine("Conta numero: " + conta.Numero + " / Saldo ATUAL: " + conta.Saldo);
                    Console.Write("Digite a quatia a depositar: ");
                    conta.Depositar(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Conta numero: " + conta.Numero + " / Saldo ATUAL: " + conta.Saldo);
                    Console.WriteLine(" ");
                break;

                case 2:
                    Console.WriteLine(" ");
                    Console.WriteLine("Conta numero: " + conta.Numero + " / Saldo ATUAL: " + conta.Saldo);
                    Console.Write("Digite a quantia a sacar: ");
                    conta.Sacar(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Conta numero: " + conta.Numero + "/ Saldo ATUAL: " + conta.Saldo);
                    Console.WriteLine(" ");
                break;

                case 3:
                    Environment.Exit(0);
                break;
            }
        }    
    }
}