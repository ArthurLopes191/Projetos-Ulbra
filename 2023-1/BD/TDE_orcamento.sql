create database orcamento;
use orcamento;

CREATE TABLE Produtos (
    id int auto_increment primary key,
    nome varchar(100),
    valor double not null,
    saldo int not null
);

CREATE TABLE Orcamentos (
    id int auto_increment primary key,
    data_orcamento date,
    status_orcamento varchar(20)
);


CREATE TABLE Orcamentos_itens (
    id_prod int not null,
    id_orc int not null,
    valor_unit double not null,
    quantidade int not null,
    valor_total_item double not null,
    constraint fk_orcamento_itens_produtos
    foreign key (id_prod) references Produtos(id)
		on delete restrict
        on update cascade,
	constraint fk_orcamento_itens_orcamento
    foreign key (id_orc) references Orcamentos(id)
		on delete restrict
        on update cascade
);



--------------------------------------------------

INSERT INTO Produtos (nome, valor, saldo)
VALUES  
    ('Chinelo', 100.00, 50),
    ('Rapadura', 200.00, 100),
    ('Garrafa', 300.00, 75),
    ('Camiseta', 150.00, 200),
    ('Torneira', 100.00, 4),
    ('Vaso', 50.00, 5),
    ('Computador', 600.00, 10),
    ('Produto teste', 100.00, 5),
    ('Produto teste 3', 150.00, 2);
    
    
INSERT INTO Orcamentos (data_orcamento, status_orcamento) 
VALUES 
    ('2022-01-01', 'em orçamento'),
    ('2022-01-02', 'vendido'),
    ('2022-01-03', 'cancelado'),
    ('2022-01-04', 'em orçamento'),
    ('2022-03-04', 'vendido'),
    ('2024-09-04', 'vendido'),
    ('2014-09-04', 'vendido');
    
    
INSERT INTO Orcamentos_itens (id_prod, id_orc, valor_unit, quantidade, valor_total_item) 
VALUES 
    (1, 1, 100.00, 2, 200.00),
    (2, 1, 200.00, 1, 200.00),
    (3, 2, 300.00, 3, 900.00),
    (4, 3, 150.00, 5, 750.00),
    (1, 4, 100.00, 3, 300.00),
    (3, 4, 300.00, 2, 600.00),
    (1, 5, 100.00, 3, 300.00),
    (8, 6, 600.00, 1, 600.00),
    (8, 7, 600.00, 1, 600.00);
    
    
 /*Criar UMA view que dê condições de:
Lista de orçamentos por produto
Valor total de produtos orçados por período	
ex. valor total dos produtos orçados no mes de março de 2022
Produtos que tem “Computador” no nome e que tem quantidade em estoque.
Os 10 produtos mais orçados no mês de setembro de 2014 e que ainda tem saldo em estoque. Somente os produtos com o valor acima de R$ 500.00.
*/   



create view produtos_orcados_por_periodo as
select p.nome as nome_produto, o.status_orcamento, sum(oi.valor_total_item)
from Orcamentos o
	inner join Orcamentos_itens oi
		on o.id = oi.id_orc
	inner join Produtos p
		on p.id = oi.id_prod
where o.data_orcamento >= '2014-09-01' and o.data_orcamento <= '2024-09-31' and p.saldo > 0 
group by p.nome 
having p.nome like "%Computador%" 
limit 10;

-----------------------------------------------------------



/*Faça uma consulta utilizando a view para acrescentar 20% nos produtos que o saldo em estoque é menor ou igual a 5.
id, nome do produto, valor atual, valor_mais20*/

create view valor_mais20_produtos_estoque_ate_5 as
select id, nome, valor as valor_atual, valor * 1.2 as valor_mais20 
from Produtos
where saldo <= 5;


/*Delete todos os produtos que não foram orçados.*/

-- não da para criar view com comando delete -- create view deletar_produtos_sem_orcamento as

select Produtos.nome 
from Produtos
where id not in(
    select id_prod FROM Orcamentos_itens
    where id_prod = Produtos.id
);
-- esse delete realiza um subconsulta na tabela orcamentos itens

-- Explique quando utilizar o GROUP BY, de um exemplo sql.
A clausula GROUP BY é usada em consultas SQL para agrupar linhas baseado em semelhanças entre elas.
Ela deve ser utilizada quando voce quiser resumir dados de uma tabela, como calcular todas elas ou realizar a media.
EX::: Um exemplo seria seria se voce quisesse realizar uma consulta que retorne o nome do cliente, a soma do valor total das compras dele:

select c.nome, sum(p.valor) as valor_total
from pedidos p
	inner join clientes c
		on c.id = p.id_cliente
group by c.nome


-- Explique quando utilizar o HAVING, de um exemplo sql.

Basicamente o having é o where do group by, é usado quando voce vai fazer uma consulta e precisou agrupar as linhas primeiro,
determina uma condição de busca para um grupo ou um conjunto de registros
e é usado para filtrar o resultado de uma consulta que usa uma função agregada SUM, COUNT, AVG...
EX::: Um exemplo é igual o de cima porém, além de realizar uma consulta que retorne o nome do cliente, a soma do valor total das compras dele
e também o total de pedidos de cada cliente porém apenas aquele que realizou 3 ou mais pedidos


select c.nome, sum(p.valor_total) as valor_total, count(*) as total_pedidos
from pedidos p
	inner join clientes c
		on c.id = p.id_cliente
group by c.nome
having count(*) >= 3;


-- Explique quando utilizar o UNION, de um exemplo sql.
O operador UNION combina os resultados de duas ou mais tabelas em um único resultado,
retornando todas as linhas pertencentes a todas as tabelas envolvidas na execução.
Para utilizar o UNION, o número e a ordem das colunas precisam ser idênticos em todas as tabelas e os tipo de dados precisam ser compatíveis.

EX::: Por exemplo, considere duas tabelas "estudantes1" e "estudantes2", que armazenam informações sobre estudantes em duas turmas diferentes:

select id, nome, idade, genero
from estudantes1
UNION
SELECT id, nome, idade, genero
FROM estudantes2;

-- Explique quando utilizar o LEFT JOIN, de um exemplo sql.
O LEFT JOIN é um tipo de join que retorna todos os registros da tabela da esquerda 
é útil quando queremos exibir todos os registros de uma tabela, independentemente de haver correspondência em outra tabela relacionada. 
Isso pode ser útil em situações em que precisamos incluir informações opcionais ou que estejam vazias(null) de uma tabela relacionada em uma consulta.
EX:: Um exemplo seria mostrar todos os clientes e seus pedidos e data, incluido os que não realizaram nenhum pedido.

SELECT c.nome, p.id_pedido, p.data
FROM clientes c
LEFT JOIN pedidos p
ON c.id_cliente = p.id_cliente;