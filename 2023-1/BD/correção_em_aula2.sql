um cliente tem muitas vendas
uma venda tem muitos produtos
um produto pode estar em muitas vendas
vendas pode ter muitas formas de pagamento
forma de pagamento pode estar em muitas vendas


--quantas tabelas tem?

cliente(id, nome);

produtos(id, nome);

vendas_produtos(id_venda, id_produto, qtd, valor_unit);

vendas(id, data_venda, id_cliente);

forma_pagamentos(id, nome);

forma_pagamentos_vendas (id_venda, id_formapgto, valor);

-- listar todos os produtos vendidos no mes de fevereiro 2023
select p.nome as nome_produto, sum(vp.qtd) as qtd_vendida, sum(vp.qtd * vp.valor_unit ) as valor_total
from produtos p
	inner join vendas_produtos vp
		on p.id = vp.id_produto
	inner join vendas v
		on v.id = vp.id_venda
where v.data_venda >= '2023-02-01'and v.data_venda <= '2023-02-31'
group by p.nome	;



-- listar o valor total de vendas por forma de pagamento no mes de fev. 23
select fp.nome as forma_pagamento, sum(fpv.valor) as total
from forma_pagamento fp
		inner join forma_pagamento_vendas fpv
			on fp.id = fpv.id_formapgto
		inner join vendas.v 
			on v.id = fpv.id_venda
where  v.data_venda >= '2023-02-01'and v.data_venda <= '2023-02-31'
group by f.nome

