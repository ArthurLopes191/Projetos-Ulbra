#include <stdio.h>

int main(){
    float salario, aumento, reajuste;

    printf("Informe o valor do salario \n");
    scanf("%f%*c", &salario);

    if (salario <= 500){
        aumento = (salario*30)/100;
        reajuste = salario + aumento;
        printf("O salario com aumento de 30 por cento eh: R$%.2f \n", reajuste);
    }

    else{
        printf("Infelizmente voce nao tem direito a reajuste no salario. :( \n");
    }

    return 0;
}