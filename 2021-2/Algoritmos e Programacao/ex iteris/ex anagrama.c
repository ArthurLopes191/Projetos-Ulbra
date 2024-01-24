#include <stdio.h>

int main(){
    int n, resultado, permuta;

    printf("Digite o número de letras que a palavra  possui: ");
    scanf("%d%*c", &n);

    if(n >1){
        permuta = (n-1) * n;
    }else{
        printf("1");
    }

    printf("O resultado eh: %d", permuta);

    return 0;
}