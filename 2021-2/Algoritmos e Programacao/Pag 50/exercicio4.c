#include <stdio.h>

int main(){
    float n1, n2, media;
    printf("Digite a nota 1\n");
    scanf ("%f%*c", &n1);
    printf("Digite a nota 2\n");
    scanf ("%f%*c", &n2);
    media = ((n1*2)+(n2*3))/5;
    printf("O valor da media eh %.2f \n", media);
    return 0;
}