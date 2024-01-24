#include <stdio.h>

int main(){
    float custoFabrica, distribuidor, imposto, custoFinal;

    printf("Informe o valor do custo de fabrica do carro\n");
    scanf("%f%*c", &custoFabrica);

    if (custoFabrica <= 12000){
        distribuidor = (custoFabrica*5)/100;
        custoFinal = custoFabrica + distribuidor + imposto;
        printf(" | Custo de fabrica | ------------ | porcentagem distribuidor| porcentagem impostos|   Custo Final   |\n");
        printf(" |   R$%.2f     | ------------ |        R$%.2f         |        ISENTO       |   R$%.2f     |\n", custoFabrica, distribuidor, custoFinal);
    }

    if ((custoFabrica > 12000)&&( custoFabrica < 25000)){
        distribuidor = (custoFabrica*10)/100;
        imposto = (custoFabrica*15)/100;
        custoFinal = custoFabrica + distribuidor + imposto;
        printf(" | Custo de fabrica | ------------ | porcentagem distribuidor| porcentagem impostos|   Custo Final   |\n");
        printf(" |   R$%.2f     | ------------ |        R$%.2f         |       R$%.2f       |    R$%.2f     |\n", custoFabrica, distribuidor, imposto, custoFinal);
    }

    if (custoFabrica > 25000){
        distribuidor = (custoFabrica*15)/100;
        imposto = (custoFabrica*20)/100;
        custoFinal = custoFabrica + distribuidor + imposto;
        printf(" | Custo de fabrica | ------------ | porcentagem distribuidor| porcentagem impostos|   Custo Final   |\n");
        printf(" |   R$%.2f     | ------------ |        R$%.2f         |       R$%.2f       |    R$%.2f     |\n", custoFabrica, distribuidor, imposto, custoFinal);
    }
    
    
    

    return 0;
}