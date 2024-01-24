#include <stdio.h>
#include <string.h>

int main(){
   /*
    char nome[11];
    char sobre[11];
    char outro[11];
    char nomecompleto[22];

    printf("Digite seu nome: \n");
    scanf("%s%*c", nome);

    printf("Digite seu sobrenome: \n");
    gets(sobre);
    //fflush(stdin);

    //puts(sobre);

    strcat(nomecompleto, nome);
    puts(nomecompleto);
    strcat(nomecompleto, " ");
    strcat(nomecompleto, sobre);
    puts(nomecompleto);

    // strcat concatena

    strcmp(nome, "arthur"); //0 >0 <0

    strcpy(outro, nome);
    puts(outro);

    printf("Nome digitado foi: %s %s \n", nome, sobre);
    */

   char nome[7] = "arthur";

   

   strupr(nome);
   puts(nome);
   strlwr(nome);
   puts(nome);
    

    return 0;
}