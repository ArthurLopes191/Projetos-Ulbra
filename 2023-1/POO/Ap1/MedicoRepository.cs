using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class MedicoRepository
    {
        public static List<Medico> medicos = new List<Medico>();

        public void AdicionarMedico(Medico medico)
        {
            //ultimoId++;
            //medico.GetType().GetProperty("id").SetValue(medico, ultimoId, null); 
            medicos.Add(medico);
        }

        public int GetUltimoId()
        {
            int ultimoId = 0;
            foreach (var p in medicos) {
                if (p.Id > ultimoId) {
                ultimoId = p.Id;
            }
        }
            return ultimoId;
        }

        public Medico AcharMedico(int id){
            Medico medicoAchado = medicos.Find(p => p.Id == id);
            if(medicoAchado == null)
            {
                Console.WriteLine("\nMedico não encontrado!");
            }
            return medicoAchado;
        }

        public Medico AcharMedicoCrm(int crm){
            Medico medicoAchado = medicos.Find(p => p.Crm == crm);
            if(medicoAchado == null)
            {
                Console.WriteLine("\nMedico não encontrado!");
            }
            return medicoAchado;
        }

        public void MostrarMedicos(){
            if(medicos.Count == 0){
                Console.WriteLine("\nNão há nenhum medico cadastrado");
            }
            Console.WriteLine("MEDICOS:");
            foreach (var p in medicos)
            {
                Console.WriteLine($"Id: {p.Id} - Nome: {p.Nome} - Cpf: {p.Cpf} - Telefone {p.Telefone} - Sexo {p.Sexo} - CRM {p.Crm} - Especialidade {p.Especialidade} | (Endereco: {p.Endereco.Logradouro}, Nº {p.Endereco.Numero}, Bairro {p.Endereco.Bairro}, Cidade {p.Endereco.Cidade}, CEP {p.Endereco.Cep})|");
            }
        }

        public void AlterarMedico(int id, string telefone, string sexo, string especialidade, Endereco endereco){
            Medico medico = medicos.Find(p => p.Id == id); //verifica se o atributo Id no objeto p é igual ao valor da variavel id;
            if (medico != null)
            {
                medico.Telefone = telefone;
                medico.Sexo = sexo;
                medico.Especialidade = especialidade;
                medico.Endereco = endereco;
                Console.WriteLine("Medico atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Medico não encontrado");
            }
        }

        public void DeletarMedico(int id)
        {
            Medico MedicoAchado = medicos.Find(p => p.Id == id);
            if(MedicoAchado == null)
            {
                Console.WriteLine("\nMedico não encontrado!");
            }else{
                medicos.Remove(MedicoAchado);
                Console.WriteLine("\nMedico excluído com sucesso!");
            }
               
        }
    }
}