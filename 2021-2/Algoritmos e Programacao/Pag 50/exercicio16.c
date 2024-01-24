#include <stdio.h>
#include <math.h>

void main(){
    double lado1, lado2, hipotenusa;

    printf("Informe o valor de lado A do triangulo \n");
    scanf("%lf%*c", &lado1);

    printf("Informe o valor de lado B do triangulo \n");
    scanf("%lf%*c", &lado2);

    hipotenusa = sqrt(pow(lado1, 2) + pow(lado2, 2));

    printf("A hipotenusa eh %.2f \n", hipotenusa);

    
}
