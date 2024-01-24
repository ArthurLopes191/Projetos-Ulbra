#include <stdio.h>

int main(){
    float n1, n2, div;
    printf("Digite N1\n");
    scanf("%f%*c", &n1);
    printf("Digite N2\n");
    scanf("%f%*c", &n2);
    div = n1/n2;
    printf("O valor da divisao eh %.2f\n", div);
    return 0;
}