/*FUP para ler e escrever três números. Se o primeiro for positivo, imprimir sua raiz quadrada, caso contrário, imprimir o seu quadrado; se o segundo número for maior que 10 e menor que 100, imprimir a mensagem: "NÚMERO ESTÁ ENTRE 10 E 100 - INTERVALO PERMITIDO"; se o terceiro número for menor que o segundo, calcular e escrever a diferença entre eles, caso contrário, calcular e escrever a soma entre eles. */

#include <stdio.h>
#include <math.h>

int main(){
    int n1, raiz, potencia;
    float n2, n3, soma, sub;

    printf("Digite o primeiro numero: \n");
    scanf("%d%*c",&n1);
    
    printf("Digite o segundo numero: \n");
    scanf("%f%*c",&n2);

    printf("Digite o terceiro numero: \n");
    scanf("%f%*c",&n3);

    if (n1 > 0){
        raiz = sqrt(n1); 
        printf("Primeiro numero - A raiz quadrada eh: %d \n", raiz);
    }else{
        potencia = pow(n1, 2);
        printf("Primeiro numero - O numero elevado ao quadrado eh: %d \n", potencia);
    }

    if((n2 > 10)&&(n2 <100)){
        printf("Segundo numero - O NUMERO ESTA ENTRE 10 E 100! - INTERVALO PERMITIDO \n");
    }else{
        printf("Segundo numero - O NUMERO NAO ESTA ENTRE 10 E 100! - INTERVALO NAO PERMITIDO \n");
    }

    if (n3 < n2){
        sub = n2 - n3;
        printf("A diferenca entre o segundo e primeiro numero eh: %.2f", sub);
    }
    else{
      soma = n3 + n2;
        printf("A soma entre o segundo e primeiro numero eh: %.2f", soma);  
    }

    return 0;
}