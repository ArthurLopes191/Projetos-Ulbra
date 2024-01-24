#include <stdio.h>

int main(){

    int idade, grupoRisco;
    float peso;

    printf("Digite sua idade: \n");
    scanf("%d%*c", &idade);

    printf("Digite seu peso: \n");
    scanf("%f%*c", &peso);

    if (idade < 20){
        if (peso <= 60){
        printf("O grupo de risco eh: 9 \n");
        }
        if ((peso > 60)&&(peso <= 90)){
        printf("O grupo de risco eh: 8 \n");
        }
        if (peso >90){
        printf("O grupo de risco eh: 7 \n");
        }
    }

    else if ((idade >= 20)&&(idade <= 50)){
        if (peso <= 60){
        printf("O grupo de risco eh: 6 \n");
        }
        if ((peso > 60)&&(peso <= 90)){
        printf("O grupo de risco eh: 5 \n");
        }
        if (peso >90){
        printf("O grupo de risco eh: 4 \n");
        }
    }

    else if (idade > 50){
        if (peso <= 60){
        printf("O grupo de risco eh: 3 \n");
        }
        if ((peso > 60)&&(peso <= 90)){
        printf("O grupo de risco eh: 2 \n");
        }
        if (peso >90){
        printf("O grupo de risco eh: 1 \n");
        }
    }


    return 0;
}