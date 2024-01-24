#include <stdio.h>

int main(){
    int codigo, valor;

    printf("Digite o codigo de origem do produto: \n");
    scanf("%d%*c", &codigo);

    printf("Digite o valor do produto: \n");
    scanf("%d%*c", &valor);

    if (codigo ==1){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Sul | \n", valor);
    }

    else if (codigo ==2){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Norte | \n", valor);
    }

    else if (codigo ==3){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Leste | \n", valor);
    }

    else if (codigo ==4){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Oeste | \n", valor);
    }

    else if ((codigo >= 5)&&( codigo <=6)){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Nordeste | \n", valor);
    }

    else if ((codigo >= 7)&&( codigo <=9)){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Sudeste | \n", valor);
    }

    else if ((codigo >= 10)&&( codigo <=20)){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Centro-Oeste | \n", valor);
    }

    else if ((codigo >= 21)&&( codigo <=30)){
        printf("|  Preco do produto: R$%d | ----------- | Procedencia: Nordeste | \n", valor);
    }

    else{
        printf("ERRO!!! VALOR DO CODIGO INVALIDO \n");
    }

    return 0;
}