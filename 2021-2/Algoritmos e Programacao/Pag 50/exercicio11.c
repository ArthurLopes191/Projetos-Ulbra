#include <stdio.h>

int main(){
    float area, diagonalMaior, diagonalMenor;

    printf("Digite a medida da diagonal maior \n");
    scanf("%f%c", &diagonalMaior);

    printf("Digite a medida da diagonal menor \n");
    scanf("%f%c", &diagonalMenor);

    area = (diagonalMaior * diagonalMenor)/2;

    printf("A area do losango eh %.2f \n", area);

    return 0;
}