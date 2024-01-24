create database TDE_aula_4;

use TDE_aula_4;

create table clientes(
id int auto_increment primary key,
nome varchar(100) not null
);

create table livros(
id int auto_increment primary key,
titulo varchar(200) not null,
valor_unit double not null
);


create table autores(
id int auto_increment primary key,
nome varchar(100) not null
);

create table autores_livros(
id_autor int not null,
id_livro int not null,
constraint fk_autores_autores_livros
    foreign key (id_autor) references autores(id)
		on delete restrict
        on update cascade,
constraint fk_livros_autores_livros
    foreign key (id_livro) references livros(id)
		on delete restrict
        on update cascade
);

create table vendas(
id int auto_increment primary key,
data_venda date not null,
id_cliente int not null,
constraint fk_vendas_clientes
    foreign key (id_cliente) references clientes(id)
		on delete restrict
        on update cascade
);

create table vendas_livros(
id int auto_increment primary key,
qtd int not null,
valor_unit double not null,
id_livro int not null,
constraint fk_vendas_livros_livros
    foreign key (id_livro) references livros(id)
		on delete restrict
        on update cascade
);



-- Populando a tabela "clientes"
INSERT INTO clientes(nome)
VALUES ('João da Silva'), ('Maria Souza'), ('Pedro Henrique'), ('Ana Paula');

-- Populando a tabela "livros"
INSERT INTO livros(titulo, valor_unit)
VALUES ('A Revolução dos Bichos', 29.90),
('1984', 34.90),
('Dom Casmurro', 19.90),
('O Cortiço', 25.90),
('Vidas Secas', 22.90),
('Memórias Póstumas de Brás Cubas', 28.90),
('O Guarani', 15.90),
('Livro nunca vendido', 1.99);

-- Populando a tabela "autores"
INSERT INTO autores(nome)
VALUES ('George Orwell'), ('Machado de Assis'), ('Aluísio Azevedo'), ('Graciliano Ramos'), ('autor que nunca vendeu');

-- Populando a tabela "autores_livros"
INSERT INTO autores_livros(id_autor, id_livro)
VALUES (1, 1), (1, 2), (2, 3), (3, 4), (3, 5), (2, 6), (4, 7), (5,8);

-- Populando a tabela "vendas"
INSERT INTO vendas(data_venda, id_cliente)
VALUES ('2022-03-28', 1), ('2022-03-29', 2), ('2022-03-29', 3), ('2022-03-30', 4);

-- Populando a tabela "vendas_livros"
INSERT INTO vendas_livros(qtd, valor_unit, id_livro)
VALUES (2, 29.90, 1), (1, 34.90, 2), (1, 19.90, 3), (3, 25.90, 4), (2, 22.90, 5), (1, 28.90, 6), (3, 15.90, 7), (2, 29.90, 1);


/*Crie uma view chamada "livros_mais_vendidos" que exiba o título, autor, preço e a quantidade de vezes que cada livro foi vendido.*/
create view livros_mais_vendidos as
select l.titulo as titulo_livro, a.nome as nome_autor, l.valor_unit as preco_livro, sum(vl.qtd) as qtd_vendas_livros
from autores a
	inner join autores_livros al
		on a.id = al.id_autor
	inner join livros l
		on l.id = al.id_livro
	inner join vendas_livros vl
		on l.id = vl.id_livro
group by l.titulo
order by qtd_vendas_livros desc;



/*Crie uma view que lista os autores que nunca venderam livros.*/
create view autores_sem_venda as
select a.nome as autor
from autores a
	left join autores_livros al
		on a.id = al.id_autor
	left join vendas_livros vl
		on al.id_livro = vl.id_livro
where vl.id_livro is null;

/*Use a sua criatividade e crie uma view que se aplique nessa modelagem.*/
-- Listar os 3 autores que fizeram mais vendas

create view autores_mais_vendas as
select a.nome as autor, sum(vl.valor_unit * vl.qtd) as valor_total
from autores a
	inner join autores_livros al
		on a.id = al.id_autor
	inner join vendas_livros vl
		on al.id_livro = vl.id_livro
group by a.nome
order by valor_total DESC
limit 3


