import java.util.Random;

public class Main {
    public static void main(String[] args) {
        // Definindo a matriz
        int[][] imagem = new int[10][10];
        Random rand = new Random();
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                imagem[i][j] = rand.nextInt(2);
                
            }
        }
        //Definindo a matriz com o padrao a ser buscado
        int[][] padrao = {{1,1}, {1,0}, {0,1}};

        //Contando quantas vezes o padrao foi encontrado
        int vezesEcontrado = 0;
        for (int i = 0; i < imagem.length - padrao.length; i++){
            for (int j = 0; j < imagem[0].length - padrao[0].length; j++){
                if (verificaPadrao(imagem, padrao, i , j)) {
                    vezesEcontrado++;
                }
            }
        }
        // Imprimindo o resultado da busca
        if (vezesEcontrado > 0) {
            System.out.println("O padrao foi encontrado " + vezesEcontrado + " vezes na imagem.");
        } else {
            System.out.println("O padrao nao foi encontrado na imagem.");
        }
    }

    // Função que verifica se um padrão está presente na imagem em uma determinada posição
    public static boolean verificaPadrao(int[][] imagem, int[][] padrao, int i, int j) {
        for (int k = 0; k < padrao.length; k++) {
            for (int l = 0; l < padrao[0].length; l++) {
                if (padrao[k][l] != imagem[i + k][j + l]) {
                    return false;
                }
            }
        }
        return true;
    }
}
