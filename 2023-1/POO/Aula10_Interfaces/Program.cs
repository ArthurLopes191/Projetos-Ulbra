using Aula10_Interfaces;

var loja = new Loja();
var roupa = new Roupa();
loja.AdicionarItem(roupa);

var calcado = new Calcado();
loja.AdicionarItem(calcado);

var brinquedo = new Brinquedo();
loja.AdicionarItem(brinquedo);

IItemEstoque brinquedo2 = new Brinquedo();

