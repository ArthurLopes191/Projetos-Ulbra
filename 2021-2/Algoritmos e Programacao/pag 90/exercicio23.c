#include <stdio.h>

int main(){
    float precoUni, precoNF, desconto, precoNFcomDesconto;
    int codProduto, qtd;

    printf("Digite o codigo do produto \n");
    scanf("%d%*c", &codProduto);
    printf("Quantidade comprada \n");
    scanf("%d%*c", &qtd);

    if((codProduto >= 1)&&(codProduto <=10)){
        precoNF = qtd * 10;
        precoUni=10;
    }
    else if((codProduto >= 11)&&(codProduto <=20)){
        precoNF = qtd * 15;
        precoUni=15;
    }
    else if((codProduto >= 21)&&(codProduto <=30)){
        precoNF = qtd * 20;
        precoUni=20;
    }
    else if((codProduto >= 31)&&(codProduto <=40)){
        precoNF = qtd * 30;
        precoUni=30;
    }
    else{
        printf("Produto nao existe. \n");
        return 0;
    }

    if (precoNF < 250){
        precoNFcomDesconto = precoNF * 0.05;
        desconto = precoNF - precoNFcomDesconto;
    }

    else if((precoNF>=250)&&(precoNF<=500)){
        precoNFcomDesconto = precoNF * 0.10;
        desconto = precoNF - precoNFcomDesconto;
    }

    else{
        precoNFcomDesconto = precoNF * 0.15;
        desconto = precoNF - precoNFcomDesconto;
    }

    printf("Valor do produto eh: %.2f\n", precoUni);
    printf("Valor da nota fiscal eh: %.2f\n", precoNF);
    printf("O valor da nota fiscal com desconto eh: %.2f\n", precoNFcomDesconto);
    printf("O valor do desconto eh: %f\n", desconto);

    return 0;
}