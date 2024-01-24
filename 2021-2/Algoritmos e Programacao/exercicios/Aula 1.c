#include <stdio.h>
#include <string.h>
#define PI 3.14


int main(){
    //bloco de comandos
    int idade;
    float preco;
    int preco2, z;
    char sexo;
    char nome[15]; // \0
    idade = 37;
    preco = 34.8;
    preco2 = idade+preco;
    sexo = 'M';
    strcpy(nome, "Ramon");
   
    printf("Hello, galera! Digite sua idade: \n ");
    scanf("%d", &idade);
    printf("Digite o preço: \n");
    scanf("%f%*c", &preco);
    //fflush(stdout);
    printf("Digite o sexo: \n ");
    scanf("%c%*c", &sexo);
    //fflush(stdin);
    printf("Digite o nome: \n");
    scanf("%s", nome);
    
    printf("Sua idade eh = %d seu nome eh %s",idade,nome);

    return 0;

    //A é diferente de a
}