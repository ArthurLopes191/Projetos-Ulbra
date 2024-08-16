const Pedido = require("./pedido/pedido")

let produto = new Produto("pastel", 4)
let produtoSalvo = produto.salvar()
console.log("produtoSalvo ->", produtoSalvo)




