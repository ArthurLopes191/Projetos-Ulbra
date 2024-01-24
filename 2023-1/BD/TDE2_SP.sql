create database TDE2_SP;

use TDE2_SP;

create table pessoas(
id int auto_increment primary key,
nome varchar (150) not null,
sexo char (1) not null,
data_nascimento date not null
);

/*Crie uma Store Procedure onde sejam possíveis passar como parâmetro as informações para Nome, Sexo e Data_Nascimento. 
Esta Stored Procedure deverá consultar no banco de dados o último ID gerado na tabela de Pessoas, 
incrementar este ID e inserir um registro nesta tabela com os dados enviados por parâmetro.*/

DELIMITER $$
create procedure inserir_tupla_pessoas(p_nome varchar(150), p_sexo char(1), p_data_nascimento date)
begin
	if p_sexo != "M" and p_sexo != "F" then
		select concat("Informe o sexo da pessoa como M para masculino ou F para feminino") as Aviso;
    else
		insert into pessoas(nome, sexo, data_nascimento) values (p_nome, p_sexo, p_data_nascimento);
        select concat("Pessoa inserida com sucesso ! ") as Aviso;
    end if;
end $$
DELIMITER ;

call inserir_tupla_pessoas("Mateus", "M", "2015-08-20");

/*Crie uma Stored Procedure que mostre quantos Homens e quantas Mulheres têm cadastrados.*/

DELIMITER $$
create procedure qtd_homens_e_mulheres_cadastrados()
begin
	select sexo, count(*) AS total 
    from pessoas 
    group by sexo;
end $$
DELIMITER ;

call qtd_homens_e_mulheres_cadastrados();

/*Crie uma Stored Procedure que mostre quantos Homens são menores e maiores de idade, 
e quantas Mulheres são maiores e menores de idade.*/

DELIMITER $$
create procedure qtd_homens_mulheres_idade()
begin
	select sexo,
		sum(case when timestampdiff(year, data_nascimento, CURDATE()) < 18 then 1 else 0 end) as menores_idade,
		sum(case when timestampdiff(year, data_nascimento, CURDATE()) >= 18 then 1 else 0 end) as maiores_idade
    from pessoas
    group by sexo;
end $$
DELIMITER ;

call qtd_homens_mulheres_idade();

/*Crie uma Stored Procedure que receba dois Números. 
Esta Procedure ao ser executada deverá mostrar o retorno obtido se
 estes dois números fossem somados, diminuídos, multiplicados e divididos.*/
 
DELIMITER $$
create procedure calculadora(p_n1 double,p_n2 double)
begin
	select p_n1 + p_n2 AS soma,
           p_n1 - p_n2 AS subtracao,
           p_n1 * p_n2 AS multiplicacao,
           p_n1 / p_n2 AS divisao;
	
end $$
DELIMITER ;

call calculadora(5 , 2);