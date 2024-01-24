using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar
{
    public class Aluno : IPessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }
        
        public Aluno(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Falar()
        {
            return $"Aluno {Nome}, {Idade} anos, falando";
        }
    }
}