public class Main {
    public static void main(String[] args) {
        Pilha minhaPilha = new Pilha(10);

        minhaPilha.push(5);
        minhaPilha.push(8);
        minhaPilha.push(7);
        minhaPilha.push(5);
        minhaPilha.push(8);
        minhaPilha.push(7);
        minhaPilha.push(5);
        minhaPilha.push(8);
        minhaPilha.push(7);
        minhaPilha.push(5);
        minhaPilha.pop();
        minhaPilha.pop();
        minhaPilha.pop();
        minhaPilha.pop();
        minhaPilha.pop();


        minhaPilha.top();
    }
}
