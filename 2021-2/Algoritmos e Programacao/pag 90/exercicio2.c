#include<stdio.h>

int main(){
    
    float n1, n2, media;

    printf("Digite a primeira nota \n");
    scanf("%f%*c", &n1);

    printf("Digite a segunda nota \n");
    scanf("%f%*c", &n2);

    media = (n1 + n2)/2;


    if ((media > 0)&&(media <= 3.0)){ 
    printf("|Nota|-------------|Media| Situacao  | \n");    
    printf("|%2.f  |-------------| 3.0 | Reprovado | \n", media);
    }

    else if ((media <= 7.0)&&(media >3.0)){
    printf("|Nota|-------------|Media| Situacao  | \n");    
    printf("|%2.f  |-------------| 7.0 | Exame     | \n", media);
    }

    else if ((media <= 10.0)&&(media > 7.0)){
    printf("|Nota|-------------|Media | Situacao  | \n");    
    printf("|%2.f  |-------------| 10.0 | Aprovado  | \n", media);    
    }

    else{
        printf("\nERRO!!! Nao foi possivel calcular sua nota");
    }

    return 0;
}