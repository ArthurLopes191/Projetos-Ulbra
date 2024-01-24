    #include <stdio.h>

int main(){
    float altura, sexo, alturaMetro, pesoIdeal;

    printf("\n SELECIONE SEU SEXO: \n");
    printf("\n Digite 1 para masculino. \n");
    printf(" Digite 2 para feminino.\n");
    scanf("%f%*c", &sexo);

    if (sexo == 1){
        printf("\n Digite sua altura cm: \n");
        scanf("%f%*c", &altura);
        alturaMetro = altura / 100;
        pesoIdeal = (72.7*alturaMetro) - 58;
        printf("Seu peso ideal eh: %.2fkg \n", pesoIdeal);

    }

    if (sexo == 2){
        printf("\n Digite sua altura em cm: \n");
        scanf("%f%*c", &altura);
        alturaMetro = altura / 100;
        pesoIdeal = (62.1*alturaMetro) - 44.7;
        printf("Seu peso ideal eh: %.2fkg \n", pesoIdeal);

    }
    
    return 0;
}
