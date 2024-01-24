#include <stdio.h>

int main(){
    float salario, aumento, reajuste;

    printf("Informe o valor do salario\n");
    scanf("%f%*c", &salario);

    if (salario <= 300){
        aumento = (salario*35)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 35 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if (salario > 300){
        aumento = (salario*15)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 15 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }


    return 0;
}