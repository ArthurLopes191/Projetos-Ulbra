#include <stdio.h>

int main(){
    float salarioBruto, gratificacao, imposto, custoFinal;

    printf("Informe o valor do salario\n");
    scanf("%f%*c", &salarioBruto);

    if (salarioBruto <= 350){
        gratificacao = 100;
        imposto = (salarioBruto*7)/100;
        custoFinal = salarioBruto - imposto + gratificacao;
        printf(" |   Salario  | ------------ | Gratificacao | Imposto de 7 por cento|   Custo Final   |\n");
        printf(" |  R$%.2f  | ------------ |    R$%.2f  |       R$%.2f         |    R$%.2f     |\n", salarioBruto, gratificacao, imposto, custoFinal);
    }

    if ((salarioBruto > 350)&&(salarioBruto < 600)){
        gratificacao = 75;
        imposto = (salarioBruto*7)/100;
        custoFinal = salarioBruto - imposto + gratificacao;
        printf(" |   Salario  | ------------ | Gratificacao | Imposto de 7 por cento|   Custo Final   |\n");
        printf(" |  R$%.2f  | ------------ |    R$%.2f   |       R$%.2f         |    R$%.2f     |\n", salarioBruto, gratificacao, imposto, custoFinal);
    }
    
    if ((salarioBruto > 600)&&(salarioBruto < 900)){
        gratificacao = 50;
        imposto = (salarioBruto*7)/100;
        custoFinal = salarioBruto - imposto + gratificacao;
        printf(" |   Salario  | ------------ | Gratificacao | Imposto de 7 por cento|   Custo Final   |\n");
        printf(" |  R$%.2f  | ------------ |    R$%.2f   |       R$%.2f         |    R$%.2f     |\n", salarioBruto, gratificacao, imposto, custoFinal);
    }

    if (salarioBruto > 900){
        gratificacao = 35;
        imposto = (salarioBruto*7)/100;
        custoFinal = salarioBruto - imposto + gratificacao;
        printf(" |   Salario  | ------------ | Gratificacao | Imposto de 7 por cento|   Custo Final   |\n");
        printf(" |  R$%.2f  | ------------ |    R$%.2f   |       R$%.2f         |    R$%.2f     |\n", salarioBruto, gratificacao, imposto, custoFinal);
    }
 

    return 0;
}