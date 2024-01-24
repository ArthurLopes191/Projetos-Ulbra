using Aula10_Exercicios.Animais;
using Aula10_Exercicios.FormatadorTexto;

var cachorro = new Cachorro();
Console.WriteLine(cachorro.EmitirSom());

var gato = new Gato();
Console.WriteLine(gato.EmitirSom());

var papagaio = new Papagaio();
Console.WriteLine(papagaio.EmitirSom());


// ---------------------------------------

var formatadorinvertido = new FormatadorInvertido();

var formatadormaiusculo = new FormatadorMaiusculo();

var formatadorminusculo = new FormatadorMinusculo();

string p = "teste";

Console.WriteLine(formatadorinvertido.Formatar(p));
Console.WriteLine(formatadormaiusculo.Formatar(p));
Console.WriteLine(formatadorminusculo.Formatar(p));

// -----------------------------------------
