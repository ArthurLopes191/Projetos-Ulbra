#include <stdio.h>

int main(){
    float celsius, fahrenheint;

    printf("Informe a temperatura em celsius \n");
    scanf("%f%*c", &celsius);

    fahrenheint = celsius*1.8 + 32;

    printf("A temperatura em fahrenheint eh  %.2f \n", fahrenheint);

    return 0;
}