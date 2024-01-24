#include <stdio.h>

int main(){
    float valor, desconto, novoValor;

    printf("Digite o valor do produto: \n");
    scanf("%f%*c", &valor);

    if (valor <= 30){
        printf("Este produto nao tem desconto. :( \n");
    }

    if ((valor > 30)&&(valor<100)){
        desconto = (valor*10)/100;
        novoValor = valor - desconto;
        printf(" | Valor produto | ------------ | Desconto de 10 por cento | \n");
        printf(" |    R$%.2f    | ------------ |          R$%.2f         | \n", valor, novoValor);
    }

    if (valor>100){
        desconto = (valor*15)/100;
        novoValor = valor - desconto;
        printf(" | Valor produto | ------------ | Desconto de 15 por cento | \n");
        printf(" |    R$%.2f   | ------------ |          R$%.2f        | \n", valor, novoValor);
    }

    return 0;
}