/*******************************************************************************
   Script: BD_Examen_ADRIAN_MADRIGAL_VALVERDE.sql
   Description: Examen Base de Datos
   DB Server: SqlServer
   Author: Adrián Madrigal

********************************************************************************/

/*******************************************************************************
   Drop database if it exists
********************************************************************************/
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'BD_Examen_ADRIAN_MADRIGAL_VALVERDE')
BEGIN
	ALTER DATABASE [BD_Examen_ADRIAN_MADRIGAL_VALVERDE] SET OFFLINE WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE [BD_Examen_ADRIAN_MADRIGAL_VALVERDE] SET ONLINE;
	DROP DATABASE [BD_Examen_ADRIAN_MADRIGAL_VALVERDE];
END
GO

/*******************************************************************************
   Create database
********************************************************************************/
USE master
GO

CREATE DATABASE [BD_Examen_ADRIAN_MADRIGAL_VALVERDE]
GO

USE [BD_Examen_ADRIAN_MADRIGAL_VALVERDE];
GO

/*******************************************************************************
   Create Tables
********************************************************************************/

--Tabla Direccion
CREATE TABLE Direccion(
	   Num_Propiedad varchar(6) primary key,
	   Provincia	 varchar(50) not null,
	   Calle		 varchar(50) not null,
	   Ciudad		 varchar(50) not null
)

--Tabla Proveedor
CREATE TABLE Proveedor(
       Id_Proveedor			integer primary key,
       Nombre_proveedor		varchar(50) not null,
       Direccion			varchar(6) not null,
       Telefono				char(11) not null,
       Contacto				varchar(50) not null
	   FOREIGN KEY (Direccion) REFERENCES Direccion (Num_Propiedad)
	   );

--Tabla Cliente

CREATE TABLE Cliente(
	   Id_Cliente				integer primary key,
       Nombre					varchar(50) not null,
       Cedula					integer not null unique,
       Telefono					varchar(14) null,
       Direccion				varchar(6) not null
	   FOREIGN KEY (Direccion) REFERENCES Direccion (Num_Propiedad)
);
--Tabla Compra
CREATE TABLE Compra (
       Id_Orden				integer primary key,
       Fecha				datetime not null,
	   Id_proveedor			integer not null,
       FOREIGN KEY (Id_proveedor) REFERENCES Proveedor (Id_Proveedor)
);

--Tabla Artú€ulo
CREATE TABLE Articulo(
       Codigo			  integer primary key,
       Descripcion		  varchar(100) not null unique,
       Precio_Venta		  decimal(11,2) not null,
       Cantidad_existente integer not null
);

--Tabla Detalle Compra
CREATE TABLE Detalle_Compra(
       Id_Detalle_Compra	integer primary key,
       Id_Articulo			integer not null,
       Cantidad				integer not null,
       Precio_unitario		decimal(11,2) not null,
	   Id_Compra			integer not null,
       FOREIGN KEY (Id_Compra) REFERENCES Compra (Id_Orden) ON DELETE CASCADE,
       FOREIGN KEY (Id_Articulo) REFERENCES Articulo (Codigo)
);

--Tabla Descuento
CREATE TABLE Descuento(
		Codigo				integer primary key,
		Descripcion			varchar(100)
)

--Tabla Facturacion
CREATE TABLE Facturacion(
       Id_Factura						integer primary key,
       Id_Cliente						integer not null,
       Fecha							datetime not null,
	   Tipo_pago						varchar(25) not null,
       Monto_impuesto					decimal (10,2) not null,
       Id_cupon_descuento				integer not null,
       Monto_descuento					decimal(11,2) not null,
       FOREIGN KEY (Id_Cliente)			REFERENCES Cliente (Id_Cliente),
       FOREIGN KEY (Id_cupon_descuento) REFERENCES Descuento (Codigo)
);

--Tabla Detalle Factura
CREATE TABLE Detalle_Factura(
       Id_Detalle_Factura		 integer primary key,
	   Id_Factura				 integer not null,
       Id_Articulo				 integer not null,
       Cantidad					 integer not null,
       Precio_Unitario			 decimal(11,2) not null
       FOREIGN KEY (Id_Articulo) REFERENCES Articulo (Codigo),
	   FOREIGN KEY (Id_Factura)  REFERENCES Facturacion(Id_Factura)
);




/*******************************************************************************
   Registros de Tablas
********************************************************************************/
--Registros

INSERT INTO [dbo].[Direccion](Num_Propiedad,Provincia,Calle,Ciudad)
VALUES (1,'Heredia', 'San Vicente', 'Santo Domingo'), (2, 'Heredia', 'Calle Soto', 'Santo Domingo');

INSERT INTO [dbo].[Proveedor](Id_Proveedor,Nombre_proveedor,Direccion,Telefono,Contacto)
VALUES (1,'Verduras La Ronda',1,10012002,'VerdurasRonda@hotmail.com'),(2,'Proveeduria S.D.',2,1234578,'ProveeduriaSD@cr.net');

INSERT INTO [dbo].[Cliente](Id_Cliente, Nombre,Cedula,Telefono,Direccion)
VALUES	(1,'Adrian Madrigal',702980332,20102022,1),(2,'Alejandra Valverde', 199010234,88102929,2);

INSERT INTO [dbo].[Compra](Id_Orden,Fecha,Id_proveedor)
VALUES (1,GETDATE(),1),(2,GETDATE(),2);

INSERT INTO [dbo].[Articulo](Codigo,Descripcion,Precio_Venta,Cantidad_existente)
VALUES (1,'Mango',1200,50),(2,'Mesa de madera refinada', 75000,4);

INSERT INTO [dbo].[Detalle_Compra](Id_Detalle_Compra,Id_Articulo,Cantidad,Precio_unitario,Id_Compra)
VALUES (1,1,5,1200,1),(2,2,1,75000,2);

INSERT INTO Descuento (Codigo, Descripcion)
VALUES (1, 'Producto no en su mejor condicion'),(2, 'Promocion por fiestas');

INSERT INTO Facturacion(Id_Factura,Id_Cliente,Fecha,Tipo_pago,Monto_impuesto,Id_cupon_descuento,Monto_descuento)
VALUES (1,1,GETDATE(),'Tarjeta de debito',1560,2,2000 ),(2,2,GETDATE(),'Tarjeta de credito',9750,1,20000);

INSERT INTO Detalle_Factura(Id_Detalle_Factura,Id_Factura,Id_Articulo,Cantidad,Precio_Unitario)
VALUES (1,1,1,10,1200),(2,2,2,1,75000);

GO
/*******************************************************************************
   Procedimientos para un CRUD
********************************************************************************/



-- Procedimientos Articulo 

CREATE PROCEDURE sp_Filtrar_Articulo
(
  @filtro varchar(100)
)
AS
BEGIN
	SELECT [Codigo],
	       [Descripcion],
		   [Precio_Venta],
	       [Cantidad_existente]
	FROM [dbo].[Articulo]
	WHERE [Descripcion] LIKE '%' + @filtro + '%'
END

GO

CREATE PROCEDURE sp_Insertar_Articulo
(
 @Codigo integer,
 @Descripcion VARCHAR (100),
 @Precio_Venta decimal (11,2),
 @Cantidad_existente integer
)
AS
BEGIN
	INSERT INTO [dbo].[Articulo] (Codigo,Descripcion,Precio_Venta,Cantidad_existente)
		VALUES (@Codigo,@Descripcion,@Precio_Venta,@Cantidad_existente)
END

GO

CREATE PROCEDURE sp_Modificar_Articulo
(
 @Codigo integer,
 @Descripcion VARCHAR (100),
 @Precio_Venta decimal (11,2),
 @Cantidad_existente integer
)
AS
BEGIN
	UPDATE [dbo].[Articulo]
		SET [Codigo] = @Codigo,
			[Precio_Venta] = @Precio_Venta,
			[Cantidad_existente] = @Cantidad_existente
	WHERE Descripcion = @Descripcion
END;

GO
CREATE PROCEDURE [dbo].[sp_Eliminar_Articulo]
(
		@Descripcion VARCHAR(100)

)
AS
BEGIN
DELETE FROM [dbo].[Articulo]
	   WHERE [Descripcion] = @Descripcion
END

GO

--Procedimientos Cliente
CREATE PROCEDURE sp_Filtrar_Cliente
(
  @filtro varchar(50)
)
AS
BEGIN
	SELECT [Id_Cliente],
	       [Nombre],
		   [Cedula],
	       [Telefono],
		   [Direccion]
	FROM [dbo].[Cliente]
	WHERE [Nombre] LIKE '%' + @filtro + '%'
END

GO

CREATE PROCEDURE sp_Insertar_Cliente
(
 @Id_Cliente integer,
 @Nombre VARCHAR (50),
 @Cedula integer,
 @Telefono varchar(14),
 @Direccion varchar(6)
)
AS
BEGIN
	INSERT INTO [dbo].[Cliente] (Id_Cliente,Nombre,Cedula,Telefono,Direccion)
		VALUES (@Id_Cliente,@Nombre,@Cedula,@Telefono,@Direccion)
END

GO

CREATE PROCEDURE sp_Modificar_Cliente
(
 @Id_Cliente integer,
 @Nombre VARCHAR (50),
 @Cedula integer,
 @Telefono varchar(14),
 @Direccion varchar(6)
)
AS
BEGIN
	UPDATE [dbo].[Cliente]
		SET [Id_Cliente] = @Id_Cliente,
			[Cedula] = @Cedula,
			[Telefono] = @Telefono,
			[Direccion] = @Direccion
	WHERE Nombre = @Nombre
END;

GO
CREATE PROCEDURE [dbo].[sp_Eliminar_Cliente]
(
		@Nombre VARCHAR(50)

)
AS
BEGIN
DELETE FROM [dbo].[Cliente]
	   WHERE [Nombre] = @Nombre
END

GO

--Procedimientos Compra
CREATE PROCEDURE sp_Filtrar_Compra
(
  @filtro integer
)
AS
BEGIN
	SELECT [Id_Orden],
	       [Fecha],
		   [Id_proveedor]
	FROM [dbo].[Compra]
	WHERE [Id_Orden] LIKE '%' + @filtro + '%'
END

GO

CREATE PROCEDURE sp_Insertar_Compra
(
 @Id_Orden integer,
 @Fecha datetime,
 @Id_proveedor integer
)
AS
BEGIN
	INSERT INTO [dbo].[Compra] (Id_Orden,Fecha,Id_proveedor)
		VALUES (@Id_Orden,@Fecha,@Id_proveedor)
END

GO

CREATE PROCEDURE sp_Modificar_Compra
(
 @Id_Orden integer,
 @Fecha datetime,
 @Id_proveedor integer
)
AS
BEGIN
	UPDATE [dbo].[Compra]
		SET [Fecha] = @Fecha,
			[Id_proveedor] = @Id_proveedor
	WHERE Id_Orden = @Id_Orden
END;

GO
CREATE PROCEDURE [dbo].[sp_Eliminar_Compra]
(
		@Id_Orden integer

)
AS
BEGIN
DELETE FROM [dbo].[Compra]
	   WHERE [Id_Orden] = @Id_Orden
END

GO



--Procedimientos Proveedor
CREATE PROCEDURE sp_Filtrar_Proveedor
(
  @filtro varchar(50)
)
AS
BEGIN
	SELECT [Id_Proveedor],
	       [Nombre_proveedor],
		   [Direccion],
		   [Telefono],
		   [Contacto]
	FROM [dbo].[Proveedor]
	WHERE [Nombre_proveedor] LIKE '%' + @filtro + '%'
END

GO

CREATE PROCEDURE sp_Insertar_Proveedor
(
 @Id_Proveedor integer,
 @Nombre_proveedor varchar(50),
 @Direccion varchar(6),
 @Telefono varchar(14),
 @Contacto varchar(50)
)
AS
BEGIN
	INSERT INTO [dbo].[Proveedor] (Id_Proveedor,Nombre_proveedor,Direccion,Telefono,Contacto)
		VALUES (@Id_Proveedor,@Nombre_proveedor,@Direccion,@Telefono,@Contacto)
END

GO

CREATE PROCEDURE sp_Modificar_Proveedor
(
 @Id_Proveedor integer,
 @Nombre_proveedor varchar(50),
 @Direccion varchar(6),
 @Telefono varchar(14),
 @Contacto varchar(50)
)
AS
BEGIN
	UPDATE [dbo].[Proveedor]
		SET [Id_Proveedor] = @Id_Proveedor,
			[Direccion] = @Direccion,
			[Telefono] = @Telefono,
			[Contacto] = @Contacto
	WHERE Nombre_proveedor = @Nombre_proveedor
END;

GO
CREATE PROCEDURE [dbo].[sp_Eliminar_Proveedor]
(
		@Nombre_proveedor varchar(50)

)
AS
BEGIN
DELETE FROM [dbo].[Proveedor]
	   WHERE [Nombre_proveedor] = @Nombre_proveedor
END

GO


--Vista Articulo
CREATE VIEW ArticuloDisponibles
AS
SELECT Articulo.Descripcion AS [NOMBRE], Articulo.Cantidad_existente AS [STOCK],Articulo.Precio_Venta AS [PRECIO]  
FROM Articulo;

GO

--Vista Cliente
CREATE VIEW ClienteConSuTipoPago
AS
SELECT A.NOMBRE, A.CEDULA, B.Tipo_pago, C.Descripcion
FROM
Cliente A INNER JOIN Facturacion B ON A.Id_Cliente=B.Id_Cliente
INNER JOIN Descuento C ON B.Id_cupon_descuento=C.Codigo;

GO

--Vista Compra
CREATE VIEW CompraAlProveedor
AS
SELECT Proveedor.Nombre_proveedor, Compra.Id_Orden, Compra.Fecha, Articulo.Descripcion FROM
Proveedor INNER JOIN Compra ON Proveedor.Id_Proveedor=Compra.Id_proveedor
INNER JOIN Detalle_Compra ON Detalle_Compra.Id_Compra=Compra.Id_Orden
INNER JOIN Articulo ON Detalle_Compra.Id_Articulo=Articulo.Codigo;

GO

--Vista Detalle Compra
CREATE VIEW DetalleCompraDeArticulosCaros
AS
SELECT A.Descripcion, B.Cantidad, B.Precio_unitario FROM
Articulo A INNER JOIN Detalle_Compra B ON A.Codigo=B.Id_Articulo
WHERE B.Precio_unitario>50000;
GO
--Vista Detalle Factura
CREATE VIEW FacturaUsual
AS
SELECT A.Id_Factura, B.Nombre, C.Fecha, D.Descripcion,A.Cantidad, A.Precio_Unitario FROM
Detalle_Factura A INNER JOIN Facturacion C ON A.Id_Factura=C.Id_Factura
INNER JOIN Cliente B ON C.Id_Cliente=B.Id_Cliente
INNER JOIN Articulo D ON A.Id_Articulo=D.Codigo;
GO

--Vista Facturacion
CREATE VIEW FacturaDetallada
AS
SELECT A.Id_Factura, B.Nombre, A.Fecha,C.Descripcion, D.Cantidad, D.Precio_Unitario, A.Tipo_Pago, A.Monto_impuesto,  A.Monto_descuento
FROM Facturacion A INNER JOIN Detalle_Factura D ON A.Id_Factura=D.Id_Factura
INNER JOIN Cliente B ON B.Id_Cliente=A.Id_Cliente
INNER JOIN Articulo C ON D.Id_Articulo=C.Codigo;
GO
--Vista Proveedor
CREATE VIEW ProveedoresSanVicente
AS
SELECT Nombre_proveedor, Telefono, Contacto FROM [dbo].[Proveedor]
WHERE Direccion = 1;

GO

SELECT * FROM  ArticuloDisponibles;
SELECT * FROM  ClienteConSuTipoPago;
SELECT * FROM  CompraAlProveedor;
SELECT * FROM  DetalleCompraDeArticulosCaros;
SELECT * FROM  FacturaUsual;
SELECT * FROM  FacturaDetallada;
SELECT * FROM  ProveedoresSanVicente;

--DROP DATABASE BD_Examen_ADRIAN_MADRIGAL_VALVERDE;