#include <stdio.h>

int main(){
    int H, HorasExtras, HorasFaltadas;

    printf("Digite a quantidade de horas extras: \n");
    scanf("%d%*c", &HorasExtras);

    printf("Digite a quantidade de horas faltadas: \n");
    scanf("%d%*c", &HorasFaltadas);

    H = HorasExtras - ((2.0 / 3.0) * HorasFaltadas); 

    if (H >= 2400){
        printf("Premio de R$500,00 \n", H);
    }

    else if ((H >= 1800)&&(H < 2400)){
        printf("Premio de R$400,00 \n", H);
    }

    else if ((H >= 1200)&&(H < 1800)){
        printf("Premio de R$300,00 \n", H);
    }

    else if ((H >= 600)&&(H < 1200)){
        printf("Premio de R$200,00 \n");
    }

    else if (H < 600){
        printf("Premio de R$100,00 \n", H);
    }


    return 0;
}