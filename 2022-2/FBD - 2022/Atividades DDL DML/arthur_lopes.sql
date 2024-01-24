/*Conforme modelo ER abaixo, cria um Database no MySQL ou de sua escolha.*/
create database livraria;

create table assuntos (
id_assunto char(1) not null primary key,
descricao varchar(40) not null
);

create table editoras(
id_editora int not null primary key,
nome varchar(40) not null
);

create table autores(
matricula int not null primary key,
nome varchar(40) not null,
cpf varchar(11) not null unique,
endereco varchar(50) not null,
data_nascimento date not null,
nacionalidade varchar(30) not null
);


create table livros(
id int not null primary key,
titulo varchar(80) not null,
preco double not null,
lancamento date,
id_assunto char(1) not null,
id_editora int not null,
constraint fk_livro_possui_assunto
foreign key(id_assunto) references assuntos(id_assunto),
constraint fk_livro_possui_editora
foreign key(id_editora) references editoras(id_editora)
on delete restrict
on update cascade
);

create table autores_livros(
matricula int not null,
id_livro int not null,
constraint fk_autores_tem_matriculas
foreign key(matricula) references autores(matricula),
constraint fk_autores_tem_livros
foreign key(id_livro) references livros(id)
on delete restrict
on update cascade
);


/*EX2 - Monte comandos de inclusão das tabelas do Banco de dados Criado de acordo com os dados das tabelas abaixo:*/ 
insert into editoras(id_editora, nome) values (1, "MIRANDELA EDITORA");
insert into editoras(id_editora, nome) values (2, "EDITORA VIA-NORTE");
insert into editoras(id_editora, nome) values (3, "EDITORA ILHAS TIJUCAS");
insert into editoras(id_editora, nome) values (4, "MARIA JOSÉ EDITORA");

insert into assuntos(id_assunto, descricao) values ("B", "BANCO DE DADOS");
insert into assuntos(id_assunto, descricao) values ("P", "PROGRAMACAO");
insert into assuntos(id_assunto, descricao) values ("R", "REDES");
insert into assuntos(id_assunto, descricao) values ("S", "SISTEMAS OPERACIONAIS");




insert into autores_livros(matricula, id_livro) values 
 (1, 1),
 (2, 2),
 (1, 1),
 (3, 3),
 (4, 4);

insert into livros(id, titulo, preco, lancamento, id_assunto, id_editora) values (1, "BANCOS DE DADOS PARA A WEB", 31.20, '1999-01-10', "B", 1 );
insert into livros(id, titulo, preco, lancamento, id_assunto, id_editora) values (2, "PROGRAMANDO EM LINGUAGEM C", 30.00, '1997-10-01', "P", 1 );
insert into livros(id, titulo, preco, lancamento, id_assunto, id_editora) values (3, "PROGRAMANDO EM LINGUAGEM C++", 111.50, '1998-11-01', "P", 3 );
insert into livros(id, titulo, preco, lancamento, id_assunto, id_editora) values (4, "BANCOS DE DADOS NA BIOMEDICINA", 48.00, '0000-00-00', "B", 2 );
insert into livros(id, titulo, preco, lancamento, id_assunto, id_editora) values (5, "BANCOS DE DADOS PARA A WEB", 42.00, '1996-09-01', "R", 2 );


/*Crie comandos SQLs que retorne os dados solicitados abaixo:

Monte um comando para excluir da tabela livros aqueles que possuem o código maior ou igual a 2, que possuem o preço maior que R$ 50,00 e que já foram lançados.
*/

delete from livros
where id >= 2 and preco > 50.00 and lancamento < current_date;


/*Escreva o comando que seleciona as colunas NOME, CPF e ENDERECO, da tabela AUTOR, para aqueles que possuem a palavra ‘joão’ no nome. */

select nome, cpf, endereco 
from autores
where nome like '%joão%';


/*Excluir o livro cujo título é ‘BANCO DE DADOS DISTRIBUÍDO’ ou ‘BANCOS DE DADOS DISTRIBUÍDOS’. Somente essas duas opções devem ser consideradas.*/

delete from livros
where titulo like 'BANCO_ DE DADO_ DISTRUBUÍDO_';

/*Selecione o nome e o CPF de todos os autores que nasceram após 01 de janeiro de 1990.*/

select nome, cpf
from autores
where data_nascimento > '1990-01-01';

/*Selecione a matrícula e o nome dos autores que possuem RIO DE JANEIRO no seu endereço.*/
select matricula, nome
from autores
where endereco  like '%RIO DE JANEIRO%';


/*Atualize para zero o preço de todos os livros onde a data de lançamento for nula ou onde seu preço atual for inferior a R$ 55,0*/

update livros
set preco = 00.00
where lancamento is null or preco < 55.00;

/*Exclua todos os livros onde o assunto for diferente de ‘S’, ‘P’, ou ‘B’.*/

delete from livros 
where id_assunto <> 'S' and id_assunto <> 'P'  and id_assunto <> 'B' ;

/*Escreva o comando para contar quantos são os autores cadastrados na tabela AUTORES.*/
select count(matricula) as quantos
from autores;

/*Escreva o comando que apresenta qual o número médio de autores de cada livro. Você deve utilizar, novamente, a tabela AUTOR_LIVRO. 
*/
select avg(id_livros) as media
from autor_livros;

/*Escreva o comando que apresenta qual o número médio de autores de cada livro. Você deve utilizar, novamente, a tabela AUTOR_LIVRO. */
select avg(quantos) from (
	select livro_id, count(autor_id) as quantos
	from autores_livros
	group by livro_id
) as minhaTabela;

/*Apresente o comando SQL para gerar uma listagem dos códigos dos livros que possuem a menos dois autores.*/

select livro_id, count(autor_id) as quantos
from autores_livros
group by livro_id
having quantos >= 2;


/*Escreva o comando para apresentar o preço médio dos livros por código de editora. Considere somente aqueles que custam mais de R$ 45,00.*/
select id_editora, avg(preco) as preco_medio
from livros
where preco > 45.00
group by id_editora;

/*Apresente o preço máximo, o preço mínimo e o preço médio dos livros cujos assuntos são ‘S’ ou ‘P’ ou ‘B’, para cada código de editora.*/

select id_editora, max(preco) as preco_maximo, min(preco) as preco_minimo, avg(preco) as preco_medio
from livros
where assunto in ('P', 'B', 'S');
group by editora_id;

/*Altere o comando do exercício anterior para só considerar os livros que já foram lançados (data de lançamento inferior a data atual) e cujo o preço máximo é inferior a R$ 100,00.*/

select id_editora, max(preco) as preco_maximo, min(preco) as preco_minimo, avg(preco) as preco_medio
from livros
where lancamento < current_date
group by editora_id preco_maximo < 100;





/*UTILIZANDO O JOINS*/



/*Estão sendo estudados aumentos nos preços dos livros. Escreva o comando SQL que retorna uma listagem contendo o titulo dos livros, e mais três colunas: uma contendo os preços dos livros acrescidos de 10% (deve ser chamada de ‘Opção_1’), a segunda contendo os preços acrescidos de 15% (deve ser chamada de ‘Opção_2’) e a terceira contendo os preços dos livros acrescidos de 20% (deve ser chamada de ‘Opção_3’). Somente devem ser considerados livros que já tenham sido lançados.
*/

select titulo, preco*1.10 as opcao1, preco*1.15 as opcao2, (preco*1.2 as opcao3
from livros
where lancamento < current_date; 

/*Escreva o comando SQL que apresenta uma listagem contendo o código da editora, o nome da editora, a sigla do assunto e o titulo dos livros que já foram lançados. Os dados devem estar em ordem decrescente de preço, e ascendente de código da editora e de título do livro.*/
select e.id, e.nome, l.assunto_id, l.titulo
from livros l
	inner join editoras e
		on l.editora_id = e.id
where l.lancamento <= current__date
order by l.preco desc, e.id asc, l.titulo asc;

/*Escreva o comando que apresente uma listagem dos nomes dos autores e do seu ano e mês de nascimento, para os autores brasileiros e que tem livros ainda não lançados. A listagem deve estar ordenada em ordem crescente de nome.
select a.nome, a.data_nascimento */

select distinct a.nome, MONTH(a.data_nascimento) as mes, year(a.data_nasc) as ano
from autores a
	inner join autores_livros al
		on al.matricula = a.matricula
	inner join livros l
		on l.id_livro = al.id_livro
where l.data_lancamento >= current_date or l.data_lancamento is null

/*Escreva o comando que retorna o nome dos autores e o título dos livros de sua autoria. A listagem deve estar ordenada pelo nome do autor, mostrar somente os livros já lançados.*/

select a.nome, l.titulo
from autores a
	inner join autores_livros al
		on al.matricula = a.matricula
	inner join livros l
		on l.id_livro = al.id_livro
where l.data_lancamento >= current_date or l.data_lancamento is not null
order by a.nome
/*Monte a consulta SQL que retorna as editoras que publicaram livros escritos pela autora 'Ana da Silva'*/

select e.nome, l.titulo
from autores a
	inner join autores_livros al
		on al.matricula = a.matricula
	inner join livros l
		on l.id_livro = al.id_livro
	inner join editoras e on e.id = l.editora_id
where a.nome like '%ricardo%' and l.lancamento <= current_date;


/*FUS (faça um SQL) que apresente o título do livro e o nome da editora que o publica para todos os livros que custam menos que 50 reais.*/
from autores a
	inner join autores_livros al
		on al.matricula = a.matricula
	inner join livros l
		on l.id_livro = al.id_livro
	inner join editoras e 
		on e.id = l.editora_id
where l.preco < 50 and l.lancamento <= current_date;

/*FUS que apresente o CPF, nome do autor e o preço máximo dos livros de sua autoria. Apresente somente as informações para os autores cujo preço máximo for superior a 50.*/
select a.nome, max(l.preco) as preco_max
from autores a
	inner join autores_livros al
		on al.matricula = a.matricula
	inner join livros l
		on l.id_livro = al.id_livro
where l.lancamento <= current_date;
group by a.nome
having preco_max > 50

