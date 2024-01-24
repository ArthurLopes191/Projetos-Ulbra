using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Pagamento
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public IPagamento Pagamento { get; set; }

        public Cliente(int id, string nome, IPagamento pagamento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Pagamento = pagamento;
        }

        public string Comprar(double valor)
        {
            return Pagamento.Pagar(valor);
        }
    }
}