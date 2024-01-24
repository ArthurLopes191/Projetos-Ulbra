//Leia um conjunto de notas  com vetores, cuja quantidade seja determinada pelo usuário. Calcule a média de todas elas. Exiba o conjunto das notas maiores do que a média calculada. Em seguida, de forma agrupada, exiba o outro conjunto de notas (menores do que a média).

#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main(){

    int qtdNota, soma;
    int nota[qtdNota];
    int i = 0;
    int media; 
    int maior[qtdNota], menor[qtdNota];

    printf("Digite a quantidade de notas a serem lidas: \n");
    scanf("%d%*c", &qtdNota);

    for (i; i < qtdNota; i++)
    {
        printf("INFORME A NOTA [%d]\n",i);
        scanf("%d%*c", &nota[i]);
        soma= soma + nota[i];
    }


    media= soma / qtdNota;
    printf("\nMEDIA: %d \n", media);

    for (i=0; i < qtdNota; i++)
    {
        if (nota[i] >= media)
        {
            maior[i] = nota[i];
            printf("A Nota[%d] eh MAIOR que a media calculada: %d\n", i,maior[i]);
        }
        else if (nota[i] < media)
        {
            menor[i] = nota[i];
            printf("A Nota[%d] eh MENOR que a media calculada: %d\n", i,menor[i]);
        }
    }
   
    return 0;
}