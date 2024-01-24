#include<stdio.h>
#include<math.h>

int main(){
  int corte, tabua, tamanhoTabua, quantidade, sobra;

    printf("Informe o tamanho da tabua em metros\n");
    scanf("%d%*c", &tamanhoTabua);

    printf("Informe o tamanho do corte em cm\n");
    scanf("%d%*c", &corte);


  tabua = tamanhoTabua * 100;

  quantidade = tabua / corte;

  sobra = tabua - corte * quantidade ;


  printf("\nA quantidade de pedacos na tabua eh: %d \n", quantidade);
  printf("A sobra de pedacos na tabua eh: %dcm \n", sobra);


  return 0;
}