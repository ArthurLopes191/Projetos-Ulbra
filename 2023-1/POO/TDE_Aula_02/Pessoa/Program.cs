using PessoasInfo;

class Program{
    static void Main(string[] args){
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Digite o nome da pessoa");
        pessoa.Nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa");
        pessoa.Idade = Convert.ToInt32(Console.ReadLine());

        pessoa.Apresentar();
    }
}