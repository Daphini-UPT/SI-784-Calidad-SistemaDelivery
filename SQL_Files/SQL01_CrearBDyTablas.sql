CREATE DATABASE DB_RESTAURANTE
GO

USE DB_RESTAURANTE
GO

--Crear TAblas

--CREANDO LA TABLA  TIPO_EMPLEADO correcto
--drop table dbo.Tipo_empleado;
CREATE TABLE dbo.Tipo_empleado
(
    TEMcodigo int identity(1,1) PRIMARY KEY,
    TEMdescripcion varchar(25)
)

--CREANDO LA TABLA EMPLEADO correcto
--drop table dbo.Empleado;
CREATE TABLE dbo.Empleado
(
    EMPcodigo int identity(1,1) PRIMARY KEY,
    EMPnombres varchar(50),
    EMPapellidos varchar(50),
    EMPemail varchar(25),
    EMPtelefono int,
    EMPdni varchar(8),
    EMPdireccion varchar(50),
	EMPestado varchar(10),
	TEMcodigo int
    FOREIGN KEY (TEMcodigo) REFERENCES dbo.Tipo_empleado(TEMcodigo)
)


--Tabla CLIENTE
if(not exists(select 1 from sys.tables WHERE name = 'cliente'))
CREATE TABLE dbo.cliente(
	CLIcodigo int identity(1,1) NOT NULL,
	CLInombre varchar(80) NOT NULL,
	CLIapellidos varchar(50) NOT NULL,
	CLIdireccion varchar(50) NULL,
	CLItelefono varchar(10) NULL,
	PRIMARY KEY (CLIcodigo)
)
GO


-- FORMA DE PAGO correcto
--drop table dbo.Forma_pago;
CREATE TABLE dbo.Forma_pago
(
    FPAcodigo int identity(1,1) PRIMARY KEY,
    FPAdescripcion varchar(50)

)

-- TABLA TIPO DE PLATO correcto
--drop table dbo.Tipo_plato;
CREATE TABLE dbo.Tipo_plato
(
    TPLcodigo int identity(1,1) PRIMARY KEY,
    TPLnombre varchar(50)
)

-- TABLA PLATO  correcto
--drop table dbo.Plato;
CREATE TABLE dbo.Plato
(
    PLAcodigo int identity(1,1) PRIMARY KEY,
    PLAnombre varchar(50),
    PLAprecio float,
    TPLcodigo int,
	PLAestado varchar(15)
    FOREIGN KEY (TPLcodigo) REFERENCES dbo.Tipo_plato(TPLcodigo)
)

-- TABLA TIPO ENTREGA correcto
--drop table dbo.Tipo_entrega;
CREATE TABLE dbo.Tipo_entrega
(
    TENcodigo int identity(1,1) PRIMARY KEY,
    TENdescripcion varchar(20)
)

--TABLA DATO ENTREGA correcto
--drop table dbo.Dato_entrega;
CREATE TABLE dbo.Dato_entrega
(
    DENcodigo int identity(1,1) PRIMARY KEY,
    DENnombre varchar(50),
	DENapellido varchar(50),
    DENtelefono varchar(10),
    --TENcodigo int,
    --FOREIGN KEY (TENcodigo) REFERENCES dbo.Tipo_entrega(TENcodigo)
)

--TABLA ESTADO CORRECTO
--drop table dbo.Estado;
CREATE TABLE dbo.Estado
(
    ESTcodigo int identity(1,1) PRIMARY KEY,
    ESTdescripcion varchar(50)
)

-- TABLA PEDIDO CORRECTO
--drop table dbo.Pedido;
CREATE TABLE dbo.Pedido
(
    PEDcodigo int identity(1,1) PRIMARY KEY,
    CLIcodigo int,  
    DENcodigo int,
    FPAcodigo int,
    PEDfecha_entrada DATEtime,
	PEDfecha_salida DATEtime,
    PEDprecio float,
	EMPcodigo int,
	ESTcodigo int,
	TENcodigo int
	FOREIGN KEY (TENcodigo) REFERENCES dbo.Tipo_entrega(TENcodigo),
	FOREIGN KEY (ESTcodigo) REFERENCES dbo.Estado(ESTcodigo),
    FOREIGN KEY (CLIcodigo) REFERENCES dbo.Cliente(CLIcodigo),
	FOREIGN KEY (DENcodigo) REFERENCES dbo.Dato_entrega(DENcodigo),
    FOREIGN KEY (EMPcodigo) REFERENCES dbo.Empleado(EMPcodigo),
    FOREIGN KEY (FPAcodigo) REFERENCES dbo.Forma_pago(FPAcodigo)
)

-- TABLA DETALLE PEDIDO CORRECTO
--drop table dbo.Detalle_pedido;
CREATE TABLE dbo.Detalle_pedido
(
    DPEcodigo int identity(1,1) PRIMARY KEY,
	PEDcodigo int,
    PLAcodigo int,  
    DPEcantidad int,
	DPEprecio float,
    FOREIGN KEY (PLAcodigo) REFERENCES dbo.Plato(PLAcodigo),
    FOREIGN KEY (PEDcodigo) REFERENCES dbo.Pedido(PEDcodigo)
)

--Tabla USUARIO
CREATE TABLE dbo.usuario(
	USUcodigo int identity(1,1) NOT NULL PRIMARY KEY,
	USUid varchar(30) NOT NULL,
	USUpassword varchar(25) NOT NULL,
	USUestado char(1) NOT NULL
)
GO
