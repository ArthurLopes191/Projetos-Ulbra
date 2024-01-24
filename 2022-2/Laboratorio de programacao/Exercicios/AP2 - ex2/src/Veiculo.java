public class Veiculo {
    private boolean ligado;

    public void ligar(){
        this.ligado = true;
    }

    public void desligar(){
        this.ligado = false;
    }

    public boolean getIsLigado(){
        System.out.println(ligado);
        return ligado;
    }


}
