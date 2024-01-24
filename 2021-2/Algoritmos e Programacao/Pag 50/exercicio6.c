#include <stdio.h>

int main(){
    float salario, valorDasVendas, comissao, salarioFinal;
    
    printf("Digite o seu salario \n");
    scanf("%f%*c", &salario);
    printf("Digite as duas vendas\n");
    scanf("%f%*c", &valorDasVendas);
    comissao = valorDasVendas *0.04;
    salarioFinal = salario+comissao;

    printf("Seu salario eh %.2f\n", salario);
    printf("Sua comissao eh %.2f\n", comissao);
    printf("Seus proventos do mes sera %.2f \n", salarioFinal);

    return 0;
}