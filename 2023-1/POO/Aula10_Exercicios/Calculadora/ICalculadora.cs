using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Crie uma interface ICalculadora com os métodos Somar(), Subtrair(), Multiplicar() e Dividir(). Em seguida, crie uma classe Calculadora que implementa a interface ICalculadora com sua própria implementação dos métodos. Em um programa, instancie a classe Calculadora e use cada um dos métodos para realizar operações matemáticas.

namespace Aula10_Exercicios.Calculadora
{
    public interface ICalculadora
    {
        public double Somar();
        public double Subtrair();
        public double Multiplicar();
        public double Dividir();
    }
}