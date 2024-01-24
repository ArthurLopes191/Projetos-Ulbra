create database TDE_StoredProcedure;

use TDE_StoredProcedure;

create table clientes(
id int auto_increment primary key,
nome varchar(100) not null,
CPF varchar(11) unique
);

create table editoras(
id int auto_increment primary key,
nome varchar(100) not null
);

create table livros(
id int auto_increment primary key,
titulo varchar(200) not null,
valor_unit double not null,
data_publicacao date not null,
id_editora int not null,
constraint fk_livros_tem_editoras
    foreign key (id_editora) references editoras(id)
		on delete restrict
        on update cascade
);


create table autores(
id int auto_increment primary key,
nome varchar(100) not null,
CPF varchar(11) unique
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
INSERT INTO clientes(nome, cpf)
VALUES ('João da Silva', '11111111111'), ('Maria Souza', '22222222222'), ('Pedro Henrique', '33333333333'), ('Ana Paula', '55555555555');


INSERT INTO editoras (nome) VALUES
('Editora A'),
('Editora B'),
('Editora C'),
('Editora D'),
('Editora E');

-- Populando a tabela "livros"
INSERT INTO livros(titulo, valor_unit, data_publicacao, id_editora )
VALUES ('A Revolução dos Bichos', 29.90, '2022-01-01', 1 ),
('1984', 34.90, '2021-05-01', 2),
('Dom Casmurro', 19.90, '2020-12-15', 3),
('O Cortiço', 25.90, '2019-07-10', 4),
('Vidas Secas', 22.90, '2018-03-22', 5),
('Memórias Póstumas de Brás Cubas', 28.90, '2022-02-28', 1),
('O Guarani', 15.90, '2021-09-05', 2),
('Livro nunca vendido', 1.99, '2020-08-23', 3);

-- Populando a tabela "autores"
INSERT INTO autores(nome, cpf)
VALUES ('George Orwell', '55555555555'), ('Machado de Assis', '44444444444'), ('Aluísio Azevedo', '33333333333'), ('Graciliano Ramos', '22222222222'), ('autor que nunca vendeu', '11111111111');

-- Populando a tabela "autores_livros"
INSERT INTO autores_livros(id_autor, id_livro)
VALUES (1, 1), (1, 2), (2, 3), (3, 4), (3, 5), (2, 6), (4, 7), (5,8);

-- Populando a tabela "vendas"
INSERT INTO vendas(data_venda, id_cliente)
VALUES ('2022-03-28', 1), ('2022-03-29', 2), ('2022-03-29', 3), ('2022-03-30', 4);

-- Populando a tabela "vendas_livros"
INSERT INTO vendas_livros(qtd, valor_unit, id_livro)
VALUES (2, 29.90, 1), (1, 34.90, 2), (1, 19.90, 3), (3, 25.90, 4), (2, 22.90, 5), (1, 28.90, 6), (3, 15.90, 7), (2, 29.90, 1);


-- Ex STORED PROCEDURES --------------------------------------------------------------------

/*Escreva uma SP que receba, como parâmetro, o CPF de um autor e retorne a quantidade de livros escrito pelo mesmo.*/
DELIMITER $$
create procedure qtd_livros_por_cpf_autor(p_cpf varchar(11))
BEGIN
    select a.nome as autor, a.cpf as cpf_autor, count(l.titulo) as quantidade_livros_do_autor
    from autores a
		inner join autores_livros al
			on a.id = al.id_autor
		inner join livros l
			on l.id = al.id_livro
	where a.cpf = p_cpf
    group by a.nome;
END $$
DELIMITER ;

call qtd_livros_por_cpf_autor('44444444444');

/*Crie uma SP que receba, como parâmetro, a data de publicação de um livro e seu código. 
O procedimento deve atualizar a tabela de livros, especificando a data de lançamento para o livro em questão.*/

DELIMITER $$
create procedure alterar_data_livro(p_data_publicacao date, p_id int)
BEGIN
declare livro_existe int;

	select count(*) into livro_existe 
    from livros 
    where p_id = id;
    
    if livro_existe > 0 then
		update livros
		set data_publicacao = p_data_publicacao
		where p_id = id;
    else 
		select concat('Livro com id ', p_id, ' não foi encontrado') as aviso;
	end if;
END $$
DELIMITER ;

call alterar_data_livro('1800-01-15', 3);


/*Em algumas situações, SPs são utilizados para a manutenção da segurança do banco de dados. 
Nestes casos, realizamos inclusões, alterações e exclusões de dados, através de SPs. 
Crie SPs que recebem os parâmetros adequados e realizam as seguintes operações:*/

-- a) Inserir uma linha na tabela de livros
DELIMITER $$
create procedure inserir_tupla_livros(p_titulo varchar(200), p_valor_unit double, p_data_publicacao date, p_id_editora int)
begin
	insert into livros(titulo, valor_unit, data_publicacao, id_editora) values
    (p_titulo, p_valor_unit, p_data_publicacao, p_id_editora);
end $$
DELIMITER ;

call inserir_tupla_livros("Livro teste 3", 100.00, '1500-10-05', 3);

-- b) Excluir uma linha da tabela de livros

DELIMITER $$
create procedure excluir_tupla_livros(p_id int)
begin
declare livro_existe int;

	select count(*) into livro_existe 
    from livros 
    where p_id = id;
    
    if livro_existe > 0 then
		delete from livros
		where id = p_id;
    else 
		select concat('Livro com id ', p_id, ' não foi encontrado') as aviso;
	end if;
end $$
DELIMITER ;

call excluir_tupla_livros(15);

-- c) Atualizar valores na tabela de livros

DELIMITER $$
create procedure atualizar_tupla_livros(p_id int, p_titulo varchar(200), p_valor_unit double, p_data_publicacao date, p_id_editora int)
begin
declare livro_existe int;

	select count(*) into livro_existe 
    from livros 
    where p_id = id;
    
    if livro_existe > 0 then
		update livros
		set titulo = p_titulo, valor_unit = p_valor_unit, data_publicacao = p_data_publicacao, id_editora = p_id_editora
		where id = p_id;
    else 
		select concat('Livro com id ', p_id, ' não foi encontrado') as aviso;
	end if;
end $$
DELIMITER ;

call atualizar_tupla_livros(14, "livro teste atualizado master", 35.00, '2010-05-22', 5);

/*Crie uma SP que aumente ou diminua o valor dos preços dos livros de uma editora específica. 
O aumento pode ser em percentual ou em valor.*/


-- aumento em valor:

DELIMITER $$
create procedure alterar_valor_livro(p_id_editora int, p_valor_unit double)
begin
	update livros
    set valor_unit = valor_unit + p_valor_unit
    where id_editora = p_id_editora;
end $$
DELIMITER ;

call alterar_valor_livro(1, 10.00);

 -- aumento em percentual:
 
DELIMITER $$
create procedure alterar_valor_livro_percentual(p_id_editora int, p_percentual int)
begin
	update livros
    set valor_unit = valor_unit + (valor_unit * (p_percentual / 100))
    where id_editora = p_id_editora;
end $$
DELIMITER ;

call alterar_valor_livro_percentual(3, 10);