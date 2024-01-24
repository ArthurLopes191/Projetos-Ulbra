#include <stdio.h>

int main(){
    int idade;

    printf("Ola nadador! :) \n");
    printf("Digite sua idade: \n");
    scanf("%d%*c", &idade);

    if(idade < 5){
        printf("Voce eh muito novo para nadar :( \n");
    }

    
    else if((idade >= 5)&&(idade <=7)){
        printf("| Idade | ------------ | Categoria |\n");
        printf("|   %d   | ------------ | Infantil  |\n", idade);

    }

    else if((idade >= 8)&&(idade <=10)){
        printf("| Idade | ------------ | Categoria |\n");
        printf("|   %d   | ------------ |  Juvenil  |\n", idade);

    }

    else if((idade >= 11)&&(idade <=15)){
        printf("| Idade | ------------ |  Categoria  |\n");
        printf("|   %d  | ------------ | Adolescente |\n", idade);

    }
    else if((idade >= 16)&&(idade <=30)){
        printf("| Idade | ------------ | Categoria |\n");
        printf("|   %d  | ------------ |   Adulto  |\n", idade);

    }

    else if(idade > 30){
        printf("| Idade | ------------ | Categoria |\n");
        printf("|   %d  | ------------ |   Senior  |\n", idade);

    }
    

    return 0;
}