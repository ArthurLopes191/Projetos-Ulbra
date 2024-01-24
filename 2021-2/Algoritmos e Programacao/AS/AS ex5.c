#include <stdio.h>
#include <ctype.h>
#include <string.h>

int main() 
{
    int qtdPessoas, op, continua =0;
    int tel[50];
    char nome[50][50];
    char busca[20];
    int cont = 0;

    printf("Informe a quantidade de pessoas que serao cadastradas: \n");
    scanf("%d", &qtdPessoas);

    
    for (int i = 0; i < qtdPessoas; i++)
    {
        cont++;
        printf("Digite o NOME da pessoa[%d]\n",cont);
        scanf("%s", nome[i]);
        printf("Digite o NUMERO de telefone da pessoa[%d]\n",cont);
        scanf("%d", &tel[i]);
    }

    do
    {   
        printf("\n Digite o numero da opcao desejada.");
        printf("\n MENU DE OPCOES:\n");
        printf("1- CONSULTA DE TELEFONES\n");
        printf("2- FINALIZAR SISTEMA\n");
        scanf("%d", &op);
        printf("\n");
        switch (op)
        {
        case 1:
            printf("Digite o nome da pessoa que deseja consultar\n");
            fflush(stdin);
            scanf("%s", busca);
            printf("\n");

        
            for (int i = 0; i < qtdPessoas; i++)
            {
                if (strcmp(busca, nome[i] ) == 0 )  
                {                                          
                    printf("    NOME  : %s\n", nome[i]);
                    printf("TELEFONE  : %d\n", tel [i]);
                }
            }
            break;

        case 2:
            return 0;
        
        default:
            printf("\n");
            printf("OPCAO INVALIDA!\n");
            break;
        }  
    } while (continua == 0);
    
}
