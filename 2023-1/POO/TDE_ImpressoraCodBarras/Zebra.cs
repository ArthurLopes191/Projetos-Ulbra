using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE_ImpressoraCodBarras
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {
        public string ImprimirEtiqueta(Produto produto)
        {
            return $"Etiqueta com os dados do produto {produto.Id} | CÓDIGO DE BARRAS: {produto.Codbarras} | VALOR: R${produto.Preco} | Impresso no modelo Zebra em cores - Resolução de 600dpi. - Tamanho da etiqueta: 15cm x 7cm. - Tipo de etiqueta: Poliéster. ";
        }
    }
}