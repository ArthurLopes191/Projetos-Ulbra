#include <stdio.h>

int main ( )

{

float nota1, nota2, nota3, mediaP;

float peso1, peso2, peso3, somaP;

printf("Digite a primeira nota\n");

scanf("%f", &nota1);

printf("Digite o peso da primeira nota\n");

scanf("%f", &peso1);

printf("Digite a segunda nota\n");

scanf("%f", &nota2);

printf("Digite o peso da segunda nota\n");

scanf("%f", &peso2);

printf("Digite a terceira nota\n");

scanf("%f", &nota3);

printf("Digite o peso da primeira nota\n");

scanf("%f", &peso3);

somaP =(peso1+peso2+peso3);

mediaP=((nota1*peso1)+(nota2*peso2)+(nota3*peso3))/somaP;

printf("Media ponderada: %.2f", mediaP);

}