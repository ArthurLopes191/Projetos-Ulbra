/*Faça um programa que receba a quantidade de funcionários de uma empresa, e para cada funcionário leia  o salário do funcionário, calcule e mostre o novo salário, acrescido de bonificação e de auxílio escola.*/

#include<stdio.h>

int main(){
    int funcionarios;
    int i=0;
    float salario;
    int cont = 0;
    float bonus;

    printf("Digite a quantidade de funcionario: \n");
    scanf("%d%*c", &funcionarios);

    for(i; i < funcionarios; i++){
        cont++;
        printf("\nINFORME O SALARIO DO FUNCIONARIO [%d] \n", cont);
        scanf("%f%*c", &salario);
        
        if (salario <= 500){
            int auxEscola = 150;
            bonus = salario + auxEscola + (0.05 * salario);
            printf("O novo salario do funcionario [%d] com acrescimo de 5 porcento mais R$150 de auxilio escola eh: R$%.2f \n", cont, bonus);
        }
        else if ((salario > 500)&&(salario <= 1200)){
            if(salario <= 600){
                int auxEscola = 150;
                bonus = salario + auxEscola + (0.12 * salario);
                printf("O novo salario do funcionario [%d] com acrescimo de 12 porcento mais R$150,00 de auxilio escola eh: R$%2.f \n", cont, bonus);
            }
            else if(salario > 600){
                int auxEscola = 100;
                bonus = salario + auxEscola + (0.12 * salario);
                printf("O novo salario do funcionario [%d] com acrescimo de 12 porcento mais R$100,00 de auxilio escola eh: R$%2.f \n", cont, bonus);
            }
        }
        else if (salario > 1200){
            int auxEscola = 100;
            bonus = salario + auxEscola;
            printf("O salario do funcionario [%d] mais R$100,00 de auxilio escola eh: R$%.2f \n", cont, bonus);
        }
    }
    return 0;
}