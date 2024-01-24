using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE_ImpressoraCodBarras
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        public string ImprimirEtiqueta(Produto produto)
        {
            return $"Etiqueta com os dados do produto {produto.Id} | CÓDIGO DE BARRAS:{produto.Codbarras} | VALOR: R${produto.Preco} | Impresso no modelo Elgin em preto e branco - Resolução de 300dpi - Tamanho da etiqueta: 10cm x 5cm - Tipo de etiqueta: Papel adesivo.";
        }
    }
}