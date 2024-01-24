using Ap1;

/*Enunciado 3 -  O programa deve ter classes para representar médicos, pacientes e 
consultas, com associações entre elas*/

class Program
{  
    static void Main(string[] args)
    {
        PacienteRepository pacienteRepository = new PacienteRepository();
        MedicoRepository medicoRepository = new MedicoRepository();
        ConsultaRepository consultaRepository = new ConsultaRepository();
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
                    
                    int id = pacienteRepository.GetUltimoId() + 1; //para incrementar o id automaticamente 

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

                    Endereco endereco = new Endereco(logradouro, numero, bairro, cidade, cep);
                    Paciente paciente = new Paciente(id, nome, cpf, telefone, sexo, endereco);
                    pacienteRepository.AdicionarPaciente(paciente);
                    break;

                case 2:
                    Console.WriteLine("Inserir novo medico *****************************************************************");
                    
                    id = medicoRepository.GetUltimoId() + 1; //para incrementar o id automaticamente 

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

                    endereco = new Endereco(logradouro, numero, bairro, cidade, cep);
                    Medico medico = new Medico(id, nome, cpf, telefone, sexo, crm, especialidade, endereco);
                    medicoRepository.AdicionarMedico(medico);
                    break;
                
                    case 3:
                    Console.WriteLine("Agendar nova consulta *****************************************************************");
                    
                    id = consultaRepository.GetUltimoId() + 1; //para incrementar o id automaticamente 

                    Console.Write("Crm do Medico: ");
                    crm = int.Parse(Console.ReadLine());
                    medico = medicoRepository.AcharMedicoCrm(crm);

                    Console.Write("Cpf do Paciente: ");
                    cpf = Console.ReadLine();
                    paciente = pacienteRepository.AcharPacienteCpf(cpf);

                    // Recebe a entrada do usuário
                    Console.Write("Digite a data da consulta (DD/MM/AAAA): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    Console.Write("Digite a hora da consulta (HH:MM): ");
                    TimeSpan hora = TimeSpan.Parse(Console.ReadLine());

                    // Cria uma nova instância de DateTime com a data e hora fornecidas pelo usuário
                    DateTime dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hours, hora.Minutes, 0);

                    // Cria uma nova instância de Consulta com os valores fornecidos pelo usuário
                    Consulta consulta = new Consulta(id, dataHora, medico, paciente);
                    consultaRepository.AdicionarConsulta(consulta);
                    break;

                case 4:
                    //Console.WriteLine("Id\tNome\tCpf\tTelefone\tSexo\tEndereco");
                    pacienteRepository.MostrarPacientes();
                    break;

                case 5:
                    //Console.WriteLine("Id\tNome\tCpf\tTelefone\tSexo\tCrm\tEspecialidade\tEndereco");
                    medicoRepository.MostrarMedicos();
                    break;

                case 6:
                    //Console.WriteLine("Id\tData Hora\tMedico\tPaciente");
                    consultaRepository.MostrarConsultas();
                    break;

                case 7:
                    Console.WriteLine("Atualizar paciente *****************************************************************");
                    Console.Write("ID do paciente que deseja atualizar: ");
                    id = int.Parse(Console.ReadLine());

                    Console.Write("Novo telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe o sexo: ");
                    sexo = Console.ReadLine();
                    
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

                    endereco = new Endereco(logradouro, numero, bairro, cidade, cep);
                    pacienteRepository.AlterarPaciente(id, telefone, sexo, endereco);
                    break;

                case 8:
                    Console.WriteLine("Atualizar medico *****************************************************************");
                    Console.Write("ID do medico que deseja atualizar: ");
                    id = int.Parse(Console.ReadLine());

                    Console.Write("Novo telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe o sexo: ");
                    sexo = Console.ReadLine();

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

                    endereco = new Endereco(logradouro, numero, bairro, cidade, cep);
                    medicoRepository.AlterarMedico(id, telefone, sexo, especialidade, endereco);
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
                        Console.Write("Crm do Medico: ");
                        crm = int.Parse(Console.ReadLine());
                        medico = medicoRepository.AcharMedicoCrm(crm);
                        if (medico == null) // se o medico for nulo, exibe uma mensagem de erro e solicita novamente o CRM
                        {
                            Console.WriteLine("Médico não encontrado. Por favor, tente novamente.");
                        }
                    }

                    paciente = null; 
                    while (paciente == null)
                    {
                        Console.Write("Cpf do Paciente: ");
                        cpf = Console.ReadLine();
                        paciente = pacienteRepository.AcharPacienteCpf(cpf);
                        if (paciente == null)
                        {
                            Console.WriteLine("Paciente não encontrado. Por favor, tente novamente.");
                        }
                    }
                    
                    dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hours, hora.Minutes, 0);
                    consultaRepository.AlterarConsulta(id, dataHora, medico, paciente);
                    break;

                case 10:
                    Console.WriteLine("Excluir paciente *****************************************************************");
                    Console.Write("ID do paciente: ");
                    id = int.Parse(Console.ReadLine());
                    pacienteRepository.DeletarPaciente(id);
                    break;

                case 11:
                    Console.WriteLine("Excluir medico *****************************************************************");
                    Console.Write("ID do medico: ");
                    id = int.Parse(Console.ReadLine());
                    medicoRepository.DeletarMedico(id);
                    break;
                
                case 12:
                    Console.WriteLine("Excluir consulta agendada *****************************************************************");
                    Console.Write("ID da consulta: ");
                    id = int.Parse(Console.ReadLine());
                    consultaRepository.DeletarConsulta(id);
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