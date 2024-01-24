#include <stdio.h>

int main(){

    int senha;

    printf("Informe a senha: \n");
    scanf("%d%*c", &senha);

    if(senha == 4531){
        printf("Acesso permitido. :) \n");
    }
    
    else{
        printf("SENHA INCORRETA! PERMISSAO DE ACESSO NEGADA. \n");
    }

    return 0;
}