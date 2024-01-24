#include<stdio.h>
#include<math.h>

int main(){
  int corte, tabua3, tabua4, tabua5, quantidade3, quantidade4, quantidade5, sobra3, sobra4, sobra5;

  corte = 45;
  tabua3 = 3 * 100;
  tabua4 = 4 * 100;
  tabua5 = 5 * 100;
  quantidade3 = tabua3 / corte;
  quantidade4 = tabua4 / corte;
  quantidade5 = tabua5 / corte;
  sobra3 = tabua3 - corte * quantidade3 ;
  sobra4 = tabua4 - corte * quantidade4 ;
  sobra5 = tabua5 - corte * quantidade5 ;

  printf("\nA quantidade de pedacos de 45cm na tabua de 3 metros eh: %d \n", quantidade3);
  printf("A sobra de pedacos na tabua de 3 metros eh: %dcm \n", sobra3);

  printf("\nA quantidade de pedacos 45cm na tabua de 4 metros eh: %d \n", quantidade4);
  printf("A sobra de pedacos na tabua de 4 metros eh: %dcm \n", sobra4);

  printf("\nA quantidade de pedacos 45cm na tabua de 5 metros eh: %d \n", quantidade5);
  printf("A sobra de pedacos na tabua de 5 metros eh: %dcm \n", sobra5);

  return 0;
}