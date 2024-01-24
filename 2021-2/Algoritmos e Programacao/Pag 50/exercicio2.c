#include <stdio.h>

int main(){
    float n1, n2, n3, total;
    printf("Digite N1\n");
    scanf("%f%*c", &n1);
    printf("Digite N2\n");
    scanf("%f%*c", &n2);
    printf("Digite N3\n");
    scanf("%f%*c", &n3);
    total = n1*n2*n3;
    printf("O valor da multiplicacao eh %.2f\n", total);
    return 0;
}