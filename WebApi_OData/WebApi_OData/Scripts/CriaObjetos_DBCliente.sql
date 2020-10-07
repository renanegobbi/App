-- LIMSTeam Consulting Services Ltda
-- Cria Tabelas do Banco de Dados DBCliente
-- Por Renan Elias Gobbi

set nocount on 

Use DBCliente
go

if exists (select * from sys.tables where name = 'PEDIDOPRODUTO')
	Drop table dbo.PEDIDOPRODUTO 
go

if exists (select * from sys.tables where name = 'CLIENTEPEDIDO')
	Drop table dbo.CLIENTEPEDIDO 
go

if exists (select * from sys.tables where name = 'PRODUTO')
	Drop table dbo.PRODUTO 
go

if exists (select * from sys.tables where name = 'PEDIDO')
	Drop table dbo.PEDIDO 
go

if exists (select * from sys.tables where name = 'CLIENTE')
	Drop table dbo.CLIENTE
go


-- *************************************************************************************************
-- Cria Tabela com dados do CLIENTE
-- *************************************************************************************************
Create table dbo.CLIENTE 
(
	ID				int					not null  IDENTITY(1,1) constraint PK_CLIENTE primary key (ID),
    NOME			nvarchar(MAX)		null
)
go

---- *************************************************************************************************
---- Cria Tabela com dados do PEDIDO
---- *************************************************************************************************
Create table dbo.PEDIDO  
(	ID				int					not null  constraint PK_PEDIDO primary key (ID),
	DATAPEDIDO		datetime			null,
	TOTAL			real				null
)
go

-- *************************************************************************************************
-- Cria Tabela com dados do PRODUTO
-- *************************************************************************************************
Create table dbo.PRODUTO 
( 
	ID				int					not null constraint PK_PRODUTO primary key (ID),
	NOME			nvarchar(MAX)		null
)
go

---- *************************************************************************************************
-- Cria Tabela com dados do CLIENTEPEDIDO
-- *************************************************************************************************
Create table dbo.CLIENTEPEDIDO 
(
	ID				int					not null IDENTITY(1,1) constraint PK_CLIENTEPEDIDO primary key (ID),
	CLIENTE			int					null,
	PEDIDO			int					null
)

-- Constraints
alter table dbo.CLIENTEPEDIDO add constraint FK_CLIENTEPEDIDO_CLIENTE foreign key (CLIENTE) references dbo.CLIENTE(ID)
alter table dbo.CLIENTEPEDIDO add constraint FK_CLIENTEPEDIDO_PEDIDO foreign key (PEDIDO) references dbo.PEDIDO(ID)
go

-- *************************************************************************************************
-- Cria Tabela com dados do PEDIDOPRODUTO
-- *************************************************************************************************
Create table dbo.PEDIDOPRODUTO 
( 
	ID				int					not null IDENTITY(1,1) constraint PK_PEDIDOPRODUTO primary key (ID),
	PEDIDO			int					null,
	PRODUTO  		int					null
)

-- Constraints
alter table dbo.PEDIDOPRODUTO add constraint FK_PEDIDOPRODUTO_PEDIDO foreign key (PEDIDO) references PEDIDO(ID)
alter table dbo.PEDIDOPRODUTO add constraint FK_PEDIDOPRODUTO_PRODUTO foreign key (PRODUTO) references PRODUTO(ID)
go

