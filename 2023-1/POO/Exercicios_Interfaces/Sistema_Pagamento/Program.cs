using Sistema_Pagamento;

Boleto boleto = new Boleto();
CartaoCredito cartaocredito = new CartaoCredito();

Cliente cliente1 = new Cliente(1, "Arthur", cartaocredito);
Cliente cliente2 = new Cliente(2, "João", boleto);

Console.WriteLine(cliente1.Comprar(129.90));
Console.WriteLine(cliente2.Comprar(50.90));