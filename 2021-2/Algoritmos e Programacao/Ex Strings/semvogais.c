/*Faça um programa que receba do usuário uma string. O programa imprime a string sem as vogais.*/
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main ()
{
    int i, j;
    char string[100], vogais[] = "aeiouAEIOU";

    printf("Informe uma string: \n");
    gets(string);
    fflush(stdin);
    

    for (i = 0; i < strlen(string); i++){

        for (j = 0; j < strlen(vogais); j++)
            if (string[i] == vogais[j])
                break;

        if (j == strlen(vogais))
            printf("%c", string[i]);
    }

    return 0;
}