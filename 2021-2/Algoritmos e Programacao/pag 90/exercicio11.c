#include <stdio.h>

int main(){
    float salario, aumento, reajuste;

    printf("Informe o valor do salario\n");
    scanf("%f%*c", &salario);

    if (salario <= 300){
        aumento = (salario*15)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 15 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if ((salario > 300)&&(salario < 600)){
        aumento = (salario*10)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 10 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if ((salario > 600)&&(salario < 900)){
        aumento = (salario*5)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 5 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f        | \n", salario, reajuste);
    }

    if (salario > 900){
        printf(" | Salario | ------------ | Aumento de 0 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f        | \n", salario, salario);
    }


    return 0;
}