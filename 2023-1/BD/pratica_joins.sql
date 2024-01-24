create database loja;
use loja;


create table categorias(
id int auto_increment primary key,
nome varchar(100) not null
);

create table vendedores(
id int auto_increment primary key,
nome varchar(100) not null
);

create table produtos(
id int auto_increment primary key,
nome varchar(100) not null,
preco double not null,
id_categoria int not null,
constraint produtos_tem_categorias
foreign key(id_categoria) references categorias(id)
	on delete restrict
    on update cascade
);

create table vendas_produtos(
id_produtos int not null,
id_vendas int not null
);

create table vendas(
id int auto_increment primary key,
data_venda date not null,
qtd_venda int not null,
id_vendedor int not null,
constraint vendas_tem_vendedores
foreign key(id_vendedor) references vendedores(id)
	on delete restrict
    on update cascade
);



insert into categorias(id, nome) values 
(1, "limpeza"),
(2, "ferramentas"),
(3, "roupas"),
(4, "brinquedos"),
(5, "eletronicos"),
(6, "automovel");

insert into vendedores(id, nome) values
(1, "Carlos"),
(2, "João"),
(3, "Carol"),
(4, "José"),
(5, "Marta"),
(6, "Paulo");

insert into produtos(id, nome, preco, id_categoria) values
(1, "Celular", 1000.00, 5),
(2, "Desinfetante", 10.00, 1),
(3, "martelo", 15.00, 2),
(4, "camiseta", 30.00, 3),
(5, "boneca", 20.00, 4);


insert into vendas(id, data_venda, qtd_venda, id_vendedor) values 
(1, '2023-03-23', 1, 5),
(2, '2023-02-11', 3, 3),
(3, '2022-12-30', 2, 1),
(4, '2023-01-07', 5, 4),
(5, '2023-03-21', 4, 2),
(6, '2023-03-03', 6, 3);


insert into vendas_produtos(id_produtos, id_vendas) values
(1,1),
(4,3),
(5,2),
(3,4),
(2,5),
(4,6);
-----------------------------------------------------------------------------

/*(SQL 1 - Utilizando INNER JOIN, GROUP BY e HAVING) Mostrar os vendedores que venderam os produtos mais caros que R$20 no mês de março de 2023*/
select vd.nome as nome_vendedor, p.nome as produto, p.preco as preco_produto, v.data_venda
from produtos p
		inner join vendas_produtos vp
			on p.id = vp.id_produtos
		inner join vendas v
			on  v.id = vp.id_vendas
		inner join vendedores vd
			on vd.id = v.id_vendedor
group by vd.nome, p.nome, p.preco, v.data_venda         
having p.preco > 20.00 and v.data_venda > '2023-03-00'and v.data_venda < '2023-03-31';


/*(SQL 2 - Utilizando o LEFT JOIN) Selecionar todos os vendedores e sua quantidade de vendas, incluindo aqueles que não têm vendas.*/

select vd.nome as vendedor, v.qtd_venda
from vendedores vd
	left join vendas v
		on vd.id = v.id_vendedor;
        
/*(SQL 3 - Utilizando o RIGHT JOIN ) Selecionar todas as categorias e os produtos, incluindo aqueles que não tem produtos vinculados.*/        
select c.nome as categoria, p.nome as produtos
from produtos p
	right join categorias c
		on p.id_categoria = c.id
        
