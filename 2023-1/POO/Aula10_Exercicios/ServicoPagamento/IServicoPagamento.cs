using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Crie uma interface IServicoPagamento com os métodos EfetuarPagamento() e EstornarPagamento(). Em seguida, crie as classes PagamentoCartao, PagamentoBoleto e PagamentoPaypal que implementam a interface IServicoPagamento com suas próprias implementações dos métodos. Em um programa, instancie as três classes e use cada uma para efetuar e estornar pagamentos diferentes.

namespace Aula10_Exercicios.ServicoPagamento
{
    public interface IServicoPagamento
    {
        public void EfetuarPagamento();

        public void EstornarPagamento();
    }
}