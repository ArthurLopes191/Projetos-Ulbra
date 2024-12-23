public class Main {
    public static void main(String[] args) {
        // Exemplo de uso do algoritmo
        DijkstraAlgorithm dijkstraAlgorithm = new DijkstraAlgorithm();

        // Criação do grafo e adição de arestas com pesos
        Graph graph = new Graph(6);
        graph.addEdge(0, 1, 2);
        graph.addEdge(0, 2, 4);
        graph.addEdge(1, 2, 1);
        graph.addEdge(1, 3, 7);
        graph.addEdge(2, 4, 3);
        graph.addEdge(3, 4, 1);
        graph.addEdge(3, 5, 5);
        graph.addEdge(4, 5, 2);

        int source = 0;
        int destination = 5;

        int shortestDistance = dijkstraAlgorithm.dijkstra(graph, source, destination);
        System.out.println("A menor distância entre a parada " + source + " e a parada " + destination + " é: " + shortestDistance);
    }
}