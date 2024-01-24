#include <stdio.h>

int main(){
    int categoria;
    char situacao;
    float preco, valorAumento, precoComImposto, precoNovo;

    printf("Digite o preco do produto \n");
    scanf("%f%*c", &preco);
    printf("Digite a categoria \n");
    scanf("%i%*c", &categoria);

    printf("Precisa de refrigeracao? \n");
    scanf("%c%*c", &situacao);

    switch (categoria)
    {
    case 1:{
        if (preco<=25){
            valorAumento=preco*0.05;
        }
        else{
            valorAumento = preco*0.12;
        }
        
    
        break;
        }

        case 2:{
            if (preco<=25){
            valorAumento=preco*0.08;
        }
        else{
            valorAumento = preco*0.15;
        }
        break;
        }

        case 3:{
            if (preco<=25){
            valorAumento=preco*0.10;
        }
        else{
            valorAumento = preco*0.18;
        }
        break;
        }
    
    default:
        printf("categoria invalida \n");
        break;
    }

    if((categoria ==2)&&(situacao == "r")){
        precoComImposto= preco*1.05;
    }
    else{
        precoComImposto=preco*1.08;
    }
    precoNovo = preco+valorAumento;

    if(precoNovo <= 50){

    }
    else if((precoNovo > 50)&&(precoNovo<120)){

    }
    else{

    }
    printf("Valor do produto %f \n", preco);
    printf("Valor do aumento do produto %f \n", valorAumento);
    printf("Valor do produto com imposto %f \n", precoComImposto);
    printf("Novo valor sem imposto %f \n", precoNovo);

    return 0;
}