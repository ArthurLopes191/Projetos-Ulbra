#include <stdio.h>

int main(){
    float nota1, nota2, nota3, soma, media;
    printf("Digite a primeira nota\n");
    scanf("%f%*c", &nota1);
    printf("Digite a segunda nota\n");
    scanf("%f%*c", &nota2);
    printf("Digite a terceira nota\n");
    scanf("%f%*c", &nota3);

    soma = nota1 + nota2 + nota3;
    media = soma/3;

    printf("A media das notas eh = %f\n", media);

    return 0;
}