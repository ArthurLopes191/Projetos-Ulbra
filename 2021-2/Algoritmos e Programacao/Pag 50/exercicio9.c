#include <stdio.h>

int main(){
    float area, baseMaior, baseMenor, altura;

    printf("Digite a medida da base maior \n");
    scanf("%f%c", &baseMaior);

    printf("Digite a medida da base menor \n");
    scanf("%f%c", &baseMenor);

    printf("Digite a medida da altura \n");
    scanf("%f%c", &altura);

    area = ((baseMaior + baseMenor) *altura/2);

    printf("A area do trapezio eh %.2f \n", area);

    return 0;
}