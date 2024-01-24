using Crud_Pessoas_Cidades;

PersonRepository repository = new PersonRepository();
CityRepository cityRepository = new CityRepository();
int op;
int id = 0, idCid;

cityRepository.AdicionarCity();

do{
Console.WriteLine("\nDigite:\n1-Criar Pessoa\n2-Alterar Pessoa\n3-Deletar Pessoa\n4-Mostrar Pessoas\n5-Mostrar Cidades\n0-Sair");
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
        case 5:
            MostrarCity();
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
    string nome = Console.ReadLine(); 

    Console.WriteLine("Informe o telefone da pessoa: ");
    string telefone = Console.ReadLine(); 

    do{
    cityRepository.MostrarCity();

    Console.WriteLine("Digite o id da cidade da Pessoa: ");
    idCid = Convert.ToInt32(Console.ReadLine());
    }while(idCid < 1 || idCid > 5);

    City city = cityRepository.findCity(idCid);

    id++; 
    Person person = new Person(nome, id, telefone, city);

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

void MostrarCity()
{
    cityRepository.MostrarCity();
}