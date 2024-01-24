create table fornecedores
(
    codigo int auto_increment primary key,
    nome varchar(100) not null
);


create table pedidos
(
    quantidade int primary key,
    valor_unitario float not null,
    data_pedido date not null,
    cod_fornecedor int not null,
    cod_produto int not null,
    constraint fk_pedidos_possui_fornecedores
    foreign key(cod_fornecedor) references fornecedores(codigo)
    on delete restrict 
    on update cascade,
    constraint fk_pedidos_possui_produtos
    foreign key(cod_produto) references produtos(codigo)
    on delete restrict
    on update cascade
); 

create table produtos
(
    codigo int auto_increment primary key,
    descricao varchar(300) not null,
    data_cadastro date not null,
    valor_unitario float not null,
    cod_categoria int not null,
    constraint fk_produtos_possui_categoria
    foreign key(cod_categoria) references categoria(codigo)
    on delete cascade
    on update cascade
);


create table categoria
(
    codigo int auto_increment primary key,
    nome varchar(100) not null,
);