/*FUP que leia o nome e o sobrenome de uma pessoa em duas variáveis distintas, o programa deve armazenar os dois valores uma terceira variável.*/

#include <stdio.h>
#include <string.h>

int main(){
    char nome[11];
    char sobre[11];
    char nomecompleto[22];

    printf("Digite seu primeiro nome: \n");
    scanf("%s%*c", &nome);

    printf("Digite seu sobrenome: \n");
    scanf("%s%*c", &sobre);

    strcpy(nomecompleto, nome);
    strcat(nomecompleto, " ");
    strcat(nomecompleto, sobre);

    printf("O nome completo eh: %s \n", nomecompleto);


    return 0;
}