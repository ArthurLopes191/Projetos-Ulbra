using Aula02_00_basic;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//instanciar um objeto

Garrafa garrafaDoCassio = new Garrafa(1234, "cinza", 2000, "garrafa top");

Console.WriteLine(garrafaDoCassio.AnoFabricacao + " " + garrafaDoCassio.Cor);

garrafaDoCassio.Cor = "azul";

Garrafa garrafaDoFelipe = new Garrafa(5555, "azul", 2021, "teste do felipe");

Console.WriteLine(garrafaDoFelipe.AnoFabricacao);

Console.WriteLine("Digite algo: ");
var retorno = Console.ReadLine();
