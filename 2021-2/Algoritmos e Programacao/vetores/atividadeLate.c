/*1 - Escreva um programa que leia dois vetores com 10 elementos cada e gere um terceiro vetor de 20 elementos, cujos valores deverão ser compostos pelos elementos intercalados dos dois vetores. Ao final o programa deverá mostrar dois vetores originais e o terceiro vetor com os valores intercalados.*/
#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main(){
    int vet1[10], vet2[10], vet3[20], i, j = 0;

    for(i = 0; i < 10; i++){
        printf("Informe os valores para o primeiro vetor\n");
        scanf("%i%*c", &vet1[i]);
    }

    for(i = 0; i < 10; i++){
        printf("Informe os valores para o segundo vetor \n");
        scanf("%i%*c", &vet2[i]);
    }

    for(int i = 0; i < 10; i++){
        vet3[j] = vet1[i];
        j++;
        vet3[j] = vet2[i];
        j++;
    }

    for(i = 0; i < 10; i++){
       printf("Valor do vetor1[%d]=%d \n", i, vet1[i]);
    }

    for(i = 0; i < 10; i++){
       printf("Valor do vetor2[%d]=%d \n", i, vet2[i]);
    }

    for(i = 0; i < 20; i++){
       printf("Valor do vetor3[%d]=%d \n", i, vet3[i]);
    }

    return 0;
}