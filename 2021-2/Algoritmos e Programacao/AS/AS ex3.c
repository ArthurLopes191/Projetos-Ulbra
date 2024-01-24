//Leia um conjunto de alunos, cada uma com o nome e a nota armazenados em um vetor de 10. Em seguida, exiba o nome dos alunos que possuem nota maior do que a média da turma.

#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main(){

    int nota[10];
    int soma, media;
    char nome[10][100];
    int qtdAlunos;
    int cont=0;
    
    printf("Informe a quantidade de alunos: \n");
    scanf("%d%*c", &qtdAlunos);

    for (int i = 0; i < qtdAlunos; i++)
    {
        cont++;
        printf("Digite o NOME do aluno [%d] :\n", cont);
        scanf("%s", nome[i]);
        printf("Informe a NOTA do aluno:\n");
        scanf("%d", &nota[i]);
        soma= soma + nota[i];
    } 
    
    media = soma /qtdAlunos;
    printf("MEDIA: %d\n", media);

    for (int i = 0; i < qtdAlunos; i++)
    {
        if (nota[i] >= media)
        {
            printf("Aluno na media:%s\n", nome[i]);
        }

        if (nota[i] < media)
        {
            printf("Aluno fora da media:%s\n", nome[i]);
        }
    } 


    return 0;
}