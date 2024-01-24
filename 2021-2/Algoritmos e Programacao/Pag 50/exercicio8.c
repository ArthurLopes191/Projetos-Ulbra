#include <stdio.h>

int main(){
    float peso, pesoGramas;

    printf("Digite seu peso \n");
    scanf("%f%c", &peso);

    pesoGramas = peso*1000;
    
    printf("Seu peso em gramas eh %.2f\n", pesoGramas);

    return 0;
}