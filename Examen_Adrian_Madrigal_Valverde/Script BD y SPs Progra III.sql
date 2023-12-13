/*******************************************************************************
   Drop database if it exists
********************************************************************************/
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'DB_Examen_Final')
BEGIN
	ALTER DATABASE [DB_Examen_Final] SET OFFLINE WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE [DB_Examen_Final] SET ONLINE;
	DROP DATABASE [DB_Examen_Final];
END
USE [master]

GO

CREATE DATABASE [DB_Examen_Final]

GO

USE [DB_Examen_Final]

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

USE [DB_Examen_Final]

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Estados]
		(
			[IdEstado] [char] (1) NOT NULL,			
			[Descripcion] [varchar](25) NOT NULL,
	
			CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
			(
				[IdEstado] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Estados]
		ADD CONSTRAINT UC_Descripcion_Est UNIQUE ([Descripcion])


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Marcas]
		(
			[IdMarca] [int] IDENTITY(1,1) NOT NULL,
			[Marca] [varchar](90) NOT NULL,
			[IdEstado] [char] (1) NOT NULL,

			CONSTRAINT [PK_IdMarca] PRIMARY KEY CLUSTERED 
			(
				[IdMarca] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Marcas]
		ADD CONSTRAINT UC_Descripcion_Marc UNIQUE ([Marca])


GO

		ALTER TABLE [dbo].[T_Marcas]  WITH NOCHECK ADD  CONSTRAINT FK_Marcas_Estados FOREIGN KEY(IdEstado)
		REFERENCES [dbo].[T_Estados] (IdEstado)

GO

		ALTER TABLE [dbo].[T_Marcas] CHECK CONSTRAINT FK_Marcas_Estados

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

go


USE [DB_Examen_Final]

GO

CREATE PROCEDURE dbo.SP_LISTAR_ESTADOS
AS
BEGIN
SELECT [IdEstado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
END
GO



CREATE PROCEDURE dbo.SP_FILTRAR_ESTADOS
(
	@Descripcion VARCHAR(25)
)
AS
BEGIN
SELECT [IdEstado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
  WHERE [Descripcion] LIKE '%' + @Descripcion + '%'
END
GO


CREATE PROCEDURE dbo.SP_INSERTAR_ESTADOS
(
	@IdEstado char(1),
	@Descripcion VARCHAR(25)
)
AS
BEGIN
INSERT INTO [dbo].[T_Estados]
           ([IdEstado]
           ,[Descripcion])
     VALUES
           (@IdEstado, @Descripcion)
END
GO


CREATE PROCEDURE dbo.SP_MODIFICAR_ESTADOS
(
	@IdEstado char(1),
	@Descripcion VARCHAR(25)
)
AS
BEGIN
UPDATE [dbo].[T_Estados]
   SET [Descripcion] = @Descripcion
 WHERE [IdEstado] = @IdEstado
END
GO


CREATE PROCEDURE dbo.SP_ELIMINAR_ESTADOS
(
	@IdEstado char(1)
)
AS
BEGIN
DELETE FROM [dbo].[T_Estados]   
 WHERE [IdEstado] = @IdEstado
END
GO


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

go

USE [DB_Examen_Final]

GO

CREATE PROCEDURE dbo.SP_LISTAR_MARCAS
AS
BEGIN
SELECT [IdMarca]
      ,[Marca]
	  ,[IdEstado]
  FROM [dbo].[T_Marcas]
END
GO



CREATE PROCEDURE dbo.SP_FILTRAR_MARCAS
(
	@Marca VARCHAR(90)
)
AS
BEGIN
SELECT [IdMarca]
      ,[Marca]
	  ,[IdEstado]
  FROM [dbo].[T_Marcas]
  WHERE [Marca] LIKE '%' + @Marca + '%'
END
GO


CREATE PROCEDURE dbo.SP_INSERTAR_MARCAS
(
	@Marca VARCHAR(90),
	@IdEstado char(1)
)
AS
BEGIN
INSERT INTO [dbo].[T_Marcas]
           ([Marca]
           ,[IdEstado])
     VALUES
           (@Marca, @IdEstado)

	SELECT MAX([IdMarca])
	FROM [dbo].[T_Marcas]
END
GO


CREATE PROCEDURE dbo.SP_MODIFICAR_MARCAS
(
	@IdMarca INT,
	@Marca VARCHAR(90),
	@IdEstado char(1)
)
AS
BEGIN
UPDATE [dbo].[T_Marcas]
   SET [Marca] = @Marca,
       [IdEstado] = @IdEstado
 WHERE [IdMarca] = @IdMarca
END
GO


CREATE PROCEDURE dbo.SP_ELIMINAR_MARCAS
(
	@IdMarca INT
)
AS
BEGIN
DELETE FROM [dbo].[T_Marcas]   
 WHERE [IdMarca] = @IdMarca
 SELECT MAX([IdMarca])
 FROM [dbo].[T_Marcas]
END
GO
