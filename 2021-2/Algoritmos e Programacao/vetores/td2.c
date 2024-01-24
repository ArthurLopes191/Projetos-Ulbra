#include <stdio.h>

int main(){
    int valores[6];
    int i = 0;
    
    for(i = 0; i < 6; i++){
        printf("Digite um numeros inteiros: \n");
        scanf("%d%*c", &valores[i]);
    }

    for(int j = 0; j < 6; j++ ){
        printf("%d \n", &valores[j]);
    }

    return 0;
}