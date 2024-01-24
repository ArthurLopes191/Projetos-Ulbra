
namespace Aula02_00_basic
{
    public class Garrafa
    {
        //caracteristicas
            public int Codigo{get;protected set;}
            public String Cor { get; set; }

            public int AnoFabricacao { get; protected set; }

            public string Identificacao { get; protected set; }
            public int Volume { get; set; }

        //estado
            
        //comportamento
            

            //Construtor
            public Garrafa(int codigo, string cor, int ano, string ident)
            {
                this.Codigo = codigo;
                this.Cor = cor;
                this.AnoFabricacao = ano;
                this.Identificacao = ident;
            }


            

    }
}