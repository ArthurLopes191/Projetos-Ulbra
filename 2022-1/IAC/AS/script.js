/*Faça um algoritmo em JS imprima a equação e os resultados de uma potenciação. O usuário irá informar uma base e o número do expoente. Ex. base 2, expoente 2. Deverá imprimir. 2ˆ0=1 || 2ˆ1=2 || 2ˆ2=4. O resultado também pode ser com quebra de linha. Entregar o arquivo JS anexado neste atividade. (não postar no github) */


function potenciacao(base, expoente){
    
    var potencia = 0;
   
    for(var i = 0; i <= expoente; i++){
        
        potencia = base ** i;
        console.log(base,'*', i, '=', potencia);
        
    }

    return potencia;
}