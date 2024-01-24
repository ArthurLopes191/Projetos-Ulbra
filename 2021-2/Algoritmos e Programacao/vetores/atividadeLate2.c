/*2 - Escreva um programa que receba do usuário um vetor com 20 valores inteiros e apresente o maior, o menor e suas respectivas posições em que os mesmos foram informados. Caso existam números iguais mostre a posição da primeira ocorrência.*/
#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main(){
    int tam=5;
    int vetor[tam];
    int maior, pMaior;
    int menor, pMenor;

    for(int i = 0; i < tam; i++){
        printf("Digite o valor do vetor[%d] \n", i);
        scanf("%i%*c", &vetor[i]);
    }

    maior=vetor[0];
    menor=vetor[0];
	for (int j=0; j<tam; j++){
        if(maior<=vetor[j]){
            maior=vetor[j];
            pMaior=j;
        }

        if(menor>=vetor[j]){
            menor=vetor[j];
            pMenor=j;
        }
	}
     
    int pos;
    pos= -1;
    
    for(int i = 0; i < tam; i++){
        for(int j = i+1; j <tam; j++){
            if (vetor[i] == vetor[j]){
            printf("Valor dos numeros iguais: %d \n", vetor[i]);
            pos=i;
            break;
        }
    }
        if(pos != -1){
            break;
        }   
    }


    for(int i = 0; i < tam; i++){
        printf("\n Vetor[%d]:%d", i, vetor[i]);
    }

    printf("\nPosicao de num igual: %d \n", pos);
    printf("Maior elemento: %d \n", maior);
    printf("Posicao elemento: %d \n", pMaior);
    printf("Menor elemento: %d \n", menor);
    printf("Posicao elemento: %d \n", pMenor);



    return 0;
}