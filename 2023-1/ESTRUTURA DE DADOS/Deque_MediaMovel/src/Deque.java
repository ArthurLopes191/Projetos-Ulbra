public class Deque {
        int[] vetor ;
        int fim, inicio;

    Deque(int value){
        fim=-1;
        inicio =-1;
        vetor = new int[value];
    }

    public boolean addFirst(int value){
        if(!isFull()) {
            if (isEmpty()) {
                inicio = 0;
                fim = 0;
            }else if(inicio == 0){
                inicio = vetor.length - 1;
            }else{
                inicio--;
            }
            vetor[inicio] = value;
            return true;
        }
        return false;
    }

    public boolean addLast(int value){
        if (!isFull()) {
            if (isEmpty()) {
                inicio = 0;
                fim = 0;
            } else if (fim == vetor.length - 1) {
                fim = 0;
            } else {
                fim++;
            }
            vetor[fim] = value;
            return true;
        }
        return false;
    }

    public boolean removeFirst() {
        if (!isEmpty()) {
            if (inicio == fim) {
                inicio = -1;
                fim = -1;
            } else if (inicio == vetor.length - 1) {
                inicio = 0;
            } else {
                inicio++;
            }
            return true;
        }
        return false;
    }

    public boolean removeLast() {
        if (!isEmpty()) {
            if (inicio == fim) {
                inicio = -1;
                fim = -1;
            } else if (fim == 0) {
                fim = vetor.length - 1;
            } else {
                fim--;
            }
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

