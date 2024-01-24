public class Pilha {
        private int topo=-1;
        private int[] vetor = new int[10];

        public Pilha(int value){
            topo=-1;
            vetor = new int[value];

        }

        public boolean pop(){
            if(!isEmpty()){
                int valor=vetor[topo];
                topo--;
                System.out.println("Removido: " + valor);
                return true;
            }
            return false;
        }
        public boolean push(int valor){
            if(!isFull()){
                topo++;
                vetor[topo]=valor;
                System.out.println("Adicionado: " + vetor[topo]);
                return true;
            }
            return false;
        }

        public void top(){
            if(!isEmpty()) {
                System.out.println(vetor[topo]);
            }else{
                System.out.println("Pilha vazia");
            }

        }

        private boolean isEmpty(){
            if(topo==-1){
                return true;
            }
            return false;
        }

        private boolean isFull(){
            if (topo == vetor.length-1){
                return true;
            }
            return false;
        }
}
