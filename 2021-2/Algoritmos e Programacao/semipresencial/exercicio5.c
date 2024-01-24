#include <stdio.h>
#include <math.h>

void main(){
    double lado1, lado2, hipotenusa;

    printf("Informe a medida do lado maior da casa\n");
    scanf("%lf%*c", &lado1);

    printf("Informe a medida do lado menor da casa \n");
    scanf("%lf%*c", &lado2);

    hipotenusa = sqrt(pow(lado1, 2) + pow(lado2, 2));

    printf("A quantidade minima de fio a ser comprada em metros eh %.2f \n", hipotenusa);

    
}
