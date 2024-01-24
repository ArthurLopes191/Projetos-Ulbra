#include <stdio.h>
#include <string.h>

int main(){
    char nome01[50];
    int valores[5];
    int acumuladora=0;
    int vetor[5]={10,20,30,50,89};
    int vetor1[]={10,12,24};
    int busca;




    for(int i = 0; i < 5; i++){
        printf("Digite o valor da posição %i\n", i+1);
        scanf("%i%*c",&valores);
        acumuladora=acumuladora+valores[i];
    }

    for(int i = 0; i < 5; i++){
        printf("Valor na posição [%i]%i\n", i+1, valores[1]);
        
        printf("Valor acumulado")
    }
}