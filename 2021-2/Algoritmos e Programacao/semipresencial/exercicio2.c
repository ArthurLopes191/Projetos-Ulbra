#include<stdio.h>
#include<stdlib.h>
#include<math.h>
int main() {
  float cm, polegada;

    printf("Digite o valor em cm \n");
    scanf("%f%*c", &cm);

    polegada = cm / 2.54;
    
    printf("%.2f - %.2f\n", cm,polegada);
    printf("Valor acrescentado mais 10cm %.2f \n", cm=(polegada+10)/2.54);
    printf("Valor acrescentado mais 20cm %.2f \n", cm=(polegada+20)/2.54);
    printf("Valor acrescentado mais 30cm %.2f \n", cm=(polegada+30)/2.54);
    printf("Valor acrescentado mais 40cm %.2f \n", cm=(polegada+40)/2.54);
    printf("Valor acrescentado mais 50cm %.2f \n", cm=(polegada+50)/2.54);
    printf("Valor acrescentado mais 60cm %.2f \n", cm=(polegada+60)/2.54);
    printf("Valor acrescentado mais 70cm %.2f \n", cm=(polegada+70)/2.54);
    printf("Valor acrescentado mais 80cm %.2f \n", cm=(polegada+80)/2.54);
    printf("Valor acrescentado mais 90cm %.2f \n", cm=(polegada+90)/2.54);
    printf("Valor acrescentado mais 100cm %.2f \n", cm=(polegada+100)/2.54);
    

  
    return 0;
}