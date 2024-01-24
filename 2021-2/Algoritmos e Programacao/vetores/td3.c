#include <stdio.h>
#include <math.h>

int main(){
    float conjunto[10];
    float conjunto2[10];

    for(int i = 0; i <= 10; i++){
        printf("Digite um valor para o nosso vetor: \n");
        scanf("%f", conjunto[i]);
        conjunto2[i] = conjunto[i] * conjunto[i];
    }

    for(int j = 0; j <= 10; j++){
        printf("Valor %f na posicao [%d] \n", conjunto2[j], j);
    }
    for(int j = 0; j <= 10; j++){
        printf("Valor %f na posicao [%d]\n", conjunto[j], j);
    }

}