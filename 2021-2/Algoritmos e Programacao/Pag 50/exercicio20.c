#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	
	float altura, anguloBase, anguloAltura, base, hipotenusa;

    printf("\nRecebe a medida do ângulo formado por uma escada apoiada no chão e a distância que a escada está da parede.");
    printf("\nCalcula e mostra a medida da escada para que se possa alcançar a ponta da escada. \n");
    
	printf("\nÂngulo: ");
	scanf("%f%*c", &anguloBase); // guarda o valor na variável angulo

	printf("Distância: ");
	scanf("%f%*c", &base); // guarda o valor em base

    hipotenusa = base / cos(anguloBase);
	if (hipotenusa < 0) // valida se a hipotenusa é um valor positivo
	{
		hipotenusa = hipotenusa * (-1);
	}

	altura = sqrt(pow(hipotenusa, 2) - pow(base, 2)); // calcula a altura
	anguloAltura = 180 - (90 + anguloBase);

	printf("\nA medida da escada é %.2f \n", hipotenusa);
	printf("A altura da escada é %.2f\n", altura);
	printf("Os três ângulos do triângulo são: 90, %.2f e %.2f graus. \n\n", anguloBase, anguloAltura);

	return 0;
}