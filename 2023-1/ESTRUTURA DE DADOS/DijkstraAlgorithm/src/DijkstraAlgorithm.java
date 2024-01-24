public class DijkstraAlgorithm {

    public static int dijkstra(Graph graph, int source, int destination) {
        int numVertices = graph.getNumVertices();

        // Inicialização das estruturas de dados
        int[] distances = new int[numVertices];
        boolean[] visited = new boolean[numVertices];
        for (int i = 0; i < numVertices; i++) {
            distances[i] = Integer.MAX_VALUE;
        }
        distances[source] = 0;

        // Loop principal
        for (int i = 0; i < numVertices - 1; i++) {
            int currentVertex = findMinDistance(distances, visited);
            visited[currentVertex] = true;

            for (int neighbor = 0; neighbor < numVertices; neighbor++) {
                int edgeWeight = graph.getWeight(currentVertex, neighbor);
                if (edgeWeight > 0 && !visited[neighbor]) {
                    int newDistance = distances[currentVertex] + edgeWeight;
                    if (newDistance < distances[neighbor]) {
                        distances[neighbor] = newDistance;
                    }
                }
            }
        }

        return distances[destination];
    }

    private static int findMinDistance(int[] distances, boolean[] visited) {
        int minDistance = Integer.MAX_VALUE;
        int minVertex = -1;

        for (int vertex = 0; vertex < distances.length; vertex++) {
            if (!visited[vertex] && distances[vertex] < minDistance) {
                minDistance = distances[vertex];
                minVertex = vertex;
            }
        }

        return minVertex;
    }

}
