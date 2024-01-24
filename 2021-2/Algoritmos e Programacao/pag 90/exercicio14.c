#include <stdio.h>

int main(){
    float salario, aumento, reajuste;

    printf("Informe o valor do salario\n");
    scanf("%f%*c", &salario);

    if (salario <= 300){
        aumento = (salario*50)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 50 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if ((salario > 300)&&(salario < 500)){
        aumento = (salario*40)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 40 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if ((salario > 500)&&(salario < 700)){
        aumento = (salario*30)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 30 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if ((salario > 700)&&(salario < 800)){
        aumento = (salario*20)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 20 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if ((salario > 800)&&(salario < 1000)){
        aumento = (salario*10)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 10 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f         | \n", salario, reajuste);
    }

    if (salario > 1000){
        aumento = (salario*5)/100;
        reajuste = salario + aumento;
        printf(" | Salario | ------------ | Aumento de 5 por cento | \n");
        printf(" |R$%.2f | ------------ |        R$%.2f        | \n", salario, reajuste);
    }


    return 0;
}