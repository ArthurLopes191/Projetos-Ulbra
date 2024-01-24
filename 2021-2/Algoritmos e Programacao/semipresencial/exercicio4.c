#include <stdio.h>
#include <math.h>

void main(){
    double lado1, lado2, hipotenusa, centimetros;

    printf("A medida do lado maior da casa eh 11,5M\n");


    printf("A medida do lado menor da casa eh 6,3M \n");


    lado1 = 11.5;
    lado2 = 6.3;
    hipotenusa = sqrt(pow(lado1, 2) + pow(lado2, 2));
    centimetros = hipotenusa * 100;

    printf("A quantidade minima de fio a ser comprada em metros eh %.2fM \n", hipotenusa);
    printf("A quantidade minima de fio a ser comprada em centimetros eh %.2fCM \n", centimetros);

    
}
