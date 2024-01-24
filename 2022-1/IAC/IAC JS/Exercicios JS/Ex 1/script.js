/*Declarar uma variável, atribuir um valor numérico a ela. Mostrar o valor e o tipo. Teste todos os tipos vistos em sala de aula. */

var numero = 100;
imprimir(numero);

var texto = "texto";
imprimir(texto);

var logico = true;
imprimir(logico);

function imprimir(valor){
    console.log(`O valor da variavel é ${valor} e o tipo é ${typeof(valor)}`);
}

