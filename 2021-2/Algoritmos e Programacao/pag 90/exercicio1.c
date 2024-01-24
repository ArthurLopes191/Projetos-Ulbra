#include <stdio.h>

int main(){
    float nota1, nota2, nota3, nota4, media, calcMedia;

    printf("Informe a primeira nota \n");
    scanf("%f%*c", &nota1);

    printf("Informe a segunda nota \n");
    scanf("%f%*c", &nota2);

    printf("Informa a terceira nota \n");
    scanf("%f%*c", &nota3);

    printf("Informa a quarta nota \n");
    scanf("%f%*c", &nota4);

    media = 7;
    calcMedia = (nota1 + nota2 + nota3 + nota4)/4;

    if (calcMedia >= media){
        printf("Parabens voce foi aprovado com nota %.2f \n", calcMedia);
    }

    else{
        printf("Infelizmente voce foi reprovado com nota %.2f \n", calcMedia);
    }

    return 0;
}