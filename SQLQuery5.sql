create database teste_acoes
use teste_acoes

create table Acoes (
Codigo_acao int not null,
Razao_social_empresa varchar(150) not null,
primary key (Codigo_acao)
)

create table Compra_acoes (
Id int not null,
Codigo_acao int not null,
Preco numeric(10,2) not null,
Quantidade int not null,
DataCompra datetime not null,
ValorTotal numeric(10,2) not null,
primary key (Id),
foreign key (Codigo_acao) references Acoes(Codigo_acao)
)

create table Venda_acoes (
Id int not null,
Codigo_acao int not null,
Preco numeric(10,2) not null,
Quantidade int not null,
DataVenda datetime not null,
ValorTotal numeric(10,2) not null,
primary key (Id),
foreign key (Codigo_acao) references Acoes(Codigo_acao)
)

select * from Compra_acoes