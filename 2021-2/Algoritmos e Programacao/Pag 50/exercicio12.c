#include <stdio.h>

int main(){
    float salarioMin, salarioFunc, total;
    
    printf("Informe o salario minimo \n");
    scanf("%f%c", &salarioMin);

    printf("Informe o salario do funcionario \n");
    scanf("%f%c", &salarioFunc);

    total = salarioFunc/salarioMin;

    printf("Quantidade de salarios minimos eh %.2f \n", total);

    return 0;
}