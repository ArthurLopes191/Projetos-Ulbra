using TDE_ImpressoraCodBarras;

List<IImpressoraDeCodigoDeBarras> listaImpressoras = new List<IImpressoraDeCodigoDeBarras>();

Elgin Elgin = new Elgin();
Zebra Zebra = new Zebra();

listaImpressoras.Add(Elgin);
listaImpressoras.Add(Zebra);

Console.Write("Digite o código de barras do produto para ser impresso: ");
string cod = Console.ReadLine();
Console.Write("Digite o preco do produto para ser impresso: ");
double preco = Convert.ToDouble(Console.ReadLine());
Produto produto = new Produto(cod, preco);

foreach(IImpressoraDeCodigoDeBarras i in listaImpressoras)
{
    Console.WriteLine(i.ImprimirEtiqueta(produto));
}





