
select p.nome as Produto, p.preco, v.data_venda
from produtos p, vendas_itens vi, vendas_itens v
where p.id=vi.id_produto and vi.id_venda=v.id and v.data_venda >= '2022-10-01' and v.data_venda <= '2022-11-30'



--ex 2
select sum(qtd*valor_unit) as total
from vendas_itens
where id_venda = 1001



--ex 3
select p.id, p.nome, vi.valor_unit
from produtos p, vendas v, vendas_itens vi
where p.id = vi.id_produto and v.id=vi.id_venda and v.data_venda >= '2022-10-01' and v.data_venda <= '2022-10-31'
order by vi.valor_unit ASC