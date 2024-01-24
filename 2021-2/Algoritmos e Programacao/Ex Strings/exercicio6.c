#include <stdio.h>
#include <string.h>

int main(){

    char string[30];
    char novaString[30];

    puts("Digite uma string");
    gets(string);

    strcpy(string,strlwr(string));

    for(int i=0;string[i]!='\0';i+=2){
       strcat(novaString,strupr(string[i]));
    }
    printf("%s",novaString);
    
    return 0;
}