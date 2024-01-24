#include <stdio.h>

int main(){
    float peso, pesoEmagrecer, pesoEngordar; 

    printf("Digite seu peso \n");
    scanf("%f%*c", &peso);

    pesoEngordar = peso*1.15;
    pesoEmagrecer = peso*0.8;

    printf("Seu peso atual %.2f\n",peso);
    printf("Seu peso se engordar %.2f\n",pesoEngordar);
    printf("Seu peso se emagrecer %.2f\n",pesoEmagrecer);

    return 0;
}