#include <stdio.h>

int main(){
    int anoNasc, anoAtual, idadeAnos, idadeMeses, idadeDias, idadeSemanas;

    printf("Informe o ano de nascimento \n");
    scanf("%d%*c", &anoNasc);

    printf("Informe o ano atual \n");
    scanf("%d%*c", &anoAtual);

    idadeAnos = anoAtual - anoNasc;
    idadeMeses = idadeAnos * 12;
    idadeDias = idadeAnos *365;
    idadeSemanas = idadeMeses *4;

    printf("A idade em anos eh %d \n", idadeAnos);
    printf("A idade em meses eh %d \n", idadeMeses);
    printf("A idade em dias eh %d \n", idadeDias);
    printf("A idade em semanas eh %d \n", idadeSemanas);

    return 0;
}