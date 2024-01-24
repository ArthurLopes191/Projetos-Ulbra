#include <stdio.h>

int main(){
    int numero , x1, x2, x3, x4, x5, x6, x7, x8, x9, x10 ;

    printf("Informe o numero da tabuada \n");
    scanf("%d%*c", &numero);

    x1 = numero* 1;
    x2 = numero * 2;
    x3 = numero * 3;
    x4 = numero * 4;
    x5 = numero * 5;
    x6 = numero * 6;
    x7 = numero * 7;
    x8 = numero * 8;
    x9 = numero * 9;
    x10 = numero *10;


    printf(" %dx1 = %d \n",numero, x1);
    printf(" %dx2 = %d \n",numero, x2);
    printf(" %dx3 = %d \n",numero, x3);
    printf(" %dx4 = %d \n",numero, x4);
    printf(" %dx5 = %d \n",numero, x5);
    printf(" %dx6 = %d \n",numero, x6);
    printf(" %dx7 = %d \n",numero, x7);
    printf(" %dx8 = %d \n",numero, x8);
    printf(" %dx9 = %d \n",numero, x9);
    printf(" %dx10 = %d\n",numero, x10);
  
    return 0;
}