#include <stdio.h>
int main(){
    float preco, novoPreco;
    printf("Digite o valor do produto\n");
    scanf("%f%*c", &preco);
    novoPreco = preco*0.9;
    printf("O preco era R$ %.2f\n", preco);
    printf("Agora o preco eh R$  %.2f\n", novoPreco);
    return 0;
}