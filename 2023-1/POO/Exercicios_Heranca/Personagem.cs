/*Crie uma classe base chamada "Personagem" que tenha propriedades como "Nome", "Força", "Inteligência" e "Poderes". Em seguida, crie duas classes derivadas chamadas "Heroi" e "Vilao" que herdam da classe "Personagem" e implementam métodos para lutar. Além disso, crie duas classes adicionais chamadas "SuperHeroi" e "SuperVilao" que herdam de "Heroi" e "Vilao", respectivamente, e adicionam um novo método "SuperPoder()". Cada personagem deve ter valores diferentes para suas propriedades, como por exemplo "Homem de Ferro" com alta inteligência e "Thanos" com alta força. Os métodos de luta devem ser implementados de forma a levar em consideração as propriedades de cada personagem, e os métodos "SuperPoder()" devem ser implementados de forma a exibir a mensagem apropriada para cada personagem.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public abstract class Personagem
    {
        public String Nome { get; set; }
        public int Forca { get; set; }
        public int Inteligencia { get; set; }
        public String Poderes { get; set; }

        public Personagem(String nome, int forca, int inteligencia, String poderes)
        {
            this.Nome = nome;
            this.Forca = forca;
            this.Inteligencia = inteligencia;
            this.Poderes = poderes;
        }
    }
}