create database AP2_panificadora;

use AP2_panificadora;

set autocommit=0;

--  2) Criação das tabelas:

create table categorias(
id int not null primary key,
nome varchar(100) not null
);

create table produtos(
id int not null primary key,
nome varchar(100) not null,
id_categoria int not null,
-- data_validade date not null  / incluido no exercicio 3 via alter table
constraint fk_produtos_categoria
foreign key(id_categoria) references categorias(id)
	on delete restrict
	on update cascade
);

create table ingredientes(
id int not null primary key,
nome varchar(100) not null
);

create table ingredientes_produtos(
id_produto int not null,
id_ingrediente int not null,
qtd_utilizada float not null,
constraint fk_produtos_ingredientes
foreign key(id_produto) references produtos(id)
	on delete restrict
    on update cascade,
constraint fk_ingredientes_produtos
foreign key(id_ingrediente) references ingredientes(id)
	on delete restrict
	on update cascade
);

create table estoque(
id int not null primary key,
quantidade int,
id_ingredientes int not null,
constraint fk_estoque_ingredientes
foreign key(id_ingredientes) references ingredientes(id)
	on delete restrict
    on update cascade
);

create table producao(
id int not null primary key,
qtd_produzida int not null,
data_producao date not null,
id_produto int not null,
constraint fk_producao_produto
foreign key(id_produto) references produtos(id)
	on delete restrict
    on update cascade
);

select *
from producao
--  //////////////////////// 3) Alterar a tabela de Produtos e incluir o tempo de validade. \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

alter table produtos 
add data_validade date not null;

-- ----------------------------------------------------------------------------------------------------------------------------------------------

-- ///////////////////////// 4) Scripts de inserção: \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

-- Inserindo categorias
INSERT INTO categorias (id, nome) VALUES
(1, 'Pães'),
(2, 'Bolos'),
(3, 'Biscoitos');

-- Inserindo produtos
INSERT INTO produtos (id, nome, id_categoria, data_validade) VALUES 
(1, 'Pão francês', 1, '2023-05-08'),
(2, 'Bolo de cenoura', 2, '2023-05-11'),
(3, 'Biscoito de chocolate', 3, '2023-05-20'),
(4, 'Biscoito de polvilho', 3, '2023-05-15');

-- Inserindo ingredientes
INSERT INTO ingredientes (id, nome) VALUES 
(1, 'Farinha de trigo'),
(2, 'Água'),
(3, 'Sal'),
(4, 'Fermento'),
(5, 'Cenoura'),
(6, 'Açúcar'),
(7, 'Ovo'),
(8, 'Leite'),
(9, 'Chocolate em pó'),
(10, 'Ingrediente secreto');

-- Inserindo relação entre produtos e ingredientes utilizados
INSERT INTO ingredientes_produtos (id_produto, id_ingrediente, qtd_utilizada) VALUES
(1, 1, 1),
(1, 2, 0.6),
(1, 3, 0.02),
(1, 4, 0.002),
(2, 1, 0.5),
(2, 2, 0.3),
(2, 3, 0.01),
(2, 4, 0.001),
(2, 5, 0.4),
(2, 6, 0.2),
(2, 7, 2),
(2, 8, 0.5),
(3, 1, 0.3),
(3, 2, 0.2),
(3, 3, 0.01),
(3, 4, 0.001),
(3, 6, 0.3),
(3, 7, 1),
(3, 8, 0.4),
(3, 9, 0.1);

-- Inserindo estoque
INSERT INTO estoque (id, quantidade, id_ingredientes) VALUES
(1, 100, 1),
(2, 50, 2),
(3, 1, 3),
(4, 0.5, 4),
(5, 20, 5),
(6, 5, 6),
(7, 50, 7),
(8, 10, 8),
(9, 2, 9);

-- Inserindo produção
INSERT INTO producao (id, qtd_produzida, data_producao, id_produto) VALUES 
(1, 100, '2023-05-05', 1),
(2, 10, '2023-05-06', 2),
(3, 50, '2023-05-06', 3),
(4, 60, '2023-05-08', 3),
(5, 12, '2023-02-08', 2);
-- (6, 100, '2023-02-22', 1);


-- ----------------------------------------------------------------------------------------------------------------------------------------------


-- ////////////////////// 5) Scripts de consulta  \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


-- a) Exibir quantos produtos há para cada categoria; 

select c.nome as categorias, count(id_categoria) as qtd_produtos
from categorias c
	inner join produtos p
		on c.id = p.id_categoria
group by c.id;

-- b) Exibir todos os produtos, quais ingredientes e em que quantidade são utilizados para produzi-lo; 

select p.nome as produto, i.nome as ingrediente, ip.qtd_utilizada 
from produtos p
	inner join ingredientes_produtos ip
		on p.id = ip.id_produto
	inner join ingredientes i
		on i.id = ip.id_ingrediente;


-- c) Exibir qual a quantidade produzida de cada produto dos últimos 30 dias; 

select p.nome as produto, sum(qtd_produzida) as qtd_produzida_ultimos_30_dias
from producao pd
	inner join produtos p
		on p.id = pd.id_produto
where pd.data_producao >= date_sub(current_date(), interval 30 day)
group by p.id;

-- d) Se for dobrada a produção para o próximo mês, quanto de ingrediente será  necessário.

select i.nome as ingrediente, sum((pd.qtd_produzida * ip.qtd_utilizada)* 2) as qtd_em_dobro_necessaria_prox_mes
from ingredientes_produtos ip
	inner join produtos p
		on p.id = ip.id_produto
	inner join ingredientes i
		on i.id = ip.id_ingrediente
	inner join producao pd
		on p.id = pd.id_produto
where pd.data_producao >= date_sub(current_date(), interval 30 day)
group by i.id;

-- e) Mostrar os ingredientes que nunca foram utilizados; 

select i.nome as ingrediente_nunca_utilizado
from ingredientes i
	left join ingredientes_produtos ip
		on i.id = ip.id_ingrediente
where ip.id_produto is null

/* f) Crie uma trigger para garantir o controle de estoque dos produtos fabricados. 
Quando um produto for fabricado deve dar saída dos estoque dos ingredientes utilizados. 
Caso ocorra o estorno da fabricação, manter o estoque dos ingredientes atualizado também;*/

DELIMITER $$
create trigger trg_fabricar_produto_atualiza_qtd_ingredientes after insert on producao
	for each row
begin
	-- Atualiza o estoque de ingredientes utilizados na produção
    update ingredientes i
    inner join ingredientes_produtos ip on i.id = ip.id_ingrediente
    inner join estoque e on i.id = e.id_ingredientes
    set e.quantidade = e.quantidade - (NEW.qtd_produzida * ip.qtd_utilizada)
    where ip.id_produto = NEW.id_produto;
end $$
DELIMITER ;


--  ////////////////////TRIGGER PARA DELETE:\\\\\\\\\\\\\\\\\\\\\\\\\

DELIMITER $$
create trigger trg_estornar_produto_atualiza_qtd_ingredientes after delete on producao
	for each row
begin

    -- Atualiza a quantidade de estoque dos ingredientes utilizados na fabricação
    update ingredientes i 
    inner join ingredientes_produtos ip on i.id = ip.id_ingrediente
    inner join estoque e on i.id = e.id_ingredientes
    set e.quantidade = e.quantidade + (ip.qtd_utilizada * OLD.qtd_produzida)
    where ip.id_produto = OLD.id_produto;
		
end $$
DELIMITER ;


-- g) Utilizando controle de transações, atualize as receitas para reduzir em 10% a  quantidade de fermento utilizada; 

START TRANSACTION;

update ingredientes_produtos
set qtd_utilizada = qtd_utilizada * 0.9
where id_ingrediente = (select id from ingredientes where nome = 'fermento');

-- h) Confirme a transação do exercício anterior;
COMMIT;


-- i) Utilizando controle de transações, exclua todos os registros de produção do  último mês; 

START TRANSACTION;

delete from producao
where data_producao >= date_sub(current_date(), interval 30 day);


-- j)Desfaça a transação realizada no exercício anterior;
rollback;























