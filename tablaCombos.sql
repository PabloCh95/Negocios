IF EXISTS (SELECT * FROM dbo.combos) DROP TABLE dbo.combos
CREATE TABLE combos 
(
	IdCliente int  NOT NULL,
	NombreC VARCHAR (50),
	ApellidoC VARCHAR (50),
	IdProducto int NOT NULL,
	NombreP VARCHAR(50),
	PrecioP int,
	CantidadP int,
	FOREIGN KEY (IdCliente) REFERENCES dbo.clientes (IDCLiente),
	FOREIGN KEY (IdProducto) REFERENCES dbo.productos (IDProducto)
);