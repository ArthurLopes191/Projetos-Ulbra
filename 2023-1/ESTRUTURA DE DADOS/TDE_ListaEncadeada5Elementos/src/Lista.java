public class Lista {
    Elemento primeiro;

    Elemento fim;
    int tamanho = 0;

    public void addInicio(Elemento e){
        if(primeiro ==null){
            primeiro=e;
            tamanho++;
            fim=e;
        }else{
            e.proximo= primeiro;
            primeiro =e;
            tamanho++;

        }
    }

    public void addFim(Elemento e){
        if(primeiro == null){
            primeiro=e;
            tamanho++;
            fim=e;
        }else{
            fim.proximo = e;
            fim=e;
            tamanho++;

        }
    }


    public boolean mostrar(){
        if(primeiro!=null){
            Elemento aux = primeiro;
            while(aux != null){
                System.out.println(aux.valor);
                aux = aux.proximo;
            }
            return true;
        }else{
            //System.out.println("Lista vazia");
            return false;
        }
    }

    public int achar(int num){
        int posicao = -1;
        if (primeiro != null){
            Elemento aux = primeiro;
            while(aux!=null){
                posicao++;
                if(aux.valor == num){
                    return posicao;
                }
                aux=aux.proximo;
            }
            return -1;
        }else{
            //System.out.println("Lista vazia");
            return -1;
        }
    }

    public boolean removerValor(int valor){
        int posicao = achar(valor);
        return removerPosicao(posicao);
    }

    public boolean removerPosicao(int posicao){
        if(posicao > tamanho){
            return false;
        }else{
            if(posicao == -1){
                return false;
            }else{
                if(posicao == 0){
                    return delInicio();
                } else if (posicao == tamanho -1){
                    return delFim();
                }else{
                    Elemento aux = primeiro;
                    Elemento ant = primeiro;
                    for(int i = 0; i < posicao; i++){
                        ant = aux;
                        aux=aux.proximo;
                    }
                    ant.proximo = aux.proximo;
                    tamanho--;
                    return true;
                }
            }
        }
    }

    public boolean delFim(){
        if(primeiro!=null){
            Elemento aux= primeiro;
            Elemento pena= primeiro;
            while (aux.proximo!=null){
                pena=aux;
                aux=aux.proximo;
            }
            if (primeiro==fim){
                primeiro=null;
            }
            pena.proximo=null;
            fim=pena;
            tamanho--;
            return true;
        }else{
            //System.out.println("Lista vazia");
            return false;
        }
    }


    public boolean delInicio(){
        if(primeiro!=null){
            Elemento aux= primeiro;
            if (primeiro==fim){
                fim=null;
            }
            primeiro=aux.proximo;
            tamanho--;
            return true;
        }else{
            //System.out.println("Lista vazia");
            return false;
        }
    }
}
