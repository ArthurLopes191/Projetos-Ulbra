#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main(){
    char nome01[50];
    char nome02[50];

    printf("Digite o valor de nome 01: \n");
    gets(nome01);
    printf("Digite o valor de nome 02: \n");
    gets(nome02);

    if(strcmpi(nome01,nome02)==0){
        printf("Valores iguais!: \n");
    }else{
        printf("Valores diferentes!: \n");
    }

    return 0;
}