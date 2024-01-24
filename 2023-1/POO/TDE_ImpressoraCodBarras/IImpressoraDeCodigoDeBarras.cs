using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE_ImpressoraCodBarras
{
    public interface IImpressoraDeCodigoDeBarras
    {
       string ImprimirEtiqueta(Produto produto);
    }
}