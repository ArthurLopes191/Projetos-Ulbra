
var n1 = 5;
var n2 = 7;
var n3 = 8.5;

var result =  (n1 + n2 + n3) /3;
console.log("a media é " + result);



//media da ulbra e ver se está aprovado

var ap1 = 1.5;
var ap2 = 2.0;
var as = 5;

function alunoAprovado(){
    let media = ap1 + ap2 + as;
    //if binário
    if(media >= 7)
        return "Aluno esta aprovado"
    else
    return "Reprovado";
}

function alunoAprovado2(){
    //if ternário
    // (condição) ? true : false
    return ((ap1 + ap2 + as) >=7) ? "aprovado" : "reprovado";
}

//Informe 3 números e mostre qual é o maior.

function numeroMaior(n1,n2,n3){
    if(n1 > n2 && n1 > n3)
        console.log(n1 + " é maior");
    else if(n2 > n1 && n2 > n3)
        console.log(n2 + " é maior");    
    else if(n3 > n1 && n3 > n2)
        console.log(n2 + " é maior");
    else
        console.log("algo de errado não está certo");
}

// imprimir a tabuada de um numero


function tabuada(numero){
for(let i = 0; i <= 10; i++){
    //console.log(numero + " * " + i + " = " + numero * i);
    console.log(`${numero} * ${i} = ${numero * i}`);
}
}

// arrays

var carros = ['gm', 'vw', 'fiat'];

console.log(carros);
console.log(carros[1]);

for (let i = 0; i < carros.length; i++){
    console.log("valor " + carros[i]);
}

var telefones = "519999999,518888888,51777777777,5166666666";
var arrFones = telefones.split(",")

console.log(telefones);
console.log(arrFones);


var octal = "776655";
var arrNumber = octal.split('');
console.log(octal);
console.log(arrNumber);

function binaryToDecimal(num){

}

function octalToDecimal(num){
    
}

function convertBaseToDecimal(algarismo, base){
    switch (base){
        case 2:
        
        break;

        case 8:
        
        break;

        case 2:
        
        break;
    }
}


//pegar o numero
// extrair cadas algarismo pra uma posicao pra dentro do array
//usar a função split('')
//percorrer o vetor ao contrário
//aplicar formula (a*base elevado a posicao) e cada resultado ir somando.


for (i=4;i >=array.length; i--){
    
}


if(arrNumber[i] == '1'){
    
}
posicao = Math.pow(2, i);