set nocount on 

set xact_abort on 

Use DBCliente

-- Deleta registros existentes
Delete from dbo.PEDIDO
Delete from dbo.CLIENTE
Delete from dbo.PRODUTO
Delete from dbo.CLIENTEPEDIDO
Delete from dbo.PEDIDOPRODUTO
go


-- ******************************************************    
-- Popula tabela dbo.CLIENTE
-- ******************************************************

INSERT INTO dbo.CLIENTE(NOME)
VALUES
('Cliente1'),
('Cliente2'),
('Cliente3'),
('Cliente4'),
('Cliente5'),
('Cliente6'),
('Cliente7'),
('Cliente8'),
('Cliente9'),
('Cliente10')
go

Select * from dbo.CLIENTE
go


-- ******************************************************    
-- Popula tabela dbo.PEDIDO
-- ******************************************************

INSERT INTO dbo.PEDIDO(ID, DATAPEDIDO, TOTAL)
VALUES
(1,'2020-10-01 07:00:00', 10.1),
(2,'2020-10-02 08:00:00', 20.2),
(3,'2020-10-03 09:00:00', 30.3),
(4,'2020-10-04 10:00:00', 40.4),
(5,'2020-10-05 11:00:00', 50.5),
(6,'2020-10-06 12:00:00', 60.6),
(7,'2020-10-07 13:00:00', 70.7),
(8,'2020-10-08 14:00:00', 80.8),
(9,'2020-10-09 15:00:00', 90.9),
(10,'2020-10-10 16:00:00', 100.10)
go

Select * from dbo.PEDIDO
go


-- ******************************************************    
-- Popula tabela dbo.PRODUTO
-- ******************************************************

INSERT INTO dbo.PRODUTO(ID, NOME)
values 
(1,'Produto1'),
(2,'Produto2'),
(3,'Produto3'),
(4,'Produto4'),
(5,'Produto5'),
(6,'Produto6'),
(7,'Produto7'),
(8,'Produto8'),
(9,'Produto9'),
(10,'Produto10')
go

Select * from dbo.PRODUTO
go


---- ******************************************************    
---- Popula tabela dbo.CLIENTEPEDIDO
---- ******************************************************

INSERT INTO dbo.CLIENTEPEDIDO(CLIENTE, PEDIDO)
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(8,8),
(9,9),
(10,10)
go

Select * from dbo.CLIENTEPEDIDO
go


-- ******************************************************    
-- Popula tabela dbo.PEDIDOPRODUTO
-- ******************************************************

INSERT INTO dbo.PEDIDOPRODUTO(PEDIDO, PRODUTO)
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(8,8),
(9,9),
(10,10)
go

Select * from dbo.PEDIDOPRODUTO
go












