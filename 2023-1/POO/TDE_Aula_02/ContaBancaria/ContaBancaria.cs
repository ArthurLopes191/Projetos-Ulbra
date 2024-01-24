using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransacoesBancarias
{
    public class ContaBancaria
    {
        public double Saldo{get; private set;}
        public double Numero{get; private set;}

        public ContaBancaria(int numero, double saldoInicial){
            this.Numero = numero;
            this.Saldo = saldoInicial;
        }
        public void Depositar(double valor){
            Saldo += valor;
        }

        public void Sacar(double valor){
            if(valor > Saldo){
                Console.WriteLine("Saldo Insuficiente para saque!");
            }
            else{
                Saldo -= valor;
            }
        }
    }
}