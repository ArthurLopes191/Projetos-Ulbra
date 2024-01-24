using Ap2;
using Ap2.Data.Context;
using Ap2.Data.Repositories;
using Ap2.Domain.Interfaces;

/*Enunciado 3 -  O programa deve ter classes para representar médicos, pacientes e 
consultas, com associações entre elas*/

class Program
{  
    static void Main(string[] args){
        {
        var db = new DataContext();
        IPacienteRepository _pacienteRepository = new PacienteRepository(db);

        IMedicoRepository _medicoRepository = new MedicoRepository(db);

        IConsultaRepository _consultaRepository = new ConsultaRepository(db);

        IEnderecoRepository _enderecoRepository = new EnderecoRepository(db);
        bool sair = false;

        while(!sair)
        {   
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar paciente");
            Console.WriteLine("2 - Cadastrar medico");
            Console.WriteLine("3 - Agendar consulta");
            Console.WriteLine("4 - Listar pacientes");
            Console.WriteLine("5 - Listar medicos");
            Console.WriteLine("6 - Listar consultas agendadas");
            Console.WriteLine("7 - Atualizar paciente");
            Console.WriteLine("8 - Atualizar medico");
            Console.WriteLine("9 - Atualizar consulta agendada");
            Console.WriteLine("10 - Remover paciente");
            Console.WriteLine("11 - Remover medico");
            Console.WriteLine("12 - Remover consulta agendada");
            Console.WriteLine("0 - Sair");
            
            int op = int.Parse(Console.ReadLine());
            
            switch (op)
            {
                case 1:
                    Console.WriteLine("Inserir novo paciente *****************************************************************");

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Cpf: ");
                    string cpf = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Sexo: ");
                    string sexo = Console.ReadLine();

                    Console.WriteLine("Endereco *****************************************************************");

                    Console.Write("Logradouro: ");
                    string logradouro = Console.ReadLine();

                    Console.Write("Numero: ");
                    string numero = Console.ReadLine();

                    Console.Write("Bairro: ");
                    string bairro = Console.ReadLine();

                    Console.Write("Cidade: ");
                    string cidade = Console.ReadLine();

                    Console.Write("Cep: ");
                    string cep = Console.ReadLine();

                    var endereco = new Endereco {Logradouro = logradouro, Numero = numero, Bairro = bairro, Cidade = cidade, Cep = cep};
                    _enderecoRepository.Save(endereco);

                    var paciente = new Paciente{Nome = nome, Cpf = cpf,Telefone = telefone, Sexo = sexo, Endereco = endereco};
                    _pacienteRepository.Save(paciente);
                   
                    break;

                case 2:
                    Console.WriteLine("Inserir novo medico *****************************************************************");
                    
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();

                    Console.Write("Cpf: ");
                    cpf = Console.ReadLine();

                    Console.Write("Telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine();

                    Console.Write("Crm: ");
                    int crm = int.Parse(Console.ReadLine());

                    Console.Write("Especialidade: ");
                    string especialidade = Console.ReadLine();

                    Console.WriteLine("Endereco *****************************************************************");

                    Console.Write("Logradouro: ");
                    logradouro = Console.ReadLine();

                    Console.Write("Numero: ");
                    numero = Console.ReadLine();

                    Console.Write("Bairro: ");
                    bairro = Console.ReadLine();

                    Console.Write("Cidade: ");
                    cidade = Console.ReadLine();

                    Console.Write("Cep: ");
                    cep = Console.ReadLine();

                    endereco = new Endereco {Logradouro = logradouro, Numero = numero, Bairro = bairro, Cidade = cidade, Cep = cep};
                    _enderecoRepository.Save(endereco);

                    var  medico = new Medico{Nome = nome, Cpf = cpf, Telefone = telefone, Sexo = sexo, Crm = crm, Especialidade = especialidade, Endereco = endereco};

                    _medicoRepository.Save(medico);
                    break;
                
                    case 3:
                    Console.WriteLine("Agendar nova consulta *****************************************************************");

                    Console.Write("Id do Medico: ");
                    int id = int.Parse(Console.ReadLine());
                    medico = _medicoRepository.GetById(id);
                    //medico = _medicoRepository.AcharMedicoCrm(crm);

                    Console.Write("Id do Paciente: ");
                    id = int.Parse(Console.ReadLine());
                    paciente = _pacienteRepository.GetById(id);
                    
                    //Console.Write("Cpf do Paciente: ");
                    //cpf = Console.ReadLine();
                    //paciente = _pacienteRepository.AcharPacienteCpf(cpf);

                    // Recebe a entrada do usuário
                    Console.Write("Digite a data da consulta (DD/MM/AAAA): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    Console.Write("Digite a hora da consulta (HH:MM): ");
                    TimeSpan hora = TimeSpan.Parse(Console.ReadLine());

                    // Cria uma nova instância de DateTime com a data e hora fornecidas pelo usuário
                    DateTime dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hours, hora.Minutes, 0);

                    // Cria uma nova instância de Consulta com os valores fornecidos pelo usuário
                    var consulta = new Consulta{DataHora = dataHora, Medico = medico, Paciente = paciente};
                    _consultaRepository.Save(consulta);
                    break;

                case 4:
                    //Console.WriteLine("Id\tNome\tCpf\tTelefone\tSexo\tEndereco");
                    //_pacienteRepository.GetAll();

                    var pacientes = _pacienteRepository.GetAll();
                    foreach(var item in pacientes)
                    {
                        var end = item.Endereco == null ? "Sem cidade" : item.Endereco.Logradouro;
                        Console.WriteLine($"Id: {item.Id} | Nome: {item.Nome} | Cidade: {end}");
                    }
                   
                    break;

                case 5:
                    //Console.WriteLine("Id\tNome\tCpf\tTelefone\tSexo\tCrm\tEspecialidade\tEndereco");
                    //medicoRepository.MostrarMedicos();
                     var medicos = _medicoRepository.GetAll();
                    foreach(var item in medicos)
                    {
                        var end = item.Endereco == null ? "Sem cidade" : item.Endereco.Logradouro;
                        Console.WriteLine($"Id: {item.Id} | Nome: {item.Nome} | Cidade: {end}");
                    }
                    break;

                case 6:
                    //Console.WriteLine("Id\tData Hora\tMedico\tPaciente");
                    //consultaRepository.MostrarConsultas();

                     var consultas = _consultaRepository.GetAll();
                    foreach(var item in consultas)
                    {
                        
                        Console.WriteLine($"Id: {item.Id} | Data: {item.DataHora} | Medico: {item.Medico.Nome} | Paciente: {item.Paciente.Nome}");
                    }
                    break;

                case 7:
                    Console.WriteLine("Atualizar paciente *****************************************************************");
                    Console.Write("ID do paciente que deseja atualizar: ");
                    id = int.Parse(Console.ReadLine());

                    Console.Write("Novo telefone: ");
                    telefone = Console.ReadLine();

                    Console.WriteLine("Atualizar Endereco *****************************************************************");
                    Console.Write("Novo Logradouro: ");
                    logradouro = Console.ReadLine();

                    Console.Write("Novo Numero: ");
                    numero = Console.ReadLine();

                    Console.Write("Novo Bairro: ");
                    bairro = Console.ReadLine();

                    Console.Write("Nova Cidade: ");
                    cidade = Console.ReadLine();

                    Console.Write("Cep: ");
                    cep = Console.ReadLine();

                    endereco = new Endereco {Logradouro = logradouro, Numero = numero, Bairro = bairro, Cidade = cidade, Cep = cep};
                    paciente = _pacienteRepository.GetById(id);
                    paciente.Telefone = telefone;
                    paciente.Endereco = endereco;
                    _pacienteRepository.Update(paciente);
                    break;
                
                case 8:
                    Console.WriteLine("Atualizar medico *****************************************************************");
                    Console.Write("ID do medico que deseja atualizar: ");
                    id = int.Parse(Console.ReadLine());

                    Console.Write("Novo telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe a especialidade do medico: ");
                    especialidade = Console.ReadLine();
                    
                    Console.WriteLine("Atualizar Endereco *****************************************************************");
                    Console.Write("Novo Logradouro: ");
                    logradouro = Console.ReadLine();

                    Console.Write("Novo Numero: ");
                    numero = Console.ReadLine();

                    Console.Write("Novo Bairro: ");
                    bairro = Console.ReadLine();

                    Console.Write("Nova Cidade: ");
                    cidade = Console.ReadLine();

                    Console.Write("Cep: ");
                    cep = Console.ReadLine();

                    endereco = new Endereco {Logradouro = logradouro, Numero = numero, Bairro = bairro, Cidade = cidade, Cep = cep};
                    medico = _medicoRepository.GetById(id);
                    medico.Telefone = telefone;
                    medico.Endereco = endereco;
                    _medicoRepository.Update(medico);
                    break;
                  
                case 9:
                    Console.WriteLine("Atualizar consulta agendada *****************************************************************");
                    Console.Write("ID da consulta que deseja atualizar: ");
                    id = int.Parse(Console.ReadLine());
                    
                    Console.Write("Digite a nova data da consulta (DD/MM/AAAA): ");
                    data = DateTime.Parse(Console.ReadLine());
                    Console.Write("Digite o novo horario da consulta (HH:MM): ");
                    hora = TimeSpan.Parse(Console.ReadLine());

                    medico = null; // inicializa a variável medico como null
                    while (medico == null) // laço de repetição que executa enquanto o medico for nulo
                    {
                        Console.Write("Id do Medico: ");
                        id = int.Parse(Console.ReadLine());
                        medico = _medicoRepository.GetById(id);
                        if (medico == null) // se o medico for nulo, exibe uma mensagem de erro e solicita novamente o CRM
                        {
                            Console.WriteLine("Médico não encontrado. Por favor, tente novamente.");
                        }
                    }

                    paciente = null; 
                    while (paciente == null)
                    {
                        Console.Write("id do Paciente: ");
                        id = int.Parse(Console.ReadLine());
                        paciente = _pacienteRepository.GetById(id);
                        if (paciente == null)
                        {
                            Console.WriteLine("Paciente não encontrado. Por favor, tente novamente.");
                        }
                    }
                    
                    dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hours, hora.Minutes, 0);
                    consulta = _consultaRepository.GetById(id);
                    consulta.DataHora = dataHora;
                    consulta.Medico = medico;
                    consulta.Paciente = paciente;
                    _consultaRepository.Update(consulta);
                    break;
                
                case 10:
                    Console.WriteLine("Excluir paciente *****************************************************************");
                    Console.Write("ID do paciente: ");
                    id = int.Parse(Console.ReadLine());
                    paciente = _pacienteRepository.GetById(id);
                    _pacienteRepository.Delete(id);
                    break;
                
                case 11:
                    Console.WriteLine("Excluir medico *****************************************************************");
                    Console.Write("ID do medico: ");
                    id = int.Parse(Console.ReadLine());
                    medico = _medicoRepository.GetById(id);
                    _medicoRepository.Delete(id);
                    break;
                
                case 12:
                    Console.WriteLine("Excluir consulta agendada *****************************************************************");
                    Console.Write("ID da consulta: ");
                    id = int.Parse(Console.ReadLine());
                    consulta = _consultaRepository.GetById(id);
                    _consultaRepository.Delete(id);
                    break;
                case 0:
                    sair = true;
                    break;
 
                default:
                    Console.WriteLine("3 inválida");
                    break;
            }

            Console.WriteLine();
        }

        Environment.Exit(0);
    }
}
 
}