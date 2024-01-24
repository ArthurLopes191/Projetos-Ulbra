using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class PacienteRepository
    {
        public static List<Paciente> pacientes = new List<Paciente>();

        public void AdicionarPaciente(Paciente paciente)
        {
            //ultimoId++;
            //paciente.GetType().GetProperty("id").SetValue(paciente, ultimoId, null); 
            pacientes.Add(paciente);
        }

        public int GetUltimoId()
        {
            int ultimoId = 0;
            foreach (var p in pacientes) {
                if (p.Id > ultimoId) {
                ultimoId = p.Id;
            }
        }
            return ultimoId;
        }

        public Paciente AcharPaciente(int id){
            Paciente pacienteAchado = pacientes.Find(p => p.Id == id);
            if(pacienteAchado == null)
            {
                Console.WriteLine("\nPaciente não encontrado!");
            }
            return pacienteAchado;
        }

        public Paciente AcharPacienteCpf(string cpf){
            Paciente pacienteAchado = pacientes.Find(p => p.Cpf == cpf);
            if(pacienteAchado == null)
            {
                Console.WriteLine("\nPaciente não encontrado!");
            }
            return pacienteAchado;
        }

        public void MostrarPacientes(){
            if(pacientes.Count == 0){
                Console.WriteLine("\nNão há nenhum paciente cadastrado");
            }
            Console.WriteLine("PACIENTES:");
            foreach (var p in pacientes)
            {
                Console.WriteLine($"|Id: {p.Id} | Nome: {p.Nome} | CPF: {p.Cpf} | Telefone: {p.Telefone} | Sexo: {p.Sexo} | (Endereco: {p.Endereco.Logradouro}, Nº {p.Endereco.Numero}, Bairro {p.Endereco.Bairro}, Cidade {p.Endereco.Cidade}, CEP {p.Endereco.Cep})|");
            }
        }

        public void AlterarPaciente(int id, string telefone, string sexo, Endereco endereco){
            Paciente paciente = pacientes.Find(p => p.Id == id); //verifica se o atributo Id no objeto p é igual ao valor da variavel id;
            if (paciente != null)
            {   
                paciente.Telefone = telefone;
                paciente.Sexo = sexo;
                paciente.Endereco = endereco;
                Console.WriteLine("Paciente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado");
            }
        }

        public void DeletarPaciente(int id)
        {
            Paciente pacienteAchado = pacientes.Find(p => p.Id == id);
            if(pacienteAchado == null)
            {
                Console.WriteLine("\nPaciente não encontrado!");
            }else{
                pacientes.Remove(pacienteAchado);
                Console.WriteLine("\nPaciente excluído com sucesso!");
            }
               
        }
    }
}