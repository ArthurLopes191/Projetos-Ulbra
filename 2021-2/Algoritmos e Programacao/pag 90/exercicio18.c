#include <stdio.h>

int main(){
    int idade;

    printf("Digite sua idade: \n");
    scanf("%d%*c", &idade);

    if (idade < 18){
        printf("VOCE EH MENOR DE IDADE. \n");
    }
 
    if (idade >= 18){
        printf("VOCE EH MAIOR DE IDADE. \n");
    }
    
    return 0;
}