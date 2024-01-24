#include <stdio.h>

int main(){
    float area, lado;

    printf("Digite a medida do lado do quadrado \n");
    scanf("%f%c", &lado);

    area = lado * lado;

    printf("A area do quadrado eh %.2f \n", area);

    return 0;
}
