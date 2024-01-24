using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class ExameRepository
    {
        public static List<Exame> consultas = new List<Exame>();

        public void AdicionarConsulta(Exame consulta)
        {
            // Verifica se o médico já possui uma consulta marcada no mesmo horário
            if (consultas.Exists(c => c.Medico == consulta.Medico && c.DataHora == consulta.DataHora))
            {
                throw new ArgumentException("Médico já possui uma consulta marcada para o mesmo horário.");
            }
            // Adiciona a consulta à lista de consultas
            //ultimoId++;
            //consulta.GetType().GetProperty("id").SetValue(consulta, ultimoId, null); 
            consultas.Add(consulta);
            Console.WriteLine("Consulta agendada com sucesso.");
        }

        public Consulta AcharConsulta(int id){
            Consulta consultaAchada = consultas.Find(p => p.Id == id); //expressao lambda
            if(consultaAchada == null)
            {
                Console.WriteLine("\nConsulta não encontrada!");
            }
            return consultaAchada;
        }

        public void MostrarConsultas(){
            if(consultas.Count == 0){
                Console.WriteLine("\nNão há nenhuma consulta cadastrada");
            }
            Console.WriteLine("CONSULTAS:");
            foreach (var p in consultas)
            {
                Console.WriteLine($"Id: {p.Id} - Data: {p.DataHora} - Medico: {p.Medico.Nome} - Paciente {p.Paciente.Nome} ");
            }
        }

        public void AlterarConsulta(int id, DateTime dataHora, Medico medico, Paciente paciente ){
            Consulta consulta = consultas.Find(c => c.Id == id); //verifica se o atributo Id no objeto p é igual ao valor da variavel id;
            if (consulta != null)
            {
                consulta.DataHora = dataHora;
                consulta.Medico = medico;
                consulta.Paciente = paciente;
                Console.WriteLine("Consulta atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Medico não encontrado");
            }
        }

        public int GetUltimoId()
        {
            int ultimoId = 0;
            foreach (var p in consultas) {
                if (p.Id > ultimoId) {
                ultimoId = p.Id;
            }
        }
            return ultimoId;
        }

        public void DeletarConsulta(int id)
        {
            Consulta ConsultaAchada = consultas.Find(p => p.Id == id);
            if(ConsultaAchada == null)
            {
                Console.WriteLine("\nConsulta não encontrada!");
            }else{
                consultas.Remove(ConsultaAchada);
                Console.WriteLine("\nConsulta excluída com sucesso!");
            }
               
        }
    }
}