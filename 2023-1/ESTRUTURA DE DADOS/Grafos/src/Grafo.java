
public class Grafo {
    private int totalPessoas;
    private int[][] listaAdjacencias;

    public Grafo(int totalPessoas){
        this.totalPessoas = totalPessoas;
        this.listaAdjacencias = new int[totalPessoas][totalPessoas];
    }

    public void adicionarAresta(int pessoa1, int pessoa2) {
        listaAdjacencias [pessoa1][pessoa2] = 1;
        listaAdjacencias [pessoa2][pessoa1] = 1;
    }

    public void imprimirGrafo(){
        for(int i = 0; i < totalPessoas; i++){
            System.out.println("Pessoa " + i + " é amiga de: ");
            for(int j = 0; j < totalPessoas; j++){
                if(listaAdjacencias[i][j] == 1) {
                    System.out.println(j + " ");
                }
            }
            System.out.println();
        }
    }
}
