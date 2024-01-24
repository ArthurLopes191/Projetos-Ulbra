#include <stdio.h>

int main(){
    
    float n1, n2, escolha, media, diferenca, produto, div;
    
    printf("Digite o primeiro numero \n");
    scanf("%f%*c", &n1);

    printf("Digite o segundo numero \n");
    scanf("%f%*c", &n2);

    printf("Digite 1 para media entre os numeros. \n");
    printf("Digite 2 para diferenca do maior pelo menor. \n");
    printf("Digite 3 para produto entre os numeros digitados. \n");
    printf("Digite 4 para divisao do primeiro numero pelo segundo. \n");
    scanf("%f%*c", &escolha);
    

    if(escolha==1){
        media = (n1 + n2)/2;
        printf("A media entre os numeros eh: %.2f \n", media);
    } 

    else if(escolha==2){
       diferenca = n1 - n2;
       printf("A diferenca dos numeros eh: %.2f", diferenca);
    } 

    else if(escolha==3){
        produto = n1*n2;
        printf("O produto dos numeros eh: %.2f \n", produto);
    } 
    
    else if(escolha==4){
        if(n2 == 0){
            printf("ERRO!!! O segundo numero deve ser diferente de 0. \n");
        }
        else{
        div = n1 / n2;
        printf("A divisao do primeiro numero pelo segundo eh: %.2f \n", div);
        }
    } 

    else{
        printf("\nERRO!!! VALOR INVALIDO");
    }

    return 0;
}

