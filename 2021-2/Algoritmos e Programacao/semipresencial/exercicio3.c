#include <stdio.h>

int main(){
    float ex1, ex2, prova, notaEx, nota;

    printf("Digite a nota 1: \n");
    scanf("%f%*c", &ex1);

    printf("Digite a nota 2: \n");
    scanf("%f%*c", &ex2);

    printf("Digite a nota da prova final: \n");
    scanf("%f%*c", &prova);

    notaEx = ((ex1*1)+(ex2*2))/3;
    nota = ((notaEx*2)+(prova*8))/10;

    printf("Sua nota final eh: %.2f\n", nota);

    return 0;
}