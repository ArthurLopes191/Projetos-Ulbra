using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pessoas
{
    public class PersonRepository
    {
        public static List<Person> pessoasMaster = new List<Person>();
        public void Adicionar(Person pessoa)
        {
            pessoasMaster.Add(pessoa);
        }

        public void Mostrar(){
            if(pessoasMaster.Count == 0){
                Console.WriteLine("\nNão há nenhuma Person cadastrada");
            }

            foreach (var p in pessoasMaster)
            {
                Console.WriteLine($"Nome: {p.Nome}  \nId: {p.Id}  \nTelefone: {p.Telefone}");
            }
        }

        public void Alterar(int id){
            Person personFound = pessoasMaster.Find(p => p.Id == id);
            if(personFound == null)
            {
                Console.WriteLine("\nPessoa não encontrada!");
            }else{
                Console.WriteLine($"Nome Atual: {personFound.Nome}\n Informe um novo nome: ");
                personFound.Nome = Console.ReadLine();

                Console.WriteLine($"Telefone Atual: {personFound.Telefone}\n Informe um novo telefone: ");
                personFound.Telefone = Console.ReadLine();

                Console.WriteLine("\nPerson atualizada com sucesso!");
            }
        }

        public void Deletar(int id)
        {
            Person personFound = pessoasMaster.Find(p => p.Id == id);
            if(personFound == null)
            {
                Console.WriteLine("\nPessoa não encontrada!");
            }else{
                pessoasMaster.Remove(personFound);
                Console.WriteLine("\nPessoa excluída com sucesso!");
            }
               
        }
            
        

        
    }
}