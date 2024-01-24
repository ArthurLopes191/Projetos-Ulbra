-- EX 1
select descricao   
from produtos
order by descricao asc;

--EX 2
select p.id, f.nome
from produtos p, pedidos pd, fornecedores f
where p.id = pd.id_produto and f.id = pd.id_fornecedor

--EX 2 CORRIGIDO
select f.nome, pd.descricao, pd.qtd, pd.valor, f.nome
from fornecedores f
        inner join pedidos p
            on  p.id_forn = f.id
        inner join pedidos_itens pi
            on pi.id_pedido = p.id
        inner join produtos pd     
            on  pd.id = pi.id_produto


--EX 3
select p.id, c.id
from produtos p, pedidos pd, categoria c
where p.id = pd.id_produto and c.id = p.id_categoria

--EX 3 CORRIGIDO

select pd.id, pd.descricao, c.nome as categoria
from  pedidos_itens pi
        inner join pedidos
            on pi.id_pedido = p.id
        inner join produtos pd     
            on  pd.id = pi.id_produto
        inner join categorias categoria
            on c.id = pd.id_categoria
--EX 4
select f.nome, pd.date, p.descricao
from fornecedores f, pedidos pd, produtos pd
where f.id = pd.id_fornecedor and p.id = pd.id_produto
order by pd.date desc

--EX 4 CORRIGIDO / Mostre o nome do fornecedor, a data do último pedido e a descrição do produto que ele pediu. 

select f.nome as fornecedor, pd.id, pd.descricao, max(p.data) as data_ultimo_pedido_feito
from fornecedores f
        inner join pedidos p
            on  p.id_forn = f.id
        inner join pedidos_itens pi
            on pi.id_pedido = p.id
        inner join produtos pd     
            on  pd.id = pi.id_produto
group by f.nome, pd.id, pd.descricao
having data_ultimo_pedido_feito between '2022-07-01' and '2022-10-31'




from 