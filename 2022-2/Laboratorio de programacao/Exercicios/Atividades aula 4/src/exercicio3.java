/*3 - Crie uma classe que gera um número aleatoriamente (entre 5 e 10) por
Math.random. Em seguida, faça com que apareça em tela uma senha
numérica contendo a mesma quantidade de dígitos correspondentes ao
valor aleatório gerado. Apresente em tela o número sorteado e a senha.*/

public class exercicio3 {
    public static void main(String[] args){
        String senha = "";
        String senha2 = "";
        int numeroAleatorio =  (int) (Math.random() * (10 + 1 - 5) + 5);
        System.out.println("O numero gerado foi " + numeroAleatorio);

        for(int i = 0; i <= numeroAleatorio-1; i++){
            int numeroAleatorio2 =  (int) (Math.random() * (10));
            senha = "" + numeroAleatorio2;
            senha2 = senha2 + senha;
        }
        System.out.println("A senha gerada com " + numeroAleatorio + " digitos foi: " + senha2);
    }
}
