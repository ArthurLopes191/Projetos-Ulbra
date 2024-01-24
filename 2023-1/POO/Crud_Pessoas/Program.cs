using Crud_Pessoas;

PersonRepository repository = new PersonRepository();
int op;
int id = 0;

do{
Console.WriteLine("\nDigite:\n1-Criar Person\n2-Alterar\n3-Deletar\n4-mostrar\n0-Sair");
op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            Criar();
            break;
        case 2:
            Alterar();
            break;
        case 3:
            Deletar();
        break;
        case 4:
            Mostrar();
        break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Selecione uma das opções.");
            break;
    }
}while(op != 0);

void Criar()
{
    
    Console.WriteLine("\nInforme o nome da pessoa: ");
    string? nome = Console.ReadLine(); 

    Console.WriteLine("Informe o telefone da pessoa: ");
    string? telefone = Console.ReadLine(); 
    id++; 
    Person person = new Person(nome, id, telefone);
    repository.Adicionar(person);

    Console.WriteLine("\nPessoa cadastrada!");

}

void Alterar(){
    Console.WriteLine("\nInforme o Id para ser alterado: ");
    int idAlterar = Convert.ToInt32(Console.ReadLine());
    repository.Alterar(idAlterar);
}

void Deletar(){
    Console.WriteLine("\nInforme o Id para ser deletado: ");
    int idDelete = Convert.ToInt32(Console.ReadLine());
    repository.Deletar(idDelete);
}

void Mostrar()
{
    repository.Mostrar();
}
