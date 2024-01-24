#include <stdio.h>

int main(){
    float valor, aumento, novoValor;

    printf("Informe o valor do produto\n");
    scanf("%f%*c", &valor);

    if (valor <= 50){
        aumento = (valor*5)/100;
        novoValor = aumento + valor;
        printf(" |   Valor do Produto | ------------ | Aumento de 5 por cento |\n");
        printf(" |       R$%.2f      | ------------ |          R$%.2f        |\n", valor, aumento);


        printf("\n |  Novo Preco  | ------------- | Classificacao  | \n");
        printf(" |    R$%.2f   | ------------- |     Barato     | \n", novoValor);
    }

    if ((valor > 50)&&(valor <= 100)){
        aumento = (valor*10)/100;
        novoValor = aumento + valor;
        printf(" |   Valor do Produto | ------------ | Aumento de 10 por cento |\n");
        printf(" |       R$%.2f      | ------------ |          R$%.2f         |\n", valor, aumento);


        printf("\n |  Novo Preco   | ------------- | Classificacao  | \n");
        printf(" |    R$%.2f    | ------------- |     Normal     | \n", novoValor);
    }

    if (valor > 100){
        aumento = (valor*15)/100;
        novoValor = aumento + valor;
        printf(" |   Valor do Produto | ------------ | Aumento de 15 por cento |\n");
        printf(" |       R$%.2f      | ------------ |          R$%.2f       |\n", valor, aumento);

        if ((novoValor > 80)&&(novoValor < 120)){
        printf("\n |  Novo Preco   | ------------- | Classificacao  | \n");
        printf(" |    R$%.2f    | ------------- |     Normal   | \n", novoValor);
        }

        if ((novoValor > 120)&&(novoValor < 200)){
            printf("\n |  Novo Preco   | ------------- | Classificacao  | \n");
            printf(" |    R$%.2f    | ------------- |     Caro     | \n", novoValor);
        }

        if (novoValor > 200){
            printf("\n |  Novo Preco   | ------------- | Classificacao  | \n");
            printf(" |    R$%.2f   | ------------- |    Muito Caro  | \n", novoValor);
        }

    }



    return 0;
}