/*4. Leia um conjunto de valores inteiros em um vetor de 10 e em seguida os exiba-os na ordem inversa do que foram digitados.*/
#include <stdio.h>
#include <string.h>

int main(){
    int num[10];
    int qtdNum;
    int cont = 0;

    printf("Informe a quantidade de numeros que serao informados: \n");
    scanf("%d%*c", &qtdNum);

    for(int i=0; i < qtdNum; i++){
        cont ++;
        printf("Informe o numero [%d]: \n", cont);
        scanf("%d%*c", &num[i]);
    }

    printf("Valores na ordem inversa: \n");
    for(int i = qtdNum - 1; i >= 0; i--){
        printf("%d \n", num[i]);
    }

    return 0;
}