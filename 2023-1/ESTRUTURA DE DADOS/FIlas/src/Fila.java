public class Fila {
        String[] vetor ;
        int fim, inicio;

    Fila(int value){
        fim=-1;
        inicio =-1;
        vetor = new String[value];
    }

    public boolean add(String value){
        if(isFull() != true){
            fim++;
            vetor[fim] = value;
            return true;
        }
        return false;
    }

    boolean remove(){
        if(isEmpty() != true){
            for(int i = 0; i < fim; i++){
                vetor[i] = vetor[i + 1];
            }
            fim--;
            return true;
        }
        return false;
    }

    void list() {
        if(isEmpty() != true){
            for (int i = 0; i <= fim; i++) {
                System.out.println(vetor[i]);
            }
        }else{
            System.out.println("Fila Vazia");
        }

    }

    public boolean isEmpty(){
        if (inicio == -1 && fim == -1){
            return true;
        }
        return false;
    }
    public boolean isFull() {
        if(fim == vetor.length-1){
            return true;
        }
        return false;
    }
}

