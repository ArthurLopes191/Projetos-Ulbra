#include <stdio.h>

int main(){
    
    int n1, n2, n3;

    printf("Digite o primeiro numero \n");
    scanf("%d%*c", &n1);

    printf("Digite o segundo numero numero \n");
    scanf("%d%*c", &n2);

    printf("Digite o terceiro numero numero \n");
    scanf("%d%*c", &n3);

    if ((n1>n2)&&(n1>n3)){
    printf("O primeiro numero %d eh maior \n", n1);
    }

    if ((n2>n1)&&(n2>n3)){    
    printf("O segundo numero %d eh maior \n", n2);
    }

    if ((n3>n1)&&(n3>n2)){    
    printf("O terceiro numero %d eh maior \n", n3);
    }

    return 0;
}
