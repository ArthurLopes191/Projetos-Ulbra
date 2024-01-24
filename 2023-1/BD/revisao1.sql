create database empresa;

use empresa;

create table produtos(
cod_produto int primary key auto_increment,
descricao varchar(100) not null,
preco double not null,
nome_categoria varchar(50) not null,
descricao_categoria varchar(100) not null
);


create table cidades(
cod_cidade int primary key auto_increment,
nome varchar(100) not null,
uf char(2) not null
);


create table filiais(
cod_filial int primary key auto_increment,
nome varchar(100) not null,
endereco varchar(100) not null,
cod_cidade int not null,

constraint filias_tem_cidades
foreign key(cod_cidade) references cidades(cod_cidade)
	ON UPDATE cascade
    ON DELETE restrict
);

create table vendas(
cod_produto int not null,
cod_filial int not null,

constraint vendas_produtos
foreign key(cod_produto) references produtos(cod_produto)
	ON UPDATE cascade
    ON DELETE restrict,

constraint vendas_filiais
foreign key(cod_filial) references filiais(cod_filial)
	ON UPDATE cascade
    ON DELETE restrict     
);

create table empregados(
cod_emp int primary key auto_increment,
nome varchar(100) not null,
endereco varchar(100) not null,
ct char(11) not null,
cpf char(11) not null,
rg varchar(9) not null,
salario double not null,
cod_cid int not null,
cod_filial int not null,

constraint empregados_moram_em_cidades
foreign key(cod_cid) references cidades(cod_cidade)
	ON UPDATE cascade
    ON DELETE restrict,
    
constraint empregados_trabalham_em_filiais
foreign key(cod_filial) references filiais(cod_filial)
	ON UPDATE cascade
    ON DELETE restrict
);


insert into produtos(cod_produto, descricao, preco, nome_categoria, descricao_categoria) values
(1, "prato", 5.00, "utensilios", "utensilios domesticos"),
(2, "boneco", 10.00, "brinquedos", "brinquedos infantis"),
(3, "martelo", 15.00, "ferramentas", "ferramentas obra"),
(4, "caneta", 3.00, "material", "material escolar"),
(5, "chiclete", 2.00, "doces", "doces consumiveis");

insert into cidades(cod_cidade, nome, uf) values
(1, "Capao da Canoa", 'RS'),
(2, "Torres", 'RS'),
(3, "Criciuma", 'SC'),
(4, "Sao Paulo", 'SP'),
(5, "Rio de Janeiro", 'RJ');

insert into filiais(cod_filial, nome, endereco, cod_cidade) values 
(1, "f1", "Rua das gaivotas n23", 3),
(2, "f2", "Rua das latinhas n125", 5),
(3, "f3", "Rua das baratas n87", 2),
(4, "f4", "Rua das torneiras n388", 4),
(5, "f5", "Rua das lamparinas n1", 1);

insert into vendas(cod_produto, cod_filial) values
(5, 3), (2, 1), (3, 5), (4, 5), (5, 3), (1, 2), (1, 1), (2, 2), (3, 3), (2, 2), (5, 1); 

insert into empregados(cod_emp, nome, endereco, ct, rg, cpf, salario, cod_cid, cod_filial) values
(1, "Joao", "Rua das marmotas n34", 12931289311, 111111111 , 12345678901, 400, 4, 1),
(2, "Paulo", "Rua das andorinhas n111", 09826573582, 22222222, 03166627898, 1000, 1, 3),
(3, "Mateus", "Rua das laranjas n90", 12399096524, 33333333, 10232356810, 1500, 3, 4),
(4, "Felipe", "Rua das idosas n21", 10936785283, 444444444, 05267435728, 200, 2, 5),
(5, "Gabriel", "Rua dos larapios n76", 10429890362, 555555555, 10454526738, 1500, 5, 2);

update empregados
set salario = 200
where cod_emp = 4;


/*Listar o valor do produto mais caro.*/
select descricao as produto, preco as preco_mais_alto
from produtos
order by preco desc
limit 1;

/*Obter a média dos preços dos produtos*/
select avg(preco)
from produtos;


/*Listar o nome dos produtos vendidos pela filial “f3”. (joins)*/
select v.cod_filial, f.nome, p.descricao
from vendas v
	inner join filiais f
		on v.cod_filial = f.cod_filial
    inner join produtos p
		on v.cod_produto = p.cod_produto
where f.nome = 'f3';


/*Listar os nomes e números de RG dos funcionários que moram no Rio Grande do Sul e tem salário superior a R$ 500,00. (joins)*/
select e.nome, e.cpf, e.salario, c.uf
from empregados e
	inner join cidades c
		on e.cod_cid = c.cod_cidade
where salario > 500 and c.uf like '%RS%';


/*----------------------------------------------------------------------------------------------------------------------------------------------------------*/









create database livraria;

use livraria;

create table cidades(
cod_cidade int primary key auto_increment,
nome varchar(100) not null,
uf char(2) not null
);

create table categorias(
cod_categoria int primary key auto_increment,
nome varchar(100) not null,
descricao varchar(100) not null
);

create table clientes(
cod_cliente int primary key auto_increment,
nome varchar(100) not null,
endereco varchar(100) not null,
cod_cidade int not null,
	constraint cliente_mora_em_cidade
    foreign key(cod_cidade) references cidades(cod_cidade) 
	on delete restrict
    on update cascade
);

create table autores(
cod_autor int primary key auto_increment,
nome varchar(100) not null, 
cod_cidade int not null,
	constraint autor_mora_em_cidade
    foreign key(cod_cidade) references cidades(cod_cidade) 
	on delete restrict
    on update cascade
);

create table livros(
cod_livro int primary key auto_increment,
titulo varchar(100) not null,
nfolhas int not null, 
editora varchar(100) not null,
valor double not null,
cod_categoria int not null,
cod_autor int not null,
	constraint livros_possuem_categoria
    foreign key(cod_categoria) references categorias(cod_categoria)
		on update cascade
		on delete cascade,
	constraint livros_possuem_autores
    foreign key(cod_autor) references autores(cod_autor)
		on update cascade
        on delete restrict
);

create table vendas(
quantidade int not null,
data_venda date not null,
cod_livro int not null,
cod_cliente int not null,
	constraint vendas_dos_livros
    foreign key(cod_livro) references livros(cod_livro)
		on update restrict
        on delete cascade,
	constraint venda_para_cliente
    foreign key(cod_cliente) references clientes(cod_cliente)
		on update restrict
        on delete cascade
);


insert into cidades(cod_cidade, nome, uf) values
(1, "Capao da Canoa", 'RS'),
(2, "Torres", 'RS'),
(3, "Criciuma", 'SC'),
(4, "Sao Paulo", 'SP'),
(5, "Rio de Janeiro", 'RJ');

insert into categorias(cod_categoria, nome, descricao) values
(1, "romance", "lorem ipsum dollor siamet lorem ipsum dollor siamet" ),
(2, "ficcao", "lorem ipsum dollor siamet lorem ipsum dollor siamet" ),
(3, "poesia", "lorem ipsum dollor siamet lorem ipsum dollor siamet" ),
(4, "auto-ajuda", "lorem ipsum dollor siamet lorem ipsum dollor siamet" ),
(5, "filosofia", "lorem ipsum dollor siamet lorem ipsum dollor siamet" );

insert into clientes(cod_cliente, nome, endereco, cod_cidade) values
(1, "Joao", "Rua das Marmotas", 2),
(2, "Marcos", "Rua das Sacolas", 3),
(3, "Levi", "Rua das Taquaras", 1),
(4, "Jose", "Rua das Geladeiras", 4),
(5, "Lauro", "Rua das Lindezas", 5);

insert into autores(cod_autor, nome, cod_cidade) values
(1, "Machado de Assis", 2),
(2, "George Owell", 1),
(3, "Napoleon Hill", 4),
(4, "Shakespeare", 5),
(5, "J K Rowling", 3);


insert into livros(cod_livro, titulo, nfolhas, editora, valor, cod_categoria, cod_autor) values
(1, "Harry Potter", 300, "e1", 50, 2, 5),
(2, "Quem pensa enriquece", 250, "e2", 30, 4, 3),
(3, "1984", 400, "e3", 60, 2, 2),
(4, "Dom Casmurro", 350, "e4", 55, 1, 1),
(5, "hamlet", 500, "e5", 70, 1, 4);

update livros
set cod_autor = 4
where cod_livro = 5;

insert into vendas(quantidade, data_venda, cod_livro, cod_cliente) values 
(3, '2023-01-01', 3, 1),
(2, '2022-11-12', 4, 5),
(1, '2023-02-04', 5, 2),
(2, '2022-05-22', 2, 3),
(3, '2023-01-15', 1, 4),
(3, '2022-08-30', 1, 4),
(3, '2023-01-15', 1, 3),
(1, '2023-01-20', 2, 2),
(2, '2023-01-30', 3, 1),
(5, '2023-01-30', 4, 1),
(5, '2023-01-10', 2, 2),
(5, '2023-01-10', 2, 1);


/*Mostrar o número total de vendas realizadas.*/
select count(quantidade) as total
from vendas;



/*Listar os títulos e valores dos livros da categoria “banco de Dados’. Mostra também o nome da categoria. */
select l.titulo, l.valor, c.nome
from livros l
	inner join categorias c
		on l.cod_categoria = c.cod_categoria
where c.nome like '%romance%';

/*Listar os  títulos e nome dos autores dos livros que custam mais que R$ 300,00.Listar os nomes dos clientes juntamente com o nome da cidade onde moram e UF.*/
select l.titulo as titulo_livro, a.nome as nome_autor, l.valor as valor_livro, c.nome as nome_cliente, ci.nome as cidade_cliente, ci.uf
from vendas v
	inner join livros l
		on v.cod_livro = l.cod_livro
	inner join clientes c
		on v.cod_cliente = c.cod_cliente
    left outer join autores a
		on a.cod_autor = l.cod_autor
	left outer join cidades ci
		on ci.cod_cidade = c.cod_cidade
where l.valor > 300;


/*Listar os nomes dos clientes juntamente com os nomes de todos os livros comprados por ele.*/

select c.nome as nome_cliente, l.titulo as titulo_livro
from vendas v
	inner join clientes c
		on v.cod_cliente = c.cod_cliente
	inner join livros l
		on v.cod_livro = l.cod_livro;
        
/*Listar o código do livro, o titulo, o nome do autor, dos livros que foram vendidos no mês de março de 2021. (join)*/	
	
select v.cod_livro, v.data_venda, l.titulo, a.nome
from vendas v
	inner join livros l
		on v.cod_livro = l.cod_livro
	inner join autores a
		on l.cod_autor = a.cod_autor
where v.data_venda > '2021-03-00'and v.data_venda < '2021-03-31';


/*Listar o título e o autor dos 5 livros mais vendidos do mês de janeiro.*/

select l.titulo, a.nome as autor, SUM(v.quantidade) as total_vendas
from livros l
	inner join vendas v 
		on l.cod_livro = v.cod_livro
	inner join autores a 
		on l.cod_autor = a.cod_autor
where v.data_venda >= '2023-01-00'and v.data_venda <= '2023-01-31'
group by l.titulo, a.nome
order by total_vendas DESC
LIMIT 5;



/*Mostrar o nome do cliente que comprou o livro com o título ‘Banco de dados powerful’).
*/
select distinct c.nome as nome_cliente, l.titulo as nome_livro
from vendas v
	inner join clientes c
		on c.cod_cliente = v.cod_cliente
    inner join livros l
		on v.cod_livro = l.cod_livro
where l.titulo like '%Banco de dados powerful%'

		