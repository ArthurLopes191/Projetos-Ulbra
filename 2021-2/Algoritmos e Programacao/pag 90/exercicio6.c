#include <stdio.h>
#include <math.h>

int main(){
    
    float n1, n2, escolha, elev, raizqN1, raizqN2, raizcN1, raizcN2;
    
    printf("Digite o primeiro numero \n");
    scanf("%f%*c", &n1);

    printf("Digite o segundo numero \n");
    scanf("%f%*c", &n2);

    printf("Digite 1 para primeiro numero elevado ao segundo. \n");
    printf("Digite 2 para a raiz quadrada de cada um dos numeros. \n");
    printf("Digite 3 para raiz cubica de cada um dos numeros. \n");
    scanf("%f%*c", &escolha);
    

    if(escolha==1){
        elev = pow(n1, n2);
        printf("O primeiro numero elevado ao segundo eh: %.2f \n", elev);
    } 

    else if(escolha==2){
       raizqN1 = sqrt(n1);
       raizqN2 = sqrt(n2);
       printf("A raiz quadrada do primeiro numero eh: %.2f \n", raizqN1);
       printf("A raiz quadrada do segundo numero eh: %.2f \n", raizqN2);
    } 

    else if(escolha==3){
        raizcN1 = cbrt(n1);
        raizcN2 = cbrt(n2);
        printf("A raiz cubica do primeiro numero eh: %.2f \n", raizcN1);
        printf("A raiz cubica do segundo numero eh: %.2f \n", raizcN2);
    } 
    
    else{
        printf("\nERRO!!! VALOR INVALIDO");
    }

    return 0;
}

