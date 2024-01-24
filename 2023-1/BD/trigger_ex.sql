create database triggers_db;
use triggers_db;
use academico;

CREATE TABLE setores
(
	id int auto_increment primary key,
    nome varchar(50) not null, 
    total_salario decimal(18,2) default 0
);
insert into setores (nome)
	values ('Dev'), ('Suporte'),('Finan');

CREATE TABLE funcionarios
(
	id int auto_increment primary key,
    nome varchar(50) not null, 
    salario decimal(18,2) default 0,
    id_setor int,
    constraint funcionarios_setores_fk
		foreign key(id_setor) 
			references setores(id) 
				ON DELETE RESTRICT
                ON UPDATE CASCADE
);

DELIMITER $$
CREATE TRIGGER trigger_atualiza_total_salario after insert on funcionarios
	FOR EACH ROW
BEGIN
	update setores set total_salario = total_salario +  NEW.salario
    where id = NEW.id_setor;
END $$
DELIMITER ;


DELIMITER $$
CREATE TRIGGER trigger_atualiza_total_salario_quando_delete after delete on funcionarios
	FOR EACH ROW
BEGIN
	update setores set total_salario = total_salario - OLD.salario
    where id = OLD.id_setor;
END $$
DELIMITER ;


DELIMITER $$
CREATE TRIGGER trigger_atualiza_total_salario_quando_atualizado after update on funcionarios
	FOR EACH ROW
BEGIN
	update setores set total_salario = total_salario + (NEW.salario - OLD.salario)
    where id = NEW.id_setor;
END $$
DELIMITER ;



T