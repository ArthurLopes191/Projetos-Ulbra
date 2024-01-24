#include <stdio.h>

int main(){
    int i, ano_atual;
    float salario, novo_salario, percentual;

    printf("Digite o ano atual \n");
    scanf("%d%*c", &ano_atual);
    salario=1000;
    percentual=1.5/100;
    novo_salario=salario+(percentual*salario);
    printf("Salario em 2006 %.3f \n", novo_salario);
    
    for(i=2007;i<=ano_atual;i++){
        percentual=percentual*2;
        novo_salario=novo_salario+(percentual*novo_salario);
        printf("Salario em %i %.3f aumento ->%.3f\n", i, novo_salario, percentual);
    }

    printf("Novo Salario %.3f\n", novo_salario);

    return 0;
}
