-- padroes de nomes no SQL

-- snake_case mais utilizada para SQL
-- camelCase utiliza em JS = TS
-- PascalCase outras linguagens


/*

SQL não é uma LP (Linguagens de programação)

*/


-- temos um modelo lógico

-- 1 cliente tem endereços e um endereço pertence a um cliente

clientes(id int primary key, nome char(100));
enderecos(id, logradouro, numero, bairro, cidade, estado, id_cliente FK);

-- OBS: nome de tabelas sempre no plural.
-- nomde de atributos sempre no singular.

-- CREATE TABLE


/*
create table <nome_da_tabela>
(
    atributo | dominio| restrição vazio | chave

);
*/

create table clientes
(
    id int not null primary key,
    nome varchar(100) not null,
    CPF varchar(14) unique,
    limite_credito float default 0
);


create table enderecos
(
    id int not null primary key,
    logradouro varchar(100) not null,
    numero int default 0,
    bairro varchar(100),
    cidade varchar(100),
    estado char(2),
    id_cliente int not null,
    constraint clientes_tem_enderecos
    foreign key(id_cliente) references clientes(id)
);




create table professores
(
    id int not null primary key,
    nome varchar(100) not null

);

create table disciplinas
(
    id int not null primary key,
    nome varchar(100) not null,
    id_professor int not null,
    constraint professores_ensinam_disciplinas
    foreign key(id_professor) references professores(id)
    
);

create table disciplinas_tem_softwares
(
    id_disciplina int not null,
    id_software int not null,
    constraint fk_disciplina_tem_softwares
    foreign key(id_disciplina) references disciplinas(id),
    constraint fk_softwares_tem_disciplinas
    foreign key(id_software) references softwares(id)
);

create table softwares
(
    id int not null primary key,
    nome varchar(100) not null,
    fabricante varchar(50)
);













/*

aluno(id, nome)
departamento (id, nome)
curso(id, nome, id_depto)
  id_depto referencia departamento (id)
professor(id, nome)
disciplina(id, nome, id_prof)
   id_prof referencia professor(id)
matricula(id_disciplina, id_aluno, data_matr)
    id_disciplina referencia disciplina(id) 
   id_aluno referencia aluno(id);
*/



create table alunos
(
    id not null auto_increment primary key,
    nome varchar(100) not null
);


create table departamentos
(
    id int not null auto_increment primary key,
    nome varchar(100) not null
);


create table cursos
(
    id int not null auto_increment primary key,
    nome varchar(100) not null,
    id_depto int not null,
    constraint fk_curso_possui_depto
    foreign key(id_depto) references departamentos(id)
);


create table professores
(
    id int not null auto_increment primary key,
    nome varchar(100) not null
);


create table disciplinas
(
    id int not null auto_increment primary key,
    nome varchar(100) not null,
    id_professor int not null,
    constraint fk_professor_possui_disciplinas
    foreign key(id_professor) references professores(id)
);


create table matriculas
(
    data_matricula date,
    id_disciplina int not null,
    id_aluno int not null,
    constraint fk_disciplina_possui_matricula
    foreign key(id_disciplina) references disciplinas(id),
    constraint fk_aluno_possui_matricula
    foreign key(id_aluno) references alunos(id)
);

-----------------------------------------------------------------

create table colaboradores
(
    nr_matricula int not null auto_increment primary key,
    nome varchar(100) not null,
    email varchar(50) not null,
    senha varchar(30) not null
);

create table comentario
(
    id int not null auto_increment primary key,
    data_comentario datetime not null,
    matricula_colaborador int not null,
    constraint fk_colaborador_faz_comentario
    foreign key(matricula_colaborador) references colaboradores(nr_matricula) 
);



create table projetos
(
    id int not null auto_increment primary key,
    nome varchar(100) not null,
    descricao varchar(200),
    duracao int not null,
    matricula_colaborador int not null,
    constraint fk_projeto_possui_matricula_colaborador
    foreign key(matricula_colaborador) references colaboradores(nr_matricula) 
);


create table projetos_melhoria_processo
(
    resultados varchar(500) not null,
    departamento int not null,
    id_projeto int not null,
    constraint fk_melhoria_processo_possui_projeto
    foreign key(id_projetos) references projetos(id) 
);

create table projetos_sociais
(
    publico_beneficiario varchar(200) not null,
    id_projetos int not null,
    constraint fk_social_possui_projeto
    foreign key(id_projetos) references projetos(id) 
);






-----------------------------------------------------------------
/*Correção*/


create table colaboradores
(
    id int auto_increment primary key,
    matricula varchar(20) not null unique,
    nome varchar(100) not null,
    id_coordenador int,
    constraint coordenadores_fk_colaboradores 
    foreign key(id_coordenador) references colaboradores(id)
);

create table projetos
(
    id int auto_increment primary key,
    nome varchar(100) not null,
    descricao varchar(200),
    duracao int not null,
    matricula_colaborador int not null,
    constraint fk_projeto_possui_matricula_colaborador
    foreign key(matricula_colaborador) references colaboradores(nr_matricula) 
);

create table projetos_colaboradores
(
    id int auto_increment primary key,
    id_projeto int not null,
    id_colaborador int not null,
    constraint projetos_fk_projetos_tem_colaboradores
    foreign key(id_projeto) references projetos(id),
    constraint projetos_fk_projetos_tem_colaboradores
    foreign key(id_colaborador) references colaboradores(id)
    on delete restrict

);
create table projetos_comentarios
(
    id int not null auto_increment primary key,
    id_colaborador int not null,
    id_comentario int not null,
    data_hora datetime not null,
    constraint fk_colaborador_faz_comentario
    foreign key(id_colaborador) references colaboradores(id),
    constraint comentarios_fk_projetos
    foreign key(id_projeto) references projetos(id)
    on delete cascade
    on update cascade
);

create table departamentos
(
    id int auto_increment primary key,
    nome varchar(50) not null
);

create table projetos_melhoria_processos
(
    id int auto_increment primary key,
    resultados varchar(500) not null,
    id_projeto int not null,
    constraint projetos_fk_projetos_melhoria_processos_possui_projeto
    foreign key(id_projetos) references projetos(id);
    constraint departamentos_fk_projetos_melhoria_processos
    foreign key(id_departamento) references departamento
    on delete restrict
    on update cascade 
);

create table projetos_sociais
(
    id int auto_increment primary key,
    id_projetos int not null,
    publico_beneficiario varchar(200) not null,
    constraint projetos_fk_projetos_social
    foreign key(id_projeto) references projetos(id)
    on delete restrict
    on update cascade 
);