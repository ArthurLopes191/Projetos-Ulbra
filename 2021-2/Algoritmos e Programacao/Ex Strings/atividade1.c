 /*FUP que leia uma string e a escreva em letras maiúsculas e letras minúsculas.*/
 #include <stdio.h>

 int main(){

 char nome[30];

    printf("Digite uma palavra: \n");
    scanf("%s%*c", &nome);

    strupr(nome);
    puts(nome);
    strlwr(nome);
    puts(nome);
    

    return 0;
}