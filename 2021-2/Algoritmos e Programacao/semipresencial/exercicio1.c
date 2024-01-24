#include <stdio.h>
#include <math.h>

int main(){
    
    float assinatura, chamada, interurbano, chamadaPcelular, contaTotal;

    printf ("Digite o valor de chamadas para celular \n");
    scanf("%f%*c", &chamada);

    
    assinatura = 17.90;
    interurbano = 34.29;
    chamadaPcelular = 0.20 * chamada;
    contaTotal = assinatura + interurbano + chamadaPcelular;

    printf("O valor total da conta eh: R$%.2f \n", contaTotal);


    return 0;
}