
//Exercício 1 - Crie uma função javascript que execute a soma de 2 números e coloque o resultado no console utilizando o console.log().
const n1 = 3;
const n2 = 2;

const soma = n1 + n2;
console.log("A soma de " + n1 + " com " + n2 + " é: " + soma);


//Exercício 2 - Crie uma função javascript que receba uma lista inteiros como parâmetro e diga qual número é par e qual é ímpar.

const lista = [1, 3, 4, 5]

for(let i = 0; i < lista.length; i++){
    if(lista[i] %2 == 0 ){
        console.log("Numero " + lista[i] + " é PAR")
    }else{
        console.log("Numero "+ lista[i]+" é IMPAR")
    }
}