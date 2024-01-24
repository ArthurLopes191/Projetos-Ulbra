#include <stdio.h>

int main(){
    
    float valor, escolha, aumento, valorCorrigido;

    printf("\n Digite a opcao de investimento desejada: \n");
    printf("\n| 1 | ----------- |       Poupanca       | \n");
    printf("| 2 | ----------- | Fundos de Renda Fixa | \n");
    scanf("%f%*c", &escolha);

    if (escolha == 1){
        printf("Digite o valor do investimento. \n");
        scanf("%f%*c", &valor);
        aumento = (valor*3)/100;
        valorCorrigido = valor + aumento;
        printf("O valor corrigido apos um mes de investimento eh: R$%.2f \n", valorCorrigido);
    }

    else if (escolha == 2){
        printf("Digite o valor do investimento. \n");
        scanf("%f%*c", &valor);
        aumento = (valor*4)/100;
        valorCorrigido = valor + aumento;
        printf("O valor corrigido apos um mes de investimento eh: R$%.2f \n", valorCorrigido);
    }

    else{
        printf("\nERRO!!! VALOR INVALIDO");
    }

    return 0;
}