create database TDE_aula_3;

use TDE_aula_3;

create table clientes(
	id int auto_increment primary key,
	nome varchar(100) not null,
	email varchar(50) not null,
	telefone varchar(15) not null,
	endereco varchar(100) not null
);

create table categorias(
	id int auto_increment primary key,
	nome varchar(100) not null,
	descricao varchar(200) not null
);

create table produtos(
	id int auto_increment primary key,
	nome varchar(100) not null,
	descricao varchar(200) not null,
	preco double not null,
	id_categoria int not null,
	constraint produtos_possuem_categorias
	foreign key (id_categoria) references categorias(id)
			on delete restrict
			on update cascade
);



create table pedidos(
	id int auto_increment primary key,
	data_pedido date not null,
	valor_total double not null,
	id_cliente int not null,
	constraint fk_cliente
		foreign key (id_cliente) references clientes(id)
			on delete restrict
			on update cascade
);

create table vendas(
	id int auto_increment primary key,
	data_venda date not null,
	preco_venda double not null,
	unidades_vendidas int not null,
	id_produto int not null,
	constraint fk_produto
		foreign key (id_produto) references produtos(id)
			on delete restrict
			on update cascade
);

create table fornecedores(
	id int auto_increment primary key,
	nome varchar(100) not null,
	email varchar(50) not null,
	telefone varchar(15) not null,
	endereco varchar(100) not null
);

create table compras(
	id int auto_increment primary key,
	data_compra date not null,
	preco_compra double not null,
	unidades_compradas int not null,
	id_fornecedor int not null,
	id_produto int not null,
	constraint compras_possuem_fornecedor
	foreign key (id_fornecedor) references fornecedores(id)
			on delete restrict
			on update cascade,
	constraint compras_possuem_produtos
	foreign key (id_produto) references produtos(id)
			on delete restrict
			on update cascade
);

alter table compras
add id_cliente int not null
foreign key(id_cliente) references clientes(id);

ALTER TABLE compras
DROP COLUMN id_clientes

alter table compras
add constraint fk_compras_possuem_cliente
foreign key(id_cliente) references clientes(id);

create table departamentos(
	id int auto_increment primary key,
	nome varchar(100) not null,
	descricao varchar(200) not null
);

create table funcionarios(
	id int auto_increment primary key,
	nome varchar(100) not null,
	email varchar(50) not null,
	telefone varchar(15) not null,
	endereco varchar(100) not null,
	salario double not null,
	id_departamento int not null,
	constraint fk_departamento
		foreign key (id_departamento) references departamentos(id)
			on delete restrict
			on update cascade
);

-- Inserção de clientes
INSERT INTO clientes (nome, email, telefone, endereco) VALUES 
('João da Silva', 'joao.silva@gmail.com', '(11) 98888-7777', 'Rua A, 123'),
('Maria dos Santos', 'maria.santos@hotmail.com', '(21) 97777-5555', 'Avenida B, 456'),
('Pedro Souza', 'pedro.souza@yahoo.com', '(19) 98888-1111', 'Rua C, 789');

-- Inserção de categorias
INSERT INTO categorias (nome, descricao) VALUES 
('Eletrônicos', 'Produtos eletrônicos em geral'),
('Roupas', 'Roupas para todas as idades e estilos'),
('Alimentos', 'Produtos alimentícios e bebidas'),
('Livros', 'Livros de diversos gêneros');

-- Inserção de produtos
INSERT INTO produtos (nome, descricao, preco, id_categoria) VALUES 
('Smartphone Samsung Galaxy S21', 'Celular top de linha da Samsung', 4999.99, 1),
('Camisa Polo Lacoste', 'Camisa polo com o icônico crocodilo da Lacoste', 299.99, 2),
('Arroz Tio João', 'Arroz tipo 1 de ótima qualidade', 29.99, 3),
('Livro "1984" de George Orwell', 'Obra clássica da literatura', 39.99, 4);

-- Inserção de pedidos
INSERT INTO pedidos (data_pedido, valor_total, id_cliente) VALUES 
('2022-01-01', 7999.98, 1),
('2022-02-15', 299.99, 2),
('2022-03-22', 129.98, 3),
('2022-04-10', 79.98, 1),
('2022-05-18', 7999.98, 3),
('2022-04-10', 300.00, 1);

-- Inserção de vendas
INSERT INTO vendas (data_venda, preco_venda, unidades_vendidas, id_produto) VALUES 
('2022-01-01', 4999.99, 2, 1),
('2022-01-02', 299.99, 1, 2),
('2022-01-03', 29.99, 2, 3),
('2022-01-04', 39.99, 1, 4),
('2022-02-15', 299.99, 1, 2),
('2022-03-22', 29.99, 1, 3),
('2022-05-18', 4999.99, 1, 1);

-- Inserção de fornecedores
INSERT INTO fornecedores (nome, email, telefone, endereco) VALUES 
('Fornecedor A', 'fornecedor.a@fornecedores.com', '(11) 8888-4444', 'Rua D, 123'),
('Fornecedor B', 'fornecedor.b@fornecedores.com', '(21) 9999-3333', 'Avenida E, 456'),
('Fornecedor C', 'fornecedor.c@fornecedores.com', '(19) 8888-0000', 'Rua F, 789');

-- Tabela Compras
INSERT INTO compras (data_compra, preco_compra, unidades_compradas, id_fornecedor, id_produto)
VALUES 
('2022-03-10', 500.00, 10, 1, 1),
('2022-03-11', 300.00, 20, 2, 2),
('2022-03-12', 200.00, 5, 3, 1),
('2022-03-13', 150.00, 15, 2, 3),
('2022-03-14', 1000.00, 30, 1, 2),
('2022-03-15', 250.00, 7, 3, 2),
('2023-03-15', 250.00, 110, 1, 2);

-- Tabela Departamentos
INSERT INTO departamentos (nome, descricao)
VALUES 
('RH', 'Responsável por cuidar do relacionamento com os funcionários e gestão de pessoas.'),
('Financeiro', 'Responsável por cuidar das finanças da empresa.'),
('Comercial', 'Responsável por cuidar das vendas da empresa.'),
('TI', 'Responsável por cuidar da infraestrutura de tecnologia da empresa.');

-- Tabela Funcionários
INSERT INTO funcionarios (nome, email, telefone, endereco, salario, id_departamento)
VALUES 
('João Silva', 'joao.silva@empresa.com', '11987654321', 'Rua A, 123', 5000.00, 1),
('Maria Santos', 'maria.santos@empresa.com', '11998765432', 'Rua B, 456', 7000.00, 1),
('José Pereira', 'jose.pereira@empresa.com', '11987654321', 'Rua C, 789', 8000.00, 2),
('Amanda Oliveira', 'amanda.oliveira@empresa.com', '11998765432', 'Rua D, 1011', 6000.00, 2),
('Pedro Souza', 'pedro.souza@empresa.com', '11987654321', 'Rua E, 1213', 9000.00, 3),
('Luciana Almeida', 'luciana.almeida@empresa.com', '11998765432', 'Rua F, 1415', 8000.00, 3),
('Gabriel Santos', 'gabriel.santos@empresa.com', '11987654321', 'Rua G, 1617', 10000.00, 4),
('Fernanda Oliveira', 'fernanda.oliveira@empresa.com', '11998765432', 'Rua H, 1819', 6000.00, 4);

-- ------------------------------------------------------------------------------------------------------------

-- Escreva uma consulta que retorne o nome do cliente, a soma do valor total das compras e o número total de pedidos feitos por cada cliente, apenas para aqueles que fizeram pelo menos três pedidos. Use um inner join entre as tabelas "clientes" e "pedidos" e agrupe os resultados pelo nome do cliente.
select c.nome, sum(p.valor_total) as valor_total, count(*) as total_pedidos
from pedidos p
	inner join clientes c
		on c.id = p.id_cliente
group by c.nome
having count(*) >= 3;
	

-- Escreva uma consulta que retorne o nome do produto, a média do preço de venda e a soma total de unidades vendidas por categoria de produto. Use um left join entre as tabelas "produtos" e "vendas" e agrupe os resultados pela categoria do produto.
select c.nome, p.nome, avg(v.preco_venda) as media_preco_venda, sum(v.unidades_vendidas) as soma_total
from categorias c
	inner join produtos p
		on c.id = p.id_categoria
    left join vendas v
		on p.id = v.id_produto
group by c.nome, p.nome;


-- Escreva uma consulta que retorne o nome do fornecedor, o nome do produto e o número total de unidades compradas por fornecedor e por produto, apenas para aqueles com mais de 100 unidades compradas. Use um inner join entre as tabelas "fornecedores", "produtos" e "compras" e agrupe os resultados pelo nome do fornecedor e pelo nome do produto.
select f.nome as nome_fornecedor, p.nome as nome_produto, sum(c.unidades_compradas) as total_unidades_compradas
from fornecedores f
	inner join compras c
		on f.id = c.id_fornecedor
	inner join produtos p
		on p.id = c.id_produto
group by f.nome, p.nome
having total_unidades_compradas > 100;

-----------------------------------------------
-- refatorado
select f.nome as nome_fornecedor, p.nome as nome_produto, sum(c.unidades_compradas) as total_unidades_compradas
from fornecedores f
	inner join compras c
		on f.id = c.id_fornecedor
	inner join produtos p
		on p.id = c.id_produto
group by f.nome, p.nome
having total_unidades_compradas > 100;


-- Escreva uma consulta que retorne o nome do departamento, o nome do funcionário e a média do salário dos funcionários em cada departamento, apenas para aqueles com uma média de salário superior a R$ 5000. Use um left join entre as tabelas "funcionarios" e "departamentos" e agrupe os resultados pelo nome do departamento e pelo nome do funcionário.
select d.nome as nome_departamento, f.nome as nome_funcionario, avg(f.salario) as media_salario_funcionarios
from funcionarios f
	left join departamentos d
		on d.id = f.id_departamento
group by d.nome, f.nome
having media_salario_funcionarios > 5000;


-- Escreva uma consulta que retorne o nome do cliente, o nome do produto e a soma do valor total das compras feitas por cada cliente para cada produto. Use um right join entre as tabelas "clientes" e "compras" e um inner join entre as tabelas "produtos" e "compras" e agrupe os resultados pelo nome do cliente e pelo nome do produto.

select c.nome as nome_cliente, p.nome as nome_produto, sum(co.preco_compra * co.unidades_compradas) as valor_total_compras
from clientes c
right join compras co on c.id = co.id_cliente
inner join produtos p on co.id_produto = p.id
group by c.nome, p.nome;




