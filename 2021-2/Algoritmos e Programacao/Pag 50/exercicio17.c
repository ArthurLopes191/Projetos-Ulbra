#include <stdio.h>
#include <math.h>

void main(){
    double comprimento, pi, raio, area, volume;

    printf("Informe o raio \n");
    scanf("%lf%*c", &raio);

    pi = 3.14159; 
    comprimento = 2 * pi * raio;
    area = pi * (raio * raio); 
    volume = 3 / 4 * pi * (raio * raio * raio);


    printf("O valor do comprimento eh %.2f \n", comprimento);
    printf("O valor da area eh %.2f \n", area);
    printf("O valor do volume eh %.2f \n", comprimento);


}