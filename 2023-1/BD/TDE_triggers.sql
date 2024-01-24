create database orcamentos_produtos_triggers;
use orcamentos_produtos_triggers;

create table produtos(
codigo int auto_increment primary key,
qtd_estoque int not null,
descricao varchar(200) not null,
valor decimal(10,2) not null,
falta int not null,
prd_status int not null
);

create table orcamentos(
codigo int auto_increment primary key,
data_orc date not null,
orc_status int not null
);

create table orcamentos_produtos(
qtd int not null,
valor decimal(10,2) not null,
orp_status int,
orc_codigo int not null,
prd_codigo int not null,
	constraint fk_codigo_orcamento 
    foreign key (orc_codigo) references orcamentos(codigo)
		on delete restrict
        on update cascade,
	constraint fk_codigo_produtos 
    foreign key (prd_codigo) references produtos(codigo)
		on delete restrict
        on update cascade
);

-- ------------------------------------------------------------

create table produtos_atualizados(
prda_codigo int auto_increment primary key,
prda_qtd_anterior int,
prda_qtd_atualizada int,
prda_valor decimal(10,2)
);

create table produtos_em_falta(
prdf_codigo int auto_increment primary key,
prdf_qtd_estoque int,
prdf_descricao varchar(200),
prdf_falta int,
prdf_status int
);

select *
from produtos;

-- ------------------------------------------------------------


INSERT INTO produtos (qtd_estoque, descricao, valor, falta, prd_status) VALUES
(10, 'Produto A', 100.00, 0, 1), 
(20, 'Produto B', 50.00, 0, 1), 
(5, 'Produto C', 200.00, 0, 1);

INSERT INTO orcamentos (data_orc, orc_status)
VALUES 	('2023-05-03', 1),
		('2023-07-04', 1);

INSERT INTO orcamentos_produtos (qtd, valor, orp_status, orc_codigo, prd_codigo) VALUES 
(2, 100.00, 1, 1, 1),
(5, 50.00, 1, 1, 2),
(1, 200.00, 1, 1, 3);



-- -------------------------------------------------------------------------------------------------------------------------
/*1 – Faça um trigger para alterar o estoque de um produto quando ocorrer quaisquer alterações na tabela orçamentos_produtos. 
Também irá alterar o estoque, quando um ítem na tabela orçamentos_Produtos for cancelado. 
Isso ocorre quando o campo Orp_Status recebe o valor 2.*/

select *
from orcamentos_produtos

DELIMITER $$
CREATE TRIGGER trigger_atualiza_estoque_produto after update on orcamentos_produtos
	FOR EACH ROW
BEGIN
	if NEW.orp_status = 2 then
		update produtos set qtd_estoque = qtd_estoque + OLD.qtd
        where codigo = OLD.prd_codigo;
	else
		update produtos set qtd_estoque = qtd_estoque - NEW.qtd
		where codigo = NEW.prd_codigo;
    end if;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER trg_atualiza_qtd_produto_ao_inserir after insert on orcamentos_produtos
	FOR EACH ROW
BEGIN
	update produtos set qtd_estoque = qtd_estoque - NEW.qtd
	where codigo = NEW.prd_codigo;
END $$
DELIMITER ;


-- TESTES: 
select * 
from produtos

update orcamentos_produtos 
set qtd = 6
where orc_codigo = 2  

update orcamentos_produtos 
set orp_status = 2
where orc_codigo = 2

-- update produtos
-- set qtd_estoque = 50
-- where codigo = 1


-- -------------------------------------------------------------------------------------------------------------------------

/*2 – Faça um trigger para armazenar em uma tabela chamada produtos_atualizados (prd_codigo, prd_qtd_anterior, prd_qtd_atualizada, prd_valor) 
quando ocorrer quaisquer alterações nos atributos da tabela produtos. 
No entanto, caso a alteração atribua o valor zero para o atributo prd_qtd_estoque,
a tabela produtos_em_falta deverá ser alimentada com as mesmas informações da tabela produto, exceto o atributo prd_valor. 
Além disso, o atributo prd_status do produto atualizado deve ser modificado para NULL 
e o atributo orp_status de todos os orcamentos_produtos desse produto deverá ser modificado também para NULL. */


DELIMITER $$
CREATE TRIGGER trg_armazena_prd_atualizado_ou_em_falta after update on produtos
	FOR EACH ROW
BEGIN
		  DECLARE prd_qtd_anterior INT;
		  DECLARE prd_qtd_atualizada INT;
		  DECLARE prd_valor DECIMAL(10,2);
		  
		  SET prd_qtd_anterior = OLD.qtd_estoque;
		  SET prd_qtd_atualizada = NEW.qtd_estoque;
		  SET prd_valor = NEW.valor;
          
	if NEW.qtd_estoque = 0 then 
		insert into produtos_em_falta(prdf_codigo, prdf_qtd_estoque, prdf_descricao, prdf_falta, prdf_status) values
        (NEW.codigo, NEW.qtd_estoque, NEW.descricao, NEW.falta, NULL);
        
        update orcamentos_produtos 
        set orp_status = NULL
        where prd_codigo = NEW.codigo;
        
        update produtos
		set prd_status = NULL
		where codigo = NEW.codigo;
	end if;
    
		insert into produtos_atualizados (prda_codigo, prda_qtd_anterior, prda_qtd_atualizada, prda_valor)
		values (NEW.codigo, prd_qtd_anterior, prd_qtd_atualizada, prd_valor);
END $$
DELIMITER ;


-- TESTES:

SELECT * 
FROM produtos_atualizados
where codigo = 2;

SELECT * 
FROM produtos_em_falta;

update produtos
set qtd_estoque = 10
where codigo = 3;
















