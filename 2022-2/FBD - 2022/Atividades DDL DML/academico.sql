create database academico;

use academico;


create table curso (
idcurso int not null auto_increment primary key,
nome varchar (70) not null,
valor_credito float not null
);

create table cidade(
idcid int not null auto_increment primary key,
nome varchar (70) not null,
uf varchar (2) not null
);

create table aluno(
idaluno int not null auto_increment primary key,
nome varchar (70) not null,
endereco varchar(100) not null,
telefone char(12) not null unique,
idcid int not null,
constraint aluno_fk_cidade
	foreign key (idcid) references cidade(idcid)
    ON DELETE restrict
	ON UPDATE cascade
);

create table professor(
idprof int not null auto_increment primary key,
nome  varchar(70) not null,
email varchar(70),
cpf char(13) not null unique,
endereco varchar(100) not null,
idcid int not null,
constraint professor_fk_cidade
	foreign key (idcid) references cidade(idcid)
    ON DELETE restrict
	ON UPDATE cascade
);

create table turma(
idturma int not null auto_increment primary key,
sala  int not null,
capacidade int not null,
idprof int not null,
idcurso int not null,
	constraint turma_fk_professor
		foreign key (idprof) references professor(idprof)
        ON DELETE restrict
		ON UPDATE cascade,
	constraint turma_fk_curso
		foreign key (idcurso) references curso(idcurso)
        ON DELETE restrict
		ON UPDATE cascade
);

create table disciplina(
iddisc int not null auto_increment primary key,
nome varchar (50) not null
);

create table turdisc(
idturma int not null,
iddisc int not null,
	constraint turdisc_fk_turma
    foreign key (idturma) references turma(idturma)
		ON DELETE restrict
		ON UPDATE cascade,
	constraint turdisc_fk_disciplina
    foreign key (iddisc) references disciplina(iddisc)
		ON DELETE restrict
		ON UPDATE cascade
    
);

create table matricula(
idaluno int not null,
idturma int not null,
	constraint matricula_fk_aluno
    foreign key (idaluno) references aluno(idaluno)
		ON DELETE restrict
		ON UPDATE cascade,
	constraint matricula_fk_turma
    foreign key (idturma) references turma(idturma)
		ON DELETE restrict
		ON UPDATE cascade
    
);



insert into curso(idcurso, nome, valor_credito) values 
(1, "programação", 4),
(2, "design", 2),
(3, "banco de dados", 5),
(4, "medicina", 3),
(5, "direito", 1);


insert into cidade(idcid, nome, uf) values 
(1, "Capão da Canoa", "RS"),
(2, "Criciuma", "SC"),
(3, "São Paulo", "SP"),
(4, "Osório", "RS"),
(5, "Brasilia", "DF"),
(6, "Torres", "RS");

insert into aluno(idaluno, nome, endereco, telefone, idcid) values
(1, "João", "Rua Santos Dumont", 51984567893, 4),
(2, "Paulo", "Av Paraguassu", 51934567892, 1),
(3, "Tiago", "Rua Joaquim Nabuco", 54947658233, 2),
(4, "Pedro", "Rua Sepe", 51988765488, 1),
(5, "Simão", "Av Nove de Julho", 11986735890, 3),
(6, "Adalberto", "teste", 1119238129, 6);

insert into professor(idprof, nome, email, endereco, cpf, idcid) values
(1, "Cassio", "profcassio@ulbra.br", "Rua Joaquim Nabuco", 03112383892, 2),
(2, "Ramon", "proframon@ulbra.br", "Av Nove de Julho", 03456234911, 3),
(3, "Vini", "profvini@ulbra.br", "Rua Sepe", 09812345678, 1),
(4, "Lucas", "proflucas@ulbra.br", "Rua Santos Dumont", 45523478909, 4),
(5, "Paulo", "profpaulo@ulbra.br", "Rua do Brasil", 45234585903, 5);

insert into turma(idturma, idprof, sala, capacidade, idcurso) values
(1, 3, 27, 30, 2),
(2, 5, 26, 30, 1),
(3, 4, 16, 30, 4),
(4, 2, 26, 30, 3),
(5, 1, 22, 30, 5),
(6, 3, 27, 30, 2),
(7, 3, 27, 30, 2),
(8, 1, 27, 30, 2),
(9, 4, 27, 30, 2),
(10, 4, 27, 30, 2),
(11, 4, 27, 30, 2);

insert into disciplina(iddisc, nome) values
(1, "Laboratorio de Programação"),
(2, "Fundamentos de banco de dados"),
(3, "Produção Graficas"),
(4, "Direito Civil"),
(5, "Anatomia");


insert into turdisc(idturma, iddisc) values
(1, 2),
(2, 1),
(3, 4),
(4, 3),
(5, 5);

insert into matricula (idaluno, idturma) values 
(1, 3),
(2, 1),
(3, 5),
(4, 2),
(5, 4);



/*----------------------------------------------------------------------------------------------------*/
select * from curso ;

alter table professor
add endereco varchar(100) not null;

alter table aluno
rename column cpf to telefone;


/* Marque a sentença que permite listar todos os nomes dos alunos juntamente com o nome da cidade onde moram, ordenado pelo nome do aluno.
*/
select a.nome, c.nome as nome_cidade
from cidade c
	inner join aluno a
		on  a.idcid = c.idcid
order by a.nome


/*. 4 Faça um SQL que permite atualizar o valor do crédito do curso de nome “ADS” com o acréscimo de 10%. 
Mostre o SQL que consulta também, antes de atualizar os dados.*/

update curso
set valor_credito = valor_credito * (1.1)
where nome = "ads"

/*Consulta*/
select valor_credito
from  curso
where nome = "%ads"

/*5. Marque a sentença que permite listar os códigos(id) das turmas com o nome da disciplina e a sala. */

select t.idturma, d.nome as nome_diciplina, t.sala
from turma t
	inner join turdisc td
		on td.idturma = t.idturma
	inner join disciplina d
		on d.iddisc = td.iddisc
        
/* 6. o comando SQL para listar o nome do curso e valor do crédito para o curso que tem o valor mais baixo de crédito(valorcredito).*/
 
select nome, valor_credito
from curso
where valor_credito = (select min(valor_credito) from curso)

SELECT c1.nome, min(c1.valor_credito) AS curso_com_valor_mais_baixo
        FROM curso c1
        LEFT JOIN curso c2
            ON c1.idcurso = c2.idcurso
        GROUP BY c1.idcurso
        ORDER BY curso_com_valor_mais_baixo ASC
        LIMIT 1;

        
/*8. Faça um SQL para adicionar a coluna data_entrada na tabela matricula.*/   

alter table matricula
add data_entrada date not null;

/*9. Faça um SQL para selecionar os alunos que não moram na cidade onde estudam. Considerando que a cidade onde estudam é Torres. Exibir o código, o nome do aluno e a cidade onde ele mora.*/
select a.idaluno, a.nome, c.nome
from aluno a
	inner join cidade c
		on c.idcid = a.idcid
where c.nome <> "Torres";


/*10. Faça um SQL para exibir o nome do aluno, o código do curso, o nome do curso e o nome do professor da turma e a data que ele se matriculou. Apresentar somente para alunos que tenham se matriculado entre semestre 1 de 2022, considere que as matrículas iniciam em janeiro.
*/
select a.nome as aluno, c.idcurso, c.nome as nome_curso, p.nome as professor, m.data_entrada
from turma t
	inner join professor p
		on p.idprof = t.idprof
	inner join matricula m
		on t.idturma = m.idturma
	inner join aluno a
		on a.idaluno = m.idaluno
	inner join curso c
		on c.idcurso = t.idcurso
where m.data_entrada between '2022-01-01' and '2022-06-30';


/* Faça um SQL que liste os 2 professores que mais turmas já atenderam. Importante mostrar o nome do professor.*/

select p.nome, count(p.idprof) as qtd_atendimentos
from professor p
	inner join turma t
		on t.idprof = p.idprof
group by p.idprof
order by qtd_atendimentos desc
limit 2













