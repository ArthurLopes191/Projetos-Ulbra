#include <stdio.h>

int main(){
    float salario, conta1, conta2, juros1, juros2, restoSalario;

    printf("Informe o salario \n");
    scanf("%f%*c", &salario);

    printf("Informe o valor da primeira conta atrasada \n");
    scanf("%f%*c", &conta1);

    printf("Informe o valor da segunda conta atrasada \n");
    scanf("%f%*c", &conta2);
   
    juros1 = (conta1*2)/100;
    juros2 = (conta2*2)/100;
    restoSalario = salario - ((juros1 + conta1) + (juros2 + conta2));

    printf ("O que restou do salario eh %.2f", restoSalario);

    return 0;
}