using Exercicios_Heranca;
public class Program
{
    private static void Main(string[] args)
    {
        
        Cachorro cachorro = new Cachorro("Logan");
        cachorro.Falar();

        Gato gato = new Gato("Tom");
        gato.Falar();

        Carro carro = new Carro("Corsa");
        carro.Acelerar();

        Moto moto = new Moto("cb300");
        moto.Acelerar();
        

        SuperHeroi superheroi = new SuperHeroi("Homem Aranha", 500, 900, "Atirar teia");

        SuperVilao supervilao = new SuperVilao("Homem areia", 400, 700, "Areia" );

        superheroi.Lutar(superheroi.Nome);
        superheroi.SuperPoder(superheroi.Nome, superheroi.Poderes);

        supervilao.Lutar(supervilao.Nome);
        supervilao.SuperPoder(supervilao.Nome, supervilao.Poderes);
    }
}