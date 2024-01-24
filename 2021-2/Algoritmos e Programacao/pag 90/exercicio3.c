#include <stdio.h>

int main(){
    
    int n1, n2;

    printf("Digite o primeiro numero \n");
    scanf("%d%*c", &n1);

    printf("Digite o segundo numero numero \n");
    scanf("%d%*c", &n2);

    if (n1 < n2){
    printf("O primeiro numero %d eh menor \n", n1);
    }

    if (n2 < n1){    
    printf("O segundo numero %d eh menor \n", n2);
    }

    return 0;
}
