/*FUP que calcula o comprimento da str (n usando strlen)*/
#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main(){

    char valor[50];
    int tamanho=0;

    printf("Escreva uma string \n");
    gets(valor);
    printf("Tamanho= %i \n", strlen(valor));


    for(int i=0; valor[i]!='\0';i++){
            tamanho++;
    }

    printf("Tamanho de forma manual= %i \n", tamanho);

    return 0;
}