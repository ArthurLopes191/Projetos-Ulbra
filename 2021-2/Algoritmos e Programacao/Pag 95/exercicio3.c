#include <stdio.h>

int main(){
int n, num,  i, j, fat;

   printf("Digite a quantidade de numeros que serao lidos: \n");
 
   scanf("%d" ,&n);   

   for (i = 1; i<=n; i++){
       printf("Digite o numero \n");
           scanf("%d",&num);
           fat = 1;

         for (j = 1; j<=num; j++){
               fat = fat * j ;
 }
        printf("O Fatorial de %d = %d \n", num, fat);
}

return 0;
}