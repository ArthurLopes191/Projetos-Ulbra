#include <stdio.h>

int main(){
    float saldo, aumento, reajuste;

    printf("Informe o valor do saldo mensal\n");
    scanf("%f%*c", &saldo);

    if (saldo > 400){
        aumento = (saldo*30)/100;
        reajuste = saldo + aumento;
        printf(" | Saldo medio | ------------ | Aumento de 30 por cento | \n");
        printf(" |   R$%.2f  | ------------ |        R$%.2f         | \n", saldo, reajuste);
    }

    if ((saldo > 300)&&(saldo < 400)){
        aumento = (saldo*25)/100;
        reajuste = saldo + aumento;
        printf(" | Saldo medio | ------------ | Aumento de 25 por cento | \n");
        printf(" |   R$%.2f  | ------------ |        R$%.2f         | \n", saldo, reajuste);
    }

    if ((saldo > 200)&&(saldo < 300)){
        aumento = (saldo*20)/100;
        reajuste = saldo + aumento;
        printf(" | Saldo medio | ------------ | Aumento de 20 por cento | \n");
        printf(" |   R$%.2f  | ------------ |        R$%.2f         | \n", saldo, reajuste);
    }

    if (saldo < 200){
        aumento = (saldo*10)/100;
        reajuste = saldo + aumento;
        printf(" | Saldo medio | ------------ | Aumento de 10 por cento | \n");
        printf(" |   R$%.2f  | ------------ |        R$%.2f         | \n", saldo, reajuste);
    }


    return 0;
}