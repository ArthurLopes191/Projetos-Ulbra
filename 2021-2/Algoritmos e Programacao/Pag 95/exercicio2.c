#include <stdio.h>


int main(){
  int n, i, j;
  float fat, e = 1.0;

    printf("Informe um numero inteiro e positivo: \n");
    scanf("%d%*c", &n);
    
    for(i=1; i<= n; i++){
        fat = 1;
        for(j=1; j<= i; j++){
            fat = fat * j;
        }
            e = e + 1.0/fat;
    }

    printf("Valor de E: %.2f \n", e);



    return 0;
}