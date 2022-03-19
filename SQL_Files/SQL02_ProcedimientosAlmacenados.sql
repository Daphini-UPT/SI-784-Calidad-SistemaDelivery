USE DB_RESTAURANTE
GO

--Creación de Procedimientos almacenados

--Procedimientos almacenados para Cliente
--1. Insertar Cliente

CREATE PROCEDURE spInsertarCliente
	@nombre varchar(80),
	@apellidos varchar(50),
	@direccion varchar(50),
	@telefono varchar(10)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.cliente
			VALUES (@nombre, @apellidos, @direccion, @telefono)
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--2. Actualizar Cliente
CREATE PROCEDURE spActualizarCliente
	@clienteId int,
	@nombre varchar(80),
	@apellidos varchar(50),
	@direccion varchar(50),
	@telefono varchar(10)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			UPDATE dbo.cliente SET
			CLInombre = @nombre,
			CLIapellidos = @apellidos,
			CLIdireccion = @direccion,
			CLItelefono = @telefono
			WHERE CLIcodigo = @clienteId
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO


--3. Eliminar Cliente
CREATE PROCEDURE spEliminarCliente
	@clienteId int
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DELETE FROM dbo.cliente
			WHERE CLIcodigo = @clienteId
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--4. Listar todos los clientes
CREATE PROCEDURE spListarClientes

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM dbo.cliente
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--5. Buscar cliente por nombre o apellidos
CREATE PROCEDURE spBuscarCliente
	@busqueda varchar(50)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM dbo.cliente
			WHERE CLInombre LIKE '%' + @busqueda + '%' OR CLIapellidos LIKE '%' + @busqueda + '%'
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--6. Verificar si cliente existe por el nombre y apellido
CREATE PROCEDURE spVerificarCliente
	@nombre varchar(80),
	@apellidos varchar(50),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS (
				SELECT CLInombre, CLIapellidos FROM cliente 
				WHERE CLInombre = LTRIM(RTRIM(@nombre)) AND CLIapellidos = LTRIM(RTRIM(@apellidos))
			)
			BEGIN
				SET @existe = 1
			END
			ELSE
			BEGIN
				SET @existe = 0
			END
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--Procedimientos almacenados para Plato
--1. Insertar Plato

CREATE PROCEDURE spInsertarPlato
	@nombre varchar(50),
	@precio float,
	@TPLcodigo int,
	@estado varchar(15)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO dbo.Plato
			VALUES (@nombre, @precio, @TPLcodigo, @estado)
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--2. Actualizar Plato
CREATE PROCEDURE spActualizarPlato
	@platoId int,
	@nombre varchar(50),
	@precio float,
	@TPLcodigo int,
	@estado varchar(15)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			UPDATE dbo.Plato SET
			PLAnombre = @nombre,
			PLAprecio = @precio,
			TPLcodigo = @TPLcodigo,
			PLAestado = @estado
			WHERE PLAcodigo = @platoId
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--3. Eliminar Plato
CREATE PROCEDURE spEliminarPlato
	@platoId int
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			DELETE FROM dbo.Plato
			WHERE PLAcodigo = @platoId
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--4. Listar todos los platos
CREATE PROCEDURE spListarPlatos

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM dbo.Plato
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--5. Buscar plato por nombre
CREATE PROCEDURE spBuscarPlato
	@busqueda varchar(50)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM dbo.Plato
			WHERE PLAnombre LIKE '%' + @busqueda + '%'
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO


--6. Verificar si el plato existe por el nombre
CREATE PROCEDURE spVerificarPlato
	@nombre varchar(50),
	@existe bit output
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS (
				SELECT CLInombre, CLIapellidos FROM cliente 
				WHERE CLInombre = LTRIM(RTRIM(@nombre))
			)
			BEGIN
				SET @existe = 1
			END
			ELSE
			BEGIN
				SET @existe = 0
			END
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--7. Listar tipos de Plato
CREATE PROCEDURE spListarTiposDePlato

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM dbo.Tipo_plato
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

--Procedimientos almacenados para Usuario
--1. Comprobar login de usuario

CREATE PROCEDURE spComprobarUsuario
	@id varchar(30),
	@password varchar(25)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT * FROM dbo.usuario
			WHERE USUid = @id AND USUpassword = @password
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
		END CATCH
END
GO

