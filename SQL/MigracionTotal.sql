USE[GD1C2016]
GO

/*---------------------------Creacion Schema---------------------------*/

IF (NOT EXISTS ( SELECT  1 FROM sys.schemas WHERE name = 'MESSI_MAS3' )) 
	BEGIN 
    EXEC('CREATE SCHEMA [MESSI_MAS3] AUTHORIZATION [gd]')
	END
GO

/*---------------------------DROP DE LAS TABLAS---------------------------*/

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Calificacion')
	DROP TABLE MESSI_MAS3.Calificacion

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Factura_detalle')
	DROP TABLE MESSI_MAS3.Factura_detalle

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Factura')
	DROP TABLE MESSI_MAS3.Factura

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'FormaDePago')
	DROP TABLE MESSI_MAS3.FormaDePago

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Compra')
	DROP TABLE MESSI_MAS3.Compra
	
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Oferta')
	DROP TABLE MESSI_MAS3.Oferta

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Rubro_x_Publicacion')
	DROP TABLE MESSI_MAS3.Rubro_x_Publicacion

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Funcionalidad_Rol')
	DROP TABLE MESSI_MAS3.Funcionalidad_Rol

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Funcionalidad')
	DROP TABLE MESSI_MAS3.Funcionalidad

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Rol_Usuario')
	DROP TABLE MESSI_MAS3.Rol_Usuario

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Rol')
	DROP TABLE MESSI_MAS3.Rol

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Empresa')
	DROP TABLE MESSI_MAS3.Empresa

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Rubro')
	DROP TABLE MESSI_MAS3.Rubro

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Cliente')
	DROP TABLE MESSI_MAS3.Cliente

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'TipoDocumento')
	DROP TABLE MESSI_MAS3.TipoDocumento

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Publicacion')
	DROP TABLE MESSI_MAS3.Publicacion

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'tipoPublicacion')
	DROP TABLE MESSI_MAS3.tipoPublicacion

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Estado')
	DROP TABLE MESSI_MAS3.Estado

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Usuario')
	DROP TABLE MESSI_MAS3.Usuario

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Visibilidad')
	DROP TABLE MESSI_MAS3.Visibilidad

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Domicilio')
	DROP TABLE MESSI_MAS3.Domicilio

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Localidad')
	DROP TABLE MESSI_MAS3.Localidad

GO

------------------- DROP PROCEDURES ---------------------------
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 ORDER BY [name])

WHILE @name is not null
BEGIN
    SELECT @SQL = 'DROP PROCEDURE [MESSI_MAS3].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Procedure: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 AND [name] > @name ORDER BY [name])
END
GO

------------------- DROP FUNCTIONS ---------------------------
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 ORDER BY [name])

WHILE @name IS NOT NULL
BEGIN
    SELECT @SQL = 'DROP FUNCTION [MESSI_MAS3].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Function: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 AND [name] > @name ORDER BY [name])
END
GO

/*---------------------------CREACION TABLAS---------------------------*/

-- -----------------------------------------------------
-- Table MESSI_MAS3.Funcionalidad
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Funcionalidad (
   funcionalidad_id INT PRIMARY KEY NOT NULL IDENTITY,
   funcionalidad_descripcion NVARCHAR(255) NULL
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Usuario
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Usuario (
  usuario_id INT PRIMARY KEY NOT NULL IDENTITY,
  usuario_nombreUsuario NVARCHAR(255) NOT NULL,  --AGREGAR UNIQUE!!!
  usuario_contrasenia NVARCHAR(255) NULL,				--Cambiado de NOT NULL a NULL y el nombre a 'contrasenia'
  usuario_deleted INT DEFAULT 0,						--flag de Baja logica
  usuario_intentos INT DEFAULT 0,
  usuario_primeraPublicacion INT DEFAULT 1 -- significa True y luego de hacer la primera publicacion se setea en 0
  )
 


-- -----------------------------------------------------
-- Table MESSI_MAS3.Rol
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rol (
  rol_id INT PRIMARY KEY NOT NULL IDENTITY,
  rol_nombre NVARCHAR(255) NULL,
  rol_habilitado INT DEFAULT 1						--Si se da de baja, lo seteamos en 0
  )



  CREATE TABLE MESSI_MAS3.TipoDocumento(
	tipoDocumento_id INT PRIMARY KEY NOT NULL IDENTITY,
	tipoDocumento_nombre VARCHAR(100)
	 )

GO

-- -----------------------------------------------------
-- Table MESSI_MAS3.Localidad
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Localidad (
  localidad_id INT PRIMARY KEY NOT NULL IDENTITY,
  localidad_nombre NVARCHAR(255) NULL			--cambio de Not null a NULL
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Domicilio
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Domicilio (
  domicilio_idDomicilio INT PRIMARY KEY NOT NULL IDENTITY,
  domicilio_localidad_id INT REFERENCES MESSI_MAS3.Localidad(Localidad_id),
  domicilio_calle NVARCHAR(100) NOT NULL,
  domicilio_altura NUMERIC(18,0) NOT NULL,
  domicilio_piso NUMERIC(18,0) NOT NULL,
  domicilio_departamento NVARCHAR(50) NOT NULL,
  domicilio_ciudad NVARCHAR(45) NULL,					--CAMBIO DE DEFAULT 'BUENOS AIRES' A NULL							
  domicilio_codigoPostal NVARCHAR(50) NOT NULL)


																							

-- -----------------------------------------------------
-- Table MESSI_MAS3.Cliente
-- -----------------------------------------------------

CREATE TABLE MESSI_MAS3.Cliente (
  cliente_nombre NVARCHAR(255) NOT NULL,
  cliente_apellido NVARCHAR(255) NOT NULL,
  cliente_DNI NUMERIC(18,0) NOT NULL UNIQUE,
  cliente_fechaNacimiento DATETIME NOT NULL,
  cliente_fechaCreacion DATETIME NOT NULL,
  cliente_idDomicilio INT REFERENCES MESSI_MAS3.Domicilio(domicilio_idDomicilio),
  cliente_id INT PRIMARY KEY REFERENCES MESSI_MAS3.Usuario(usuario_id),
  cliente_tel NUMERIC(15,0) DEFAULT 0,
  cliente_mail NVARCHAR(255) NULL,	
  cliente_tipoDocumento_id INT REFERENCES MESSI_MAS3.TipoDocumento(tipoDocumento_id) ,
  cliente_calificacionPromedio INT DEFAULT 0 NULL)



-- -----------------------------------------------------
-- Table MESSI_MAS3.Rubro
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rubro (
  rubro_id INT PRIMARY KEY NOT NULL IDENTITY,
  rubro_descripcionCorta NVARCHAR(255) NOT NULL,
  rubro_descripcionLarga NVARCHAR(255) NULL)


																				 

-- -----------------------------------------------------
-- Table MESSI_MAS3.Empresa
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Empresa (
  empresa_razonSocial NVARCHAR(255) NOT NULL,
  empresa_cuit NVARCHAR(50) NOT NULL,
  empresa_id INT PRIMARY KEY REFERENCES MESSI_MAS3.Usuario (usuario_id),
  empresa_calificacionPromedio INT DEFAULT 0 NULL,						--Cambio de Not null a NULL
  empresa_fechaCreacion DATETIME NOT NULL,
  empresa_idDomicilio INT REFERENCES MESSI_MAS3.Domicilio (domicilio_idDomicilio),
  empresa_telefono VARCHAR(10) NULL,													--Cambie de NOT NULL a NULL
  empresa_rubroId INT REFERENCES MESSI_MAS3.Rubro (rubro_id) NULL,
  empresa_mail NVARCHAR(255),
  empresa_nombreContacto NVARCHAR(255) DEFAULT NULL)
-- -----------------------------------------------------
-- Table MESSI_MAS3.Estado
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Estado (
  estado_id INT PRIMARY KEY NOT NULL IDENTITY,
  estado_nombre NVARCHAR(255) NOT NULL)



-- -----------------------------------------------------
-- Table MESSI_MAS3.Visibilidad
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Visibilidad (
  visibilidad_id INT PRIMARY KEY NOT NULL IDENTITY,
  visibilidad_codigo INT NULL,
  visibilidad_descripcion NVARCHAR(255) NOT NULL,
  visibilidad_precio NUMERIC(18,2) NOT NULL,
  visibilidad_porcentaje NUMERIC(18,2) NOT NULL,
  visibilidad_costoEnvio NUMERIC(18,2) NOT NULL)



-- -----------------------------------------------------
-- Table MESSI_MAS3.tipoPublicacion
-- -----------------------------------------------------
    
CREATE TABLE MESSI_MAS3.tipoPublicacion(
   tipoPublicacion_id INT PRIMARY KEY NOT NULL IDENTITY,
   tipoPublicacion_nombre NVARCHAR(255) NOT NULL,
   tipoPublicacion_tieneEnvio INT DEFAULT 1)


-- -----------------------------------------------------
-- Table MESSI_MAS3.Publicacion
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Publicacion (
  publicacion_id INT PRIMARY KEY NOT NULL IDENTITY,
  publicacion_codigo NUMERIC(18,0), --CAMBIADO DE INT A NUMERIC COMO LA TABLA MAESTRA
  publicacion_idEstado INT REFERENCES MESSI_MAS3.Estado (estado_id),
  publicacion_idVisibilidad INT REFERENCES MESSI_MAS3.Visibilidad (visibilidad_id),
  publicacion_idUsuario INT REFERENCES MESSI_MAS3.Usuario (usuario_id),
  publicacion_fechaInicio DATETIME NOT NULL,
  publicacion_fechaFin DATETIME NOT NULL,
  publicacion_descripcion VARCHAR(255) NULL,
  publicacion_tipoPublicacionId INT REFERENCES MESSI_MAS3.tipoPublicacion(tipoPublicacion_id),
  publicacion_minimoSubasta NUMERIC(10,2) NULL,			--DUDA MIRAR KOIFFO EL TIPO DE LA VARIABLE
  publicacion_precio NUMERIC(18,2),
  publicacion_idRubro INT NOT NULL,
  publicacion_stock NUMERIC(18,0) NULL)

-- -----------------------------------------------------
-- Table MESSI_MAS3.Rubro_x_Publicacion
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rubro_x_Publicacion (
  idPublicacion INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  idRubro INT REFERENCES MESSI_MAS3.Rubro (rubro_id))
  
-- -----------------------------------------------------
-- Table MESSI_MAS3.RolUsuario
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rol_Usuario (
  Usuario_id INT REFERENCES MESSI_MAS3.Usuario (usuario_id),
  Rol_id INT REFERENCES MESSI_MAS3.Rol (rol_id),
  deleted INT DEFAULT 0 --nuevo cambio por correccion del der
)

-- -----------------------------------------------------
-- Table MESSI_MAS3.FuncionalidadRol
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Funcionalidad_Rol (
  Rol_func_id INT REFERENCES MESSI_MAS3.Rol(rol_id),
  Funcionalidad_rol_id INT REFERENCES MESSI_MAS3.Funcionalidad (funcionalidad_id),
  deleted INT DEFAULT 0 --nuevo cambio por correccion del der
  
  )

-- -----------------------------------------------------
-- Table MESSI_MAS3.Compra
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Compra (
  compra_id INT PRIMARY KEY NOT NULL IDENTITY,
  compras_publicacion_id INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  compras_fecha DATETIME NOT NULL,
  compras_personaComprador_id INT REFERENCES MESSI_MAS3.Cliente(cliente_id),
  compras_cantidad NUMERIC(18,0) NOT NULL, )
 
-- -----------------------------------------------------
-- Table MESSI_MAS3.Oferta
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Oferta (
  oferta_id INT PRIMARY KEY NOT NULL IDENTITY,
  oferta_valor NUMERIC(18,2) NOT NULL,
  oferta_persona_id INT REFERENCES MESSI_MAS3.Cliente(cliente_id),						
  oferta_idPublicacion INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  oferta_fecha DATETIME NOT NULL,
  oferta_ganador INT DEFAULT 0
  )


-- -----------------------------------------------------
-- Table MESSI_MAS3.Calificacion										
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Calificacion (
  calificacion_id INT PRIMARY KEY NOT NULL IDENTITY,
  calificacion_idPersonaCalificador INT REFERENCES MESSI_MAS3.Cliente(cliente_id), 
  calificacion_compraId INT REFERENCES MESSI_MAS3.Compra(compra_id),
  calificacion_fecha DATETIME NULL,
  calificacion_cantidadEstrellas NUMERIC(18,0) NULL,
  calificacion_detalle NVARCHAR(255) NULL,
  calificacion_pendiente INT DEFAULT 1 NULL,					--ACA!!!
  calificacion_idusuarioCalificado INT REFERENCES MESSI_MAS3.Usuario(usuario_id),
  calificacion_codigo NUMERIC (18,0)
)
 

-- -----------------------------------------------------
-- Table MESSI_MAS3.FormaDePago												
-- -----------------------------------------------------

CREATE TABLE MESSI_MAS3.FormaDePago (
  formaDePago_id INT PRIMARY KEY NOT NULL IDENTITY,
  formadePago_nombre NVARCHAR(255) NULL
  )

-- -----------------------------------------------------
-- Table MESSI_MAS3.Factura
-- -----------------------------------------------------

CREATE TABLE MESSI_MAS3.Factura (
  factura_id INT PRIMARY KEY NOT NULL IDENTITY,
  factura_fecha DATETIME NOT NULL,
  factura_importeTotal NUMERIC(18,2) NOT NULL,
  factura_idVendedor INT REFERENCES MESSI_MAS3.Usuario (usuario_id),
  factura_numero NUMERIC(18,0) NOT NULL,
  factura_formaDePago INT REFERENCES MESSI_MAS3.FormaDePago (formaDePago_id),
  factura_publicacionId INT REFERENCES MESSI_MAS3.Publicacion(publicacion_id)
)



-- -----------------------------------------------------
-- Table MESSI_MAS3.Factura_detalle
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Factura_detalle (
  FacturaDetalle_valorItem NUMERIC(18,2) NOT NULL,
  facturaDetalle_numero NUMERIC(18,0) NOT NULL,
  facturaDetalle_item NVARCHAR(255) NULL,
  facturaDetalle_id INT REFERENCES MESSI_MAS3.Factura (factura_id), --cambiado a FK SOLO, LE SAQUE QUE SEA PK
  facturaDetall_cantidadItems NUMERIC(18,0) NOT NULL
 )

 GO
 
 
/*--------------------------MIGRACIONES---------------------------*/

--Faltaria meter un procedure que valide que no esta repetido el dni, ni el cuit ni MAIL
--Dejarlo como UNIQUE el CUIT, DNI y Mail



CREATE PROCEDURE [MESSI_MAS3].[meterDatosFijos]
AS 
BEGIN
	set nocount on;
	set xact_abort on;

	--ROLES
	INSERT INTO MESSI_MAS3.Rol(rol_nombre) VALUES ('Administrativo')
	INSERT INTO MESSI_MAS3.Rol(rol_nombre) VALUES ('Cliente')
	INSERT INTO MESSI_MAS3.Rol(rol_nombre) VALUES ('Empresa')

	--FORMAS DE PAGO
	INSERT INTO MESSI_MAS3.FormaDePago(formadePago_nombre) VALUES ('Efectivo')
	INSERT INTO MESSI_MAS3.FormaDePago(formadePago_nombre) VALUES ('Tarjeta de Credito')

	--ESTADOS
	INSERT INTO MESSI_MAS3.Estado(estado_nombre) VALUES ('Borrador')
	INSERT INTO MESSI_MAS3.Estado(estado_nombre) VALUES ('Activa')
	INSERT INTO MESSI_MAS3.Estado(estado_nombre) VALUES ('Pausada')
	INSERT INTO MESSI_MAS3.Estado(estado_nombre) VALUES ('Finalizada')
	
	-- VISIBILIDADES
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio,visibilidad_costoEnvio) VALUES('10002','Platino','0.10','180.00','20.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio,visibilidad_costoEnvio) VALUES('10003','Oro','0.15','140.00','30.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio,visibilidad_costoEnvio) VALUES('10004','Plata','0.20','100.00','40.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio,visibilidad_costoEnvio) VALUES('10005','Bronce','0.30','60.00','50.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio,visibilidad_costoEnvio) VALUES('10006','Gratis','0.00','0.00','0.00')

	--TIPO PUBLICACION
	INSERT INTO MESSI_MAS3.tipoPublicacion(tipoPublicacion_nombre) VALUES ('Subasta')
	INSERT INTO MESSI_MAS3.tipoPublicacion(tipoPublicacion_nombre) VALUES ('Oferta')


	--TIPO DOCUMENTO

	INSERT INTO MESSI_MAS3.TipoDocumento(tipoDocumento_nombre) VALUES ('DNI')
	INSERT INTO MESSI_MAS3.TipoDocumento(tipoDocumento_nombre) VALUES ('Pasaporte')
	INSERT INTO MESSI_MAS3.TipoDocumento(tipoDocumento_nombre) VALUES ('Libreta civica')

	--LOCALIDAD

	INSERT INTO MESSI_MAS3.Localidad(localidad_nombre) VALUES ('CABA')
	INSERT INTO MESSI_MAS3.Localidad(localidad_nombre) VALUES ('Escobar')
	INSERT INTO MESSI_MAS3.Localidad(localidad_nombre) VALUES ('La Plata')
	


END
GO

CREATE PROCEDURE [MESSI_MAS3].crearUsuario(@usuario NVARCHAR(255),@pass VARCHAR(16))
AS BEGIN TRANSACTION
	INSERT INTO MESSI_MAS3.Usuario(usuario_nombreUsuario,usuario_contrasenia) 
	VALUES (@usuario,SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 64))
	COMMIT
GO
-- sp genero el usuario y devuelvo el id, me sirve para insertarlo de nuevo
CREATE PROCEDURE [MESSI_MAS3].[generarUsuario](@usuario NVARCHAR(255),@pass VARCHAR(16),@ultimoIdInsertado INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO MESSI_MAS3.Usuario(usuario_nombreUsuario,usuario_contrasenia, usuario_primeraPublicacion) 
	VALUES (@usuario,SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 64), 0)
	SELECT @ultimoIdInsertado = SCOPE_IDENTITY();
	RETURN
END
GO  


-- inserto el domicilio y devuelvo el ultimo
CREATE PROCEDURE [MESSI_MAS3].[generarDomicilio](@calle NVARCHAR(100),@altura NUMERIC(18,0), @piso NUMERIC(18,0),@departamento NVARCHAR(50), @ciudad NVARCHAR(45), @codigoPostal NVARCHAR(50), @ultimoIdInsertado INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	-- INSERTO EL NUEVO DOMICILIO



	INSERT INTO MESSI_MAS3.Domicilio(domicilio_calle,domicilio_altura, domicilio_piso,domicilio_departamento,domicilio_ciudad, domicilio_localidad_id, domicilio_codigoPostal) 
	VALUES (@calle,@altura,@piso, @departamento, @ciudad, NULL, @codigoPostal)
	
	
	-- OBTENGO EL ULTIMO ID 
	SELECT @ultimoIdInsertado = SCOPE_IDENTITY();
	
	RETURN
	
END
GO  

--SP PARA MIGRAR TODOS LAS Clientes DE LA TABLA MAESTRA
CREATE PROCEDURE [MESSI_MAS3].[migrarClientes]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUsuario INT,
			@nombre NVARCHAR(255),
			@apellido NVARCHAR(255),
			@documento NUMERIC(18,0),
			@fechaNac DATETIME,
			@mail NVARCHAR(255),
			@calle NVARCHAR(255),
			@numero NUMERIC(18,0),
			@piso NUMERIC(18,0),
			@dpto NVARCHAR(255),
			@codigoPostal NVARCHAR(255)

	DECLARE cur CURSOR FOR

	SELECT DISTINCT 
		Cli_Nombre,
		Cli_Apeliido,
		Cli_Dni,
		Cli_Fecha_Nac,
		Cli_Mail,
		Cli_Dom_Calle,
		Cli_Nro_Calle,
		Cli_Piso,
		Cli_Depto,
		Cli_Cod_Postal
	FROM 
		gd_esquema.Maestra
	WHERE
		Cli_Dni IS NOT NULL AND Cli_Mail IS NOT NULL

	OPEN cur
	FETCH NEXT FROM cur
		INTO 
		@nombre,
		@apellido,
		@documento,
		@fechaNac,
		@mail,
		@calle,
		@numero,
		@piso,
		@dpto,
		@codigoPostal

	WHILE(@@FETCH_STATUS = 0)
		BEGIN
			DECLARE @pass varchar(16)
			SET @pass = '123456'
			EXECUTE MESSI_MAS3.generarUsuario @documento,@pass,@ultimoIdInsertado = @idUsuario OUTPUT; --esta bien esta linea?? por el documento pasado como param
			DECLARE @idRol int;
			SET @idRol = (select rol_id from MESSI_MAS3.Rol where rol_nombre = 'Cliente')
			INSERT INTO MESSI_MAS3.Rol_Usuario(Rol_id,Usuario_id)
			VALUES(@idRol, @idUsuario)
			DECLARE @idDomicilio int;
			EXECUTE MESSI_MAS3.generarDomicilio @calle,@numero,@piso,@dpto,NULL,@codigoPostal,@ultimoIdInsertado = @idDomicilio OUTPUT;


			INSERT INTO MESSI_MAS3.Cliente(
				cliente_nombre,
				cliente_apellido,
				cliente_DNI,
				cliente_idDomicilio,
				cliente_fechaNacimiento,
				cliente_fechaCreacion,
				cliente_id,
				cliente_tipoDocumento_id,
				cliente_mail
				)
			VALUES (
				@nombre,
				@apellido,
				@documento,
				@idDomicilio,
				@fechaNac,
				GETDATE(),
				@idUsuario,
				1,
				@mail)
		
		
				
		FETCH NEXT FROM cur
		INTO 
			@nombre,
			@apellido,
			@documento,
			@fechaNac,
			@mail,
			@calle,
			@numero,
			@piso,
			@dpto,
			@codigoPostal
		END
	CLOSE cur 
	DEALLOCATE cur
	
	
END
GO

--MIGRO LAS EMPRESAS
CREATE PROCEDURE [MESSI_MAS3].[migrarEmpresas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUsuario INT,
			@razonSocial NVARCHAR(255) ,
			@telefono INT,
			@calle NVARCHAR(50),
			@numero  INT,
			@piso NUMERIC(18,0),
			@dpto NVARCHAR(50) ,
			@codigoPostal NVARCHAR(50) ,
			@cuit NVARCHAR(50) ,
			@fechaCreacion DATETIME,
			@mail NVARCHAR(255)
	DECLARE cur CURSOR FOR
	SELECT DISTINCT 
		Publ_Empresa_Razon_Social,
		Publ_Empresa_Cuit,
		Publ_Empresa_Fecha_Creacion,
		Publ_Empresa_Mail,
		Publ_Empresa_Dom_Calle,
		Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso,
		Publ_Empresa_Depto,
		Publ_Empresa_Cod_Postal
	FROM 
		gd_esquema.Maestra
	WHERE
		Publ_Empresa_Cuit IS NOT NULL AND Publ_Empresa_Mail IS NOT NULL;
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@razonSocial,
		@cuit,
		@fechaCreacion,
		@mail,
		@calle,
		@numero,
		@piso,
		@dpto,
		@codigoPostal
	WHILE(@@FETCH_STATUS = 0)
		BEGIN
			DECLARE @pass varchar(16)
			SET @pass = '123456'
			EXECUTE MESSI_MAS3.generarUsuario @cuit, @pass, @ultimoIdInsertado = @idUsuario OUTPUT;
			DECLARE @idRol int;
			DECLARE @idDomicilio int;
			EXECUTE MESSI_MAS3.generarDomicilio @calle,@numero,@piso,@dpto,NULL,@codigoPostal,@ultimoIdInsertado = @idDomicilio OUTPUT;
			SET @idRol = (select rol_id from MESSI_MAS3.Rol where rol_nombre = 'Empresa')
			INSERT INTO MESSI_MAS3.Rol_Usuario(Rol_id,Usuario_id)
			VALUES(@idRol,@idUsuario)
			
			
			INSERT INTO MESSI_MAS3.Empresa(
				empresa_razonSocial,
				empresa_telefono ,
				empresa_idDomicilio,
				empresa_cuit,
				empresa_id,
				empresa_fechaCreacion,
				empresa_rubroId,
				empresa_mail)
			VALUES (
				@razonSocial,
				@telefono,
				@idDomicilio,
				@cuit,
				@idUsuario,
				@fechaCreacion,
				NULL,
				@mail)
			
				
		FETCH NEXT FROM cur
		INTO 
			@razonSocial,
			@cuit,
			@fechaCreacion,
			@mail,
			@calle,
			@numero,
			@piso,
			@dpto,
			@codigoPostal
		END
	CLOSE cur 
DEALLOCATE cur
	
		
END
GO

--sp para migrar los rubros
CREATE PROCEDURE [MESSI_MAS3].[migrarRubros]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@descripcionCorta NVARCHAR(255),
			@descripcionLarga NVARCHAR(255)
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Rubro_Descripcion
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@descripcionCorta
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO MESSI_MAS3.Rubro(rubro_descripcionCorta, rubro_descripcionLarga)
		VALUES (@descripcionCorta, NULL)

		FETCH NEXT FROM cur
		INTO 
			@descripcionCorta
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO

CREATE PROCEDURE [MESSI_MAS3].[ConvertirCalificacion](@calificacion INT,@calificacionConvertida INT OUTPUT)
AS BEGIN
set nocount on;
set xact_abort on;
DECLARE @califOrig INT, @califConver INT
SET @califOrig = @calificacion
SET @califConver = @califOrig/2

--SELECT @calificacionConvertida = @calificacion /2 
IF( @califConver = 0 )
	BEGIN
		SET @califConver = 1
	END

SELECT @calificacionConvertida = @califConver

RETURN @calificacionConvertida
END
GO

CREATE FUNCTION [MESSI_MAS3].[adiestrarCalif](@calificacion INT)
RETURNS INTEGER
AS BEGIN
DECLARE @califOrig INT, @califConver INT
SET @califOrig = @calificacion
SET @califConver = @califOrig/2

--SELECT @calificacFionConvertida = @calificacion /2 
IF( @califConver = 0 )
	BEGIN
		SET @califConver = 1
	END

RETURN @califConver
END
GO

CREATE FUNCTION  MESSI_MAS3.coincidenCodPubliCompra(@codigoPubli NUMERIC(18,0), @idCompra INT)
RETURNS INTEGER
AS BEGIN
DECLARE @codigoPubliEnIdCompra NUMERIC(18,0), @idPublicacionEnCompra INT
SELECT @idPublicacionEnCompra = compras_publicacion_id FROM MESSI_MAS3.Compra WHERE @idCompra = compra_id
SELECT @codigoPubliEnIdCompra = publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacionEnCompra
DECLARE @BOLEANLOCO INT
IF (@codigoPubli = @codigoPubliEnIdCompra)
 BEGIN 
	SET @BOLEANLOCO= 1 
 END 

 RETURN @BOLEANLOCO
END
GO

CREATE PROCEDURE [MESSI_MAS3].[migrarOfertas]			--SIN GANADORES DE LAS SUBASTAS
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUser INT, 
			@dni NUMERIC(18,0),
			@oferta_monto NUMERIC(18,0),
			@ofertaFecha DATETIME,
			@codPubli NUMERIC(18,0),
			@idPubli INT
			
	DECLARE cur CURSOR FOR
	
	SELECT 
		Oferta_Monto,	
		Oferta_Fecha,	
		Cli_Dni,
		Publicacion_Cod		
	FROM gd_esquema.MAESTRA
	WHERE 
	Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND  Oferta_Fecha IS NOT NULL AND Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NULL AND (Publ_Cli_Dni IS NOT NULL OR Publ_Empresa_Cuit IS NOT NULL)
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@oferta_monto,
			@ofertaFecha,
			@dni,
			@codPubli
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		SET @idUser = (SELECT cliente_id FROM MESSI_MAS3.Cliente WHERE( @dni = cliente_DNI))
		SET @idPubli = (SELECT publicacion_id FROM MESSI_MAS3.Publicacion WHERE (@CodPubli = publicacion_codigo))

		INSERT INTO 
		MESSI_MAS3.Oferta(oferta_valor,	
		oferta_persona_id,
		oferta_idPublicacion,
		oferta_fecha,
		oferta_ganador)
		VALUES (@oferta_monto,
		 @idUser, 
		 @idPubli,
		 @ofertaFecha,
			0 --POR AHORA TODOS EN 0 LOS DEJAMOS, no migramos los ganadores de las subastas
		 )

		FETCH NEXT FROM cur
		INTO @oferta_monto,
			@ofertaFecha,
			@dni,
			@codPubli
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO

CREATE FUNCTION [MESSI_MAS3].[obtenerPublicacionIdDadoCodigo](@codigoPubli INT)
RETURNS INTEGER
AS BEGIN
DECLARE @idPubli INT
SELECT @idPubli = publicacion_id FROM MESSI_MAS3.Publicacion WHERE publicacion_codigo = @codigoPubli

RETURN @idPubli;
END
GO


CREATE FUNCTION [MESSI_MAS3].[obtenerIdUsuarioGanadorSegunPubID](@idPublicacion INT)
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER, 
			@ofid INT,
			@ofValor NUMERIC(18,2),
			@ofidPub INT,
			@ofFecha DATETIME
	SELECT TOP 1
		@retorno = oferta_persona_id
	FROM 
		MESSI_MAS3.Oferta
	WHERE oferta_idPublicacion = @idPublicacion ORDER BY oferta_valor DESC

	RETURN @retorno;
END
GO

CREATE PROCEDURE [MESSI_MAS3].[buscarGanadoresOfertas] --UPDATEAR LOS GANADORES DE LAS OFERTAS
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUserGanador INT, 
			@idPubli INT,
			@precioSubastado NUMERIC(18,2),
			@ofertaFecha DATETIME,
			@cantidadComprada NUMERIC(18,0)
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		oferta_idPublicacion		
	FROM MESSI_MAS3.Oferta

	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@idPubli
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		SET @idUserGanador = NULL
		SET @idUserGanador = MESSI_MAS3.obtenerIdUsuarioGanadorSegunPubID(@idPubli)
		DECLARE @ofertaMayor NUMERIC(18,2) 
		SET @ofertaMayor = (SELECT TOP 1 oferta_valor FROM MESSI_MAS3.Oferta WHERE (oferta_persona_id = @idUserGanador AND oferta_idPublicacion = @idPubli) ORDER BY oferta_valor DESC)
		UPDATE MESSI_MAS3.Oferta SET oferta_ganador = 1  WHERE (oferta_persona_id = @idUserGanador AND oferta_idPublicacion = @idPubli AND oferta_valor = @ofertaMayor)

		FETCH NEXT FROM cur
		INTO @idPubli
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO


/*--------------------------Calculo las calificaciones promedio---------------------------*/
CREATE FUNCTION [MESSI_MAS3].[esEmpresa](@idUser INT)
RETURNS INTEGER
AS BEGIN
DECLARE @idlocoUsuario INT, @esEmpresa INT, @idEmpresa INT
SET @esEmpresa = 0
SET @idlocoUsuario = @idUser

SELECT @esEmpresa = empresa_id FROM MESSI_MAS3.Empresa WHERE @idlocoUsuario = empresa_id

RETURN @esEmpresa

END
GO


CREATE PROCEDURE [MESSI_MAS3].[insertarCalificacionPromedio] --UPDATEAR LOS GANADORES DE LAS OFERTAS
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUserCalificado int,
			@promedioEstrellasInt int

	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
   calificacion_idusuarioCalificado,
   FLOOR(AVG(calificacion_cantidadEstrellas)) AS PROMEDIO
	FROM
   MESSI_MAS3.Calificacion
   GROUP BY calificacion_idusuarioCalificado


	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@idUserCalificado,
			@promedioEstrellasInt

	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
	IF (MESSI_MAS3.esEmpresa(@idUserCalificado) = 0)
		BEGIN
		UPDATE MESSI_MAS3.Cliente SET cliente_calificacionPromedio = @promedioEstrellasInt  WHERE (cliente_id = @idUserCalificado)
		END
	ELSE
		BEGIN
			UPDATE MESSI_MAS3.Empresa SET empresa_calificacionPromedio = @promedioEstrellasInt  WHERE (empresa_id = @idUserCalificado)
		END
		FETCH NEXT FROM cur
		INTO @idUserCalificado,
			@promedioEstrellasInt
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO

/*---------------------------INSERCION DE FUNCIONALIDADES---------------------------*/
CREATE PROCEDURE [MESSI_MAS3].crearFuncionalidades
AS
BEGIN
INSERT INTO Funcionalidad (funcionalidad_descripcion) VALUES ('ABM ROL'),('ABM USUARIO'),('ABM RUBRO'),('ABM VISIBILIDAD'),('PUBLICAR'),('COMPRAR/OFERTAR'),('HISTORIAL DE CLIENTE'),('CALIFICAR AL VENDEDOR'),('CONSULTAR FACTURAS'),('LISTADO ESTADISTICO') 
END
GO

/*---------------------------INSERCION DE ADMINISTRADOR---------------------------*/
CREATE PROCEDURE [MESSI_MAS3].[crearAdmin]
AS
BEGIN
EXEC MESSI_MAS3.crearUsuario 'admin','w23e'
DECLARE @Uid int
DECLARE @Rid int
SELECT @Uid=usuario_id FROM Usuario WHERE usuario_nombreUsuario='admin'
SELECT @Rid=rol_id FROM Rol WHERE rol_nombre='Administrativo'
INSERT INTO MESSI_MAS3.Funcionalidad_Rol (Rol_func_id,Funcionalidad_rol_id) SELECT @Rid,funcionalidad_id FROM MESSI_MAS3.Funcionalidad WHERE funcionalidad_descripcion LIKE 'ABM %'
INSERT INTO MESSI_MAS3.Rol_Usuario (Usuario_id,Rol_id) VALUES (@Uid,@Rid)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol (Rol_func_id,Funcionalidad_rol_id) VALUES (1,10) --funcionalidad listado estadistico
END
GO

/*
FALTA AGREGAR campo nombre al usuario en vez de que este en empresa y cliente Y CAMBIARLO EN DER, y ver que funcionalidades agregar
EL nombre del admin es Administrador General
*/




/*--------------------------------SP LOGIN---------------------------------------*/


CREATE PROCEDURE [MESSI_MAS3].validar_usuario (@nombreUsuario NVARCHAR(255), @password NVARCHAR(255))
AS 
BEGIN
	IF EXISTS (SELECT 1 FROM MESSI_MAS3.Usuario 
  WHERE usuario_nombreUsuario = @nombreUsuario AND usuario_contrasenia=@password AND usuario_deleted = 0)
   BEGIN
    RETURN 1
	 END
	RETURN -1
END
GO

CREATE PROCEDURE [MESSI_MAS3].getRoles (@id int)
AS
BEGIN
	SELECT MESSI_MAS3.Rol.rol_id, rol_nombre FROM MESSI_MAS3.Rol_Usuario,MESSI_MAS3.Rol WHERE Usuario_id=@id AND MESSI_MAS3.Rol_Usuario.Rol_id = MESSI_MAS3.Rol.rol_id AND rol_habilitado=1
END
GO

CREATE PROCEDURE [MESSI_MAS3].getID (@nombreUsuario NVARCHAR(255))
AS
DECLARE @id int
BEGIN
	SELECT @id= usuario_id FROM MESSI_MAS3.Usuario WHERE usuario_nombreUsuario=@nombreUsuario
	RETURN @id
END
GO

/*CREATE PROCEDURE [MESSI_MAS3].getMail (@id int)
AS
BEGIN
	SELECT  usuario_mail FROM MESSI_MAS3.Usuario WHERE usuario_id=@id
END
GO*/

CREATE PROCEDURE [MESSI_MAS3].existe_usuario (@nombreUsuario NVARCHAR(255))
AS
BEGIN
	IF EXISTS (SELECT 1 FROM MESSI_MAS3.Usuario 
  WHERE usuario_nombreUsuario = @nombreUsuario AND usuario_deleted = 0)
   BEGIN
    RETURN 1
	 END
	RETURN -1
END
GO

/*
CREATE PROCEDURE [MESSI_MAS3].getTelefono (@idUsuario int)
AS 
BEGIN
	DECLARE @tel int
	SELECT @tel = usuario_telefono FROM MESSI_MAS3.Usuario WHERE usuario_id = @idUsuario
	RETURN @tel
END
GO*/

CREATE PROCEDURE [MESSI_MAS3].traer_intentos (@idUsuario int)
AS 
BEGIN
	DECLARE @cant int
	SELECT @cant = usuario_intentos FROM MESSI_MAS3.Usuario WHERE usuario_id = @idUsuario
	RETURN @cant
END
GO

CREATE PROCEDURE [MESSI_MAS3].vaciar_intentos (@idUsuario int)
AS 
BEGIN
	UPDATE MESSI_MAS3.Usuario SET usuario_intentos=0  WHERE usuario_id = @idUsuario
END
GO

CREATE PROCEDURE [MESSI_MAS3].aumentar_intentos (@idUsuario int)
AS 
BEGIN
	UPDATE MESSI_MAS3.Usuario SET usuario_intentos=usuario_intentos+1  WHERE usuario_id = @idUsuario
END
GO


/*-----------------------------------SP ABM ROL----------------------------------*/

/*------ABM DE ROL------*/
CREATE PROCEDURE MESSI_MAS3.get_funcionalidades(@rol nvarchar(255))
AS				
BEGIN
	SELECT funcionalidad_id, funcionalidad_descripcion FROM MESSI_MAS3.Funcionalidad, MESSI_MAS3.Funcionalidad_Rol, MESSI_MAS3.Rol
	WHERE funcionalidad_id = Funcionalidad_rol_id  AND
	rol_id = Rol_func_id  AND
	rol_nombre = @rol
END
GO

CREATE PROCEDURE MESSI_MAS3.get_funcionalidades_que_no_tiene(@rol nvarchar(255))
AS
BEGIN 
SELECT funcionalidad_id, funcionalidad_descripcion FROM MESSI_MAS3.FUNCIONALIDAD
WHERE NOT EXISTS (SELECT 1 FROM MESSI_MAS3.Funcionalidad_Rol, MESSI_MAS3.ROL
	WHERE Funcionalidad_rol_id  = funcionalidad_id AND 
	Rol_func_id  = rol_id AND
	rol_nombre = @rol)
END
GO

CREATE PROCEDURE MESSI_MAS3.get_roles
AS
BEGIN
	SELECT rol_id, rol_nombre, rol_habilitado FROM MESSI_MAS3.ROL  --Le agregue el rol_id
END
GO

CREATE PROCEDURE MESSI_MAS3.get_all_funcionalidades
AS
BEGIN
SELECT funcionalidad_descripcion FROM MESSI_MAS3.FUNCIONALIDAD
END
GO

CREATE PROCEDURE MESSI_MAS3.get_id_funcionalidad(@func NVARCHAR(255))
AS
BEGIN
SELECT TOP 1 funcionalidad_id FROM MESSI_MAS3.FUNCIONALIDAD WHERE funcionalidad_descripcion = @func
END
GO

CREATE PROCEDURE MESSI_MAS3.crear_rol(@descripcion nvarchar(255), @estado INT)
AS
BEGIN
	INSERT INTO MESSI_MAS3.ROL(rol_nombre, rol_habilitado)
	VALUES(@descripcion, @estado)
END
GO


CREATE PROCEDURE MESSI_MAS3.bajar_rol(@descripcion nvarchar(255))
AS
BEGIN
	UPDATE MESSI_MAS3.ROL
	SET rol_habilitado = 0
	WHERE rol_nombre = @descripcion

	DECLARE @rolId INT
	SELECT @rolId = rol_id FROM MESSI_MAS3.Rol WHERE rol_nombre = @descripcion

	UPDATE MESSI_MAS3.Rol_Usuario
	SET  deleted = 1 
	WHERE Rol_id = @rolId
END
GO

CREATE PROCEDURE MESSI_MAS3.agregar_funcionalidad(@descripcion_func nvarchar(255))
AS
BEGIN
	INSERT INTO MESSI_MAS3.FUNCIONALIDAD(funcionalidad_descripcion)
	VALUES(@descripcion_func)
END
GO

CREATE PROCEDURE MESSI_MAS3.asignar_funcionalidad_a_rol (@rol nvarchar(255), @func nvarchar(255))
AS
BEGIN
	INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES ((SELECT rol_id FROM MESSI_MAS3.ROL WHERE rol_nombre = @rol),
	 (SELECT TOP 1 funcionalidad_id FROM MESSI_MAS3.FUNCIONALIDAD WHERE funcionalidad_descripcion = @func))
END
GO

CREATE FUNCTION MESSI_MAS3.getIdRol(@rol nvarchar(255)) RETURNS INT
AS
BEGIN
RETURN (SELECT rol_id FROM MESSI_MAS3.ROL WHERE rol_nombre = @rol)
END
GO

CREATE PROCEDURE MESSI_MAS3.borrar_funcionalidad(@rol nvarchar(255), @descripcion_func nvarchar(255))
AS
BEGIN
	DELETE FROM MESSI_MAS3.Funcionalidad_Rol
	WHERE Funcionalidad_rol_id = (SELECT funcionalidad_id FROM MESSI_MAS3.FUNCIONALIDAD WHERE funcionalidad_descripcion = @descripcion_func)
	AND Rol_func_id = (SELECT MESSI_MAS3.getIdRol(@rol))

END
GO

CREATE PROCEDURE MESSI_MAS3.existe_rol(@rol nvarchar(255))
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM MESSI_MAS3.ROL WHERE rol_nombre = @rol)) BEGIN RETURN 1 END RETURN -1
END
GO

CREATE PROCEDURE MESSI_MAS3.modificar_nombre_rol(@nombre nvarchar(255), @nuevo_nombre nvarchar(255))
AS
BEGIN
	UPDATE MESSI_MAS3.ROL
	SET rol_nombre = @nuevo_nombre
	WHERE rol_nombre = @nombre
END
GO

CREATE PROCEDURE MESSI_MAS3.habilitar_rol(@nombre nvarchar(255))
AS
BEGIN
	UPDATE MESSI_MAS3.ROL
	SET rol_habilitado = 1
	WHERE rol_nombre = @nombre
END
GO

--SP DE KOIFFO
CREATE PROCEDURE [MESSI_MAS3].getFuncionalidadesFuncionalidades (@idRol int)
AS
BEGIN
	SELECT Funcionalidad.funcionalidad_id,Funcionalidad.funcionalidad_descripcion FROM Funcionalidad,Funcionalidad_Rol WHERE Rol_func_id = @idRol AND Funcionalidad_Rol.Funcionalidad_rol_id = Funcionalidad.funcionalidad_id AND Funcionalidad_Rol.deleted=0
END 
GO


/*-----------------------------------SP ABM Usuario-----------------*/

/*------ABM DE USUARIO------*/

CREATE PROCEDURE MESSI_MAS3.existe_username(@usuario nvarchar(255))
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM MESSI_MAS3.Usuario WHERE usuario_nombreUsuario = @usuario)) BEGIN RETURN 1 END RETURN -1
END
GO

CREATE PROCEDURE MESSI_MAS3.cambiarPassword(@id INT, @password nvarchar(255))
AS
BEGIN
	UPDATE MESSI_MAS3.Usuario
	SET usuario_contrasenia = @password
	WHERE usuario_id = @id
END
GO

CREATE PROCEDURE MESSI_MAS3.baja_usuario(@id INT)
AS
BEGIN
	UPDATE MESSI_MAS3.Usuario
	SET usuario_deleted = 0
	WHERE usuario_id = @id
END
GO

CREATE PROCEDURE MESSI_MAS3.alta_usuario(@id INT)
AS
BEGIN
	UPDATE MESSI_MAS3.Usuario
	SET usuario_deleted = 1
	WHERE usuario_id = @id
END
GO

CREATE PROCEDURE MESSI_MAS3.get_localidades
AS				
BEGIN
	SELECT localidad_nombre, localidad_id
	FROM MESSI_MAS3.Localidad
END
GO

CREATE PROCEDURE MESSI_MAS3.get_tipoDocumentos
AS				
BEGIN
	SELECT tipoDocumento_nombre, tipoDocumento_id
	FROM MESSI_MAS3.TipoDocumento
END
GO

CREATE PROCEDURE MESSI_MAS3.get_rubros
AS				
BEGIN
	SELECT rubro_id, rubro_descripcionCorta
	FROM MESSI_MAS3.Rubro
END
GO

/*------CLIENTE------*/
CREATE PROCEDURE MESSI_MAS3.get_clientes
AS				
BEGIN
	SELECT usuario_id, usuario_nombreUsuario, cliente_nombre, cliente_apellido, cliente_DNI, cliente_mail, usuario_deleted 
	FROM MESSI_MAS3.Cliente, MESSI_MAS3.Usuario
	WHERE cliente_id = usuario_id 
END
GO

CREATE PROCEDURE MESSI_MAS3.get_cliente(@id INT)
AS				
BEGIN
	SELECT cliente_nombre, cliente_apellido, cliente_DNI, cliente_tipoDocumento_id, cliente_mail, cliente_tel, cliente_fechaNacimiento, domicilio_calle, domicilio_altura, domicilio_piso, domicilio_departamento, domicilio_codigoPostal, domicilio_localidad_id
	FROM MESSI_MAS3.Cliente, MESSI_MAS3.Domicilio
	WHERE cliente_id = @id AND cliente_idDomicilio = domicilio_idDomicilio
END
GO

CREATE PROCEDURE MESSI_MAS3.get_clientesFiltrados(@nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni NUMERIC(18,0), @IdTipoDocumento INT)
AS				
BEGIN
	SELECT usuario_id, usuario_nombreUsuario, cliente_nombre, cliente_apellido, cliente_DNI, cliente_mail, usuario_deleted 
	FROM MESSI_MAS3.Cliente, MESSI_MAS3.Usuario
	WHERE cliente_id = usuario_id 
		AND cliente_nombre LIKE CONCAT('%', @nombre, '%')
		AND cliente_apellido LIKE CONCAT('%', @apellido, '%')
		AND cliente_mail LIKE CONCAT('%', @mail, '%')
		AND cliente_DNI = @dni
		AND cliente_tipoDocumento_id = @IdTipoDocumento
END
GO

CREATE PROCEDURE MESSI_MAS3.get_clientesFiltradosSinDocumento(@nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255))
AS				
BEGIN
	SELECT usuario_id, usuario_nombreUsuario, cliente_nombre, cliente_apellido, cliente_DNI, cliente_mail, usuario_deleted 
	FROM MESSI_MAS3.Cliente, MESSI_MAS3.Usuario
	WHERE cliente_id = usuario_id 
		AND cliente_nombre LIKE CONCAT('%', @nombre, '%')
		AND cliente_apellido LIKE CONCAT('%', @apellido, '%')
		AND cliente_mail LIKE CONCAT('%', @mail, '%')
END
GO

CREATE PROCEDURE MESSI_MAS3.modificar_cliente(@idCliente INT, @nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni INT, @fechaNacimiento DATETIME, @telefono NUMERIC(15,0), @idTipoDocumento INT, @idLocalidad INT, @calle nvarchar(100), @altura NUMERIC(18,0), @piso NUMERIC(18,0), @departamento NVARCHAR(50), @codigoPostal NVARCHAR(50))
AS
BEGIN
	UPDATE MESSI_MAS3.Cliente
	SET cliente_nombre = @nombre, cliente_apellido = @apellido, cliente_mail = @mail, cliente_DNI = @dni, cliente_fechaNacimiento = @fechaNacimiento, cliente_tel = @telefono, cliente_tipoDocumento_id = @idTipoDocumento 
	WHERE cliente_id = @idCliente

	DECLARE @idDomicilioCliente INT
	SELECT @idDomicilioCliente = cliente_idDomicilio FROM MESSI_MAS3.Cliente WHERE cliente_id = @idCliente

	UPDATE MESSI_MAS3.Domicilio
	SET domicilio_localidad_id = @idLocalidad, domicilio_calle = @calle , domicilio_altura = @altura, domicilio_piso = @piso, domicilio_departamento = @departamento, domicilio_codigoPostal = @codigoPostal
	WHERE domicilio_idDomicilio = @idDomicilioCliente
END
GO

CREATE PROCEDURE MESSI_MAS3.crear_cliente(@username nvarchar(255), @password nvarchar(255), @nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni INT, @fechaNacimiento DATETIME, @telefono NUMERIC(15,0), @idTipoDocumento INT, @idLocalidad INT, @calle nvarchar(100), @altura NUMERIC(18,0), @piso NUMERIC(18,0), @departamento NVARCHAR(50), @codigoPostal NVARCHAR(50))
AS
BEGIN
	INSERT INTO MESSI_MAS3.Usuario(usuario_nombreUsuario, usuario_contrasenia, usuario_deleted, usuario_intentos, usuario_primeraPublicacion)
	VALUES(@username, @password, 0, 0, 0)

	DECLARE @idUsuario INT
	SELECT @idUsuario = SCOPE_IDENTITY()

	INSERT INTO MESSI_MAS3.Domicilio(domicilio_localidad_id, domicilio_calle, domicilio_altura, domicilio_piso, domicilio_departamento, domicilio_ciudad, domicilio_codigoPostal)
	VALUES (@idLocalidad, @calle, @altura, @piso, @departamento, NULL, @codigoPostal)

	DECLARE @idDomicilio INT
	SELECT @idDomicilio = SCOPE_IDENTITY()

	INSERT INTO MESSI_MAS3.Cliente(cliente_id, cliente_nombre, cliente_apellido, cliente_mail, cliente_DNI, cliente_fechaNacimiento, cliente_tel, cliente_tipoDocumento_id, cliente_idDomicilio, cliente_fechaCreacion, cliente_calificacionPromedio)
	VALUES (@idUsuario, @nombre, @apellido, @mail, @dni, @fechaNacimiento, @telefono, @idTipoDocumento, @idDomicilio, GETDATE(), 0)

	INSERT INTO MESSI_MAS3.Rol_Usuario(Rol_id,Usuario_id)
	VALUES(2, @idUsuario)
END
GO

/*------EMPRESA------*/
CREATE PROCEDURE MESSI_MAS3.get_empresa(@id INT)
AS				
BEGIN
	SELECT empresa_razonSocial, empresa_cuit, empresa_telefono, empresa_rubroId, empresa_mail, empresa_nombreContacto, domicilio_calle, domicilio_altura, domicilio_piso, domicilio_departamento, domicilio_codigoPostal, domicilio_localidad_id, domicilio_ciudad
	FROM MESSI_MAS3.Empresa, MESSI_MAS3.Domicilio
	WHERE empresa_id = @id AND empresa_idDomicilio = domicilio_idDomicilio
END
GO

CREATE PROCEDURE MESSI_MAS3.get_empresasFiltradas(@razonSocial nvarchar(255), @mail nvarchar(255), @cuit nvarchar(50))
AS				
BEGIN
	SELECT usuario_id, usuario_nombreUsuario, empresa_razonSocial, empresa_cuit, empresa_mail, empresa_nombreContacto, usuario_deleted 
	FROM MESSI_MAS3.Empresa, MESSI_MAS3.Usuario
	WHERE empresa_id = usuario_id 
		AND empresa_razonSocial LIKE CONCAT('%', @razonSocial, '%')
		AND empresa_cuit = @cuit
		AND empresa_mail LIKE CONCAT('%', @mail, '%')
END
GO

CREATE PROCEDURE MESSI_MAS3.get_empresasFiltradasSinCUIT(@razonSocial nvarchar(255), @mail nvarchar(255))
AS				
BEGIN
	SELECT usuario_id, usuario_nombreUsuario, empresa_razonSocial, empresa_cuit, empresa_mail, empresa_nombreContacto, usuario_deleted 
	FROM MESSI_MAS3.Empresa, MESSI_MAS3.Usuario
	WHERE empresa_id = usuario_id 
		AND empresa_razonSocial LIKE CONCAT('%', @razonSocial, '%')
		AND empresa_mail LIKE CONCAT('%', @mail, '%')
END
GO

CREATE PROCEDURE MESSI_MAS3.modificar_empresa(@idEmpresa INT, @razonSocial nvarchar(255), @mail nvarchar(255), @cuit nvarchar(50), @telefono NUMERIC(15,0), @nombreContacto nvarchar(100), @idLocalidad INT, @calle nvarchar(100), @altura NUMERIC(18,0), @piso NUMERIC(18,0), @departamento NVARCHAR(50), @ciudad NVARCHAR(45), @codigoPostal NVARCHAR(50), @idRubro INT)
AS
BEGIN
	UPDATE MESSI_MAS3.Empresa
	SET empresa_razonSocial = @razonSocial, empresa_mail = @mail, empresa_cuit = @cuit, empresa_telefono = @telefono, empresa_nombreContacto = @nombreContacto, empresa_rubroId = @idRubro 
	WHERE empresa_id = @idEmpresa

	DECLARE @idDomicilioEmpresa INT
	SELECT @idDomicilioEmpresa = empresa_idDomicilio FROM MESSI_MAS3.Empresa WHERE empresa_id = @idEmpresa

	UPDATE MESSI_MAS3.Domicilio
	SET domicilio_localidad_id = @idLocalidad, domicilio_calle = @calle , domicilio_altura = @altura, domicilio_piso = @piso, domicilio_departamento = @departamento, domicilio_ciudad = @ciudad, domicilio_codigoPostal = @codigoPostal
	WHERE domicilio_idDomicilio = @idDomicilioEmpresa
END
GO

CREATE PROCEDURE MESSI_MAS3.crear_empresa(@username nvarchar(255), @password nvarchar(255), @razonSocial nvarchar(255), @mail nvarchar(255), @cuit nvarchar(50), @telefono NUMERIC(15,0), @nombreContacto nvarchar(100), @idLocalidad INT, @calle nvarchar(100), @altura NUMERIC(18,0), @piso NUMERIC(18,0), @departamento NVARCHAR(50), @ciudad NVARCHAR(45), @codigoPostal NVARCHAR(50), @idRubro INT)
AS
BEGIN
	INSERT INTO MESSI_MAS3.Usuario(usuario_nombreUsuario, usuario_contrasenia, usuario_deleted, usuario_intentos, usuario_primeraPublicacion)
	VALUES(@username, @password, 0, 0, 0)

	DECLARE @idUsuario INT
	SELECT @idUsuario = SCOPE_IDENTITY()

	INSERT INTO MESSI_MAS3.Domicilio(domicilio_localidad_id, domicilio_calle, domicilio_altura, domicilio_piso, domicilio_departamento, domicilio_ciudad, domicilio_codigoPostal)
	VALUES (@idLocalidad, @calle, @altura, @piso, @departamento, @ciudad, @codigoPostal)

	DECLARE @idDomicilio INT
	SELECT @idDomicilio = SCOPE_IDENTITY()

	INSERT INTO MESSI_MAS3.Empresa(empresa_id, empresa_razonSocial, empresa_mail, empresa_cuit, empresa_telefono, empresa_nombreContacto, empresa_rubroId, empresa_fechaCreacion, empresa_idDomicilio)
	VALUES (@idUsuario, @razonSocial, @mail, @cuit, @telefono, @nombreContacto, @idRubro, GETDATE(), @idDomicilio)

	INSERT INTO MESSI_MAS3.Rol_Usuario(Rol_id,Usuario_id)
	VALUES(3, @idUsuario)
END
GO

CREATE PROCEDURE MESSI_MAS3.existe_razonSocial(@razon nvarchar(255))
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM MESSI_MAS3.Empresa WHERE empresa_razonSocial = @razon)) BEGIN RETURN 1 END RETURN -1
END
GO

CREATE PROCEDURE MESSI_MAS3.existe_cuit(@cuit nvarchar(255))
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM MESSI_MAS3.Empresa WHERE empresa_cuit = @cuit)) BEGIN RETURN 1 END RETURN -1
END
GO


/*----------------------SP Consultar Facturas-------------------------*/

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechas](@idUsuario INT, @dateDesde DATE, @dateHasta DATE)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) AND formaDePago_id = factura_formaDePago)

END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreImporte](@idUsuario INT, @importeDesde INT , @importeHasta INT)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND formaDePago_id = factura_formaDePago)

END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConDetalle](@idUsuario INT, @descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura,MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario 
	AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 
	AND formaDePago_id = factura_formaDePago)

END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechasEImporte](@idUsuario INT, @dateDesde DATE, @dateHasta DATE,@importeDesde INT , @importeHasta INT)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde 
	AND @importeHasta) AND formaDePago_id = factura_formaDePago)


END
GO



CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechasYContieneDetalle](@idUsuario INT, @dateDesde DATE, @dateHasta DATE,@descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura,MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) 
	AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 
	AND formaDePago_id = factura_formaDePago)


END
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreImporteYDetalle](@idUsuario INT, @importeDesde INT , @importeHasta INT,@descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND formaDePago_id = factura_formaDePago)
	 AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO


CREATE PROCEDURE [MESSI_MAS3].[get_facturasConTodoLosFiltros](@idUsuario INT,@dateDesde DATE, @dateHasta DATE, @importeDesde INT , @importeHasta INT,@descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)  AND formaDePago_id = factura_formaDePago)
	 AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO

CREATE FUNCTION [MESSI_MAS3].[cuitDeEmpresa](@dniOCuit NVARCHAR(255))
RETURNS INTEGER
AS BEGIN
DECLARE @cuitloco NVARCHAR(255), @esEmpresa INT, @idPersona INT
SET @esEmpresa = 0
SET  @cuitloco = @dniOCuit

SELECT @esEmpresa = empresa_id FROM MESSI_MAS3.Empresa WHERE @cuitloco = empresa_cuit

RETURN @esEmpresa

END
GO

CREATE FUNCTION [MESSI_MAS3].[traerIdUsuario](@dniOCuit NVARCHAR(255))
RETURNS INTEGER
AS BEGIN
DECLARE @id INT
DECLARE @dniNumeric NUMERIC(18,0)

SET @id = MESSI_MAS3.cuitDeEmpresa(@dniOCuit)
if @id = 0
	BEGIN
		SET @dniNumeric = CONVERT(NUMERIC(18,0), @dniOCuit)
		SELECT @id = cliente_id FROM MESSI_MAS3.Cliente WHERE @dniNumeric = cliente_DNI
	END

RETURN @id
END
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConTodoLosFiltrosInclusoDNIOCUIT](@idUsuario INT,@dateDesde DATE, @dateHasta DATE, @importeDesde INT , @importeHasta INT,@descripcion NVARCHAR(255), @dniOCuit NVARCHAR(255))
AS BEGIN

DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago, MESSI_MAS3.Cliente, MESSI_MAS3.Empresa 
	WHERE ( factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)  AND formaDePago_id = factura_formaDePago)
	 AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO


--get_facturasHacia

CREATE PROCEDURE [MESSI_MAS3].[get_facturasHacia](@idUsuario INT,@cuitODni NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@cuitODni)

SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND formaDePago_id = factura_formaDePago)

END 
GO

--get_facturasEntreFechasYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechasYDirigido](@idUsuario INT, @dateDesde DATE, @dateHasta DATE,@cuitODni NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@cuitODni)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)
	AND formaDePago_id = factura_formaDePago)


END
GO

--get_facturasEntreImporteYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreImporteYDirigido](@idUsuario INT, @importeDesde INT , @importeHasta INT,@dniOCuit NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND formaDePago_id = factura_formaDePago)
	  

END 
GO

--get_facturasEntreDetalleYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreDetalleYDirigido](@idUsuario INT,@dniOCuit NVARCHAR(255), @descripcion NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago
	WHERE ( factura_idVendedor = @idUser AND formaDePago_id = factura_formaDePago
	 AND  Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO

--get_facturasConFechaImporteYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConFechaImporteYDirigido](@idUsuario INT,@dateDesde DATE, @dateHasta DATE, @importeDesde INT , @importeHasta INT,@dniOCuit NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)  AND formaDePago_id = factura_formaDePago)
	 
END 
GO

--get_facturasConFechaDetalleyDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConFechaDetalleyDirigido](@idUsuario INT,@dateDesde DATE, @dateHasta DATE,@dniOCuit NVARCHAR(255), @descripcion NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago
	WHERE ( factura_idVendedor = @idUser AND formaDePago_id = factura_formaDePago
	 AND  Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)) 

END 
GO

--get_facturasConDetalleImporteYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConDetalleImporteYDirigido](@idUsuario INT,@descripcion NVARCHAR(255), @importeDesde INT , @importeHasta INT,@dniOCuit NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) 
	AND  (Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion)  
	AND formaDePago_id = factura_formaDePago)
	 
END 
GO


/*----------------------------SP Calificar --------------------------*/



/*------------------------------lo uso cada vez que se califica------------------------*/

CREATE PROCEDURE [MESSI_MAS3].[updatearPromedioAnteNuevaCalificacion](@idUsuarioCalificado INT)
AS BEGIN
DECLARE @promedio INT
SELECT @promedio = FLOOR(AVG(calificacion_cantidadEstrellas)) FROM MESSI_MAS3.Calificacion WHERE calificacion_idusuarioCalificado = @idUsuarioCalificado
   GROUP BY calificacion_idusuarioCalificado

IF (MESSI_MAS3.esEmpresa(@idUsuarioCalificado) = 0) --significa que no es empresa
	BEGIN
		UPDATE MESSI_MAS3.Cliente SET cliente_calificacionPromedio = @promedio WHERE @idUsuarioCalificado = cliente_id
	END

ELSE
	BEGIN
		UPDATE MESSI_MAS3.Empresa SET empresa_calificacionPromedio = @promedio WHERE @idUsuarioCalificado = empresa_id
	END


END
GO


--get_calificacionesPendientesDe
CREATE PROCEDURE [MESSI_MAS3].[get_calificacionesPendientesDeID](@idUsuario NVARCHAR(255))
AS BEGIN
DECLARE @idCasteado int
SET @idCasteado = CAST(@idUsuario AS INT)
SELECT DISTINCT calificacion_id, calificacion_compraId, compras_publicacion_id, tipoPublicacion_nombre, publicacion_fechaFin, publicacion_descripcion  FROM MESSI_MAS3.Calificacion, MESSI_MAS3.Compra, MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 

WHERE calificacion_pendiente = 1 AND (compra_id = calificacion_compraId AND calificacion_idPersonaCalificador = @idCasteado) AND (publicacion_id = compras_publicacion_id AND tipoPublicacion_id = publicacion_tipoPublicacionId) 

END
GO

--get_ultimas5CalificacionesHechasDe

CREATE PROCEDURE [MESSI_MAS3].[get_ultimas5CalificacionesHechasDe](@idUsuario NVARCHAR(255))
AS BEGIN
DECLARE @idCasteado int
SET @idCasteado = CAST(@idUsuario AS INT)
SELECT DISTINCT TOP 5 calificacion_id, tipoPublicacion_nombre, calificacion_cantidadEstrellas, calificacion_detalle  FROM MESSI_MAS3.Calificacion, MESSI_MAS3.Compra, MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 

WHERE calificacion_pendiente = 0 AND compra_id = calificacion_compraId AND calificacion_idPersonaCalificador = @idCasteado AND (publicacion_id = compras_publicacion_id AND tipoPublicacion_id = publicacion_tipoPublicacionId)

END
GO



CREATE PROCEDURE [MESSI_MAS3].[get_comprasXEstrellasSegunId](@idUsuario NVARCHAR(255))
AS BEGIN
DECLARE @idCasteado int
SET @idCasteado = CAST(@idUsuario AS INT)

SELECT (SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 1 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 2 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 3 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 4 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 5 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario)

END
GO

CREATE PROCEDURE [MESSI_MAS3].[actualizar_calificacionDe](@idCalificacion INT, @mensaje NVARCHAR(255), @cantidadEstrellas INT)
AS BEGIN

UPDATE MESSI_MAS3.Calificacion SET calificacion_pendiente = 0, calificacion_cantidadEstrellas = @cantidadEstrellas, calificacion_detalle = @mensaje WHERE calificacion_id = @idCalificacion

END
GO


/*---------------------------------------SP Historial Cliente---------------------*/

CREATE PROCEDURE [MESSI_MAS3].[get_historialClienteID](@idUsuario INT)
AS BEGIN

SELECT compras_publicacion_id, compras_fecha, tipoPublicacion_nombre, publicacion_precio, publicacion_descripcion  FROM MESSI_MAS3.Compra,MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 
	WHERE (compras_publicacion_id = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_id) AND (compras_personaComprador_id = @idUsuario)

UNION ALL

SELECT oferta_idPublicacion, oferta_fecha, tipoPublicacion_nombre, oferta_valor, publicacion_descripcion  FROM MESSI_MAS3.Oferta,MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion
	WHERE (oferta_idPublicacion = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_id) AND (oferta_persona_id = @idUsuario)


END
GO

CREATE PROCEDURE [MESSI_MAS3].[get_resumenComprasUsuario](@idUsuario INT)
AS BEGIN

SELECT
	(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 1)),
	(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 0)),
	(SELECT SUM(calificacion_cantidadEstrellas) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 0)),
	(SELECT COUNT(*) FROM MESSI_MAS3.Oferta WHERE (oferta_persona_id = @idUsuario AND oferta_ganador = 1))



END
GO

/*--------------------------SP Visibilidad-------------------*/

CREATE PROCEDURE [MESSI_MAS3].getVisibilidades
AS
BEGIN
SELECT * FROM MESSI_MAS3.Visibilidad
END 
GO

CREATE PROCEDURE [MESSI_MAS3].eliminarVisibilidad @idVisibilidad int
AS
BEGIN
	BEGIN TRY
		DELETE FROM [MESSI_MAS3].Visibilidad WHERE visibilidad_id = @idVisibilidad
	END TRY
	BEGIN CATCH
		RETURN -1
	END CATCH
END
GO

CREATE PROCEDURE [MESSI_MAS3].agregarVisibilidad @visibilidad_codigo int,@visibilidad_des nvarchar(255),@visibilidad_porc numeric(18,2),@visibilidad_precio numeric(18,2),@visibilidad_costoEnvio numeric(18,2)
AS
BEGIN
INSERT INTO [MESSI_MAS3].Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio,visibilidad_costoEnvio) VALUES (@visibilidad_codigo,@visibilidad_des,@visibilidad_porc,@visibilidad_precio,@visibilidad_costoEnvio)
END
GO

CREATE PROCEDURE [MESSI_MAS3].modificarVisibilidad @visibilidad_id int, @visibilidad_codigo int,@visibilidad_des nvarchar(255),@visibilidad_porc numeric(18,2),@visibilidad_precio numeric(18,2),@visibilidad_costoEnvio numeric(18,2)
AS
BEGIN
UPDATE [MESSI_MAS3].Visibilidad SET visibilidad_codigo=@visibilidad_codigo,visibilidad_descripcion=@visibilidad_des,visibilidad_porcentaje=@visibilidad_porc,visibilidad_precio=@visibilidad_precio,visibilidad_costoEnvio=@visibilidad_costoEnvio WHERE @visibilidad_id = visibilidad_id
END
GO



/*--------------------------SP Publicacion-----------------------------*/

CREATE PROCEDURE [MESSI_MAS3].getPublicaciones @idUsuario int
AS
BEGIN
SELECT publicacion_id,publicacion_idEstado,estado_nombre,visibilidad_id,visibilidad_descripcion,publicacion_fechaInicio,publicacion_fechaFin,publicacion_descripcion,publicacion_precio,publicacion_idRubro,rubro_descripcionCorta,publicacion_stock FROM Estado,Visibilidad,Publicacion,Rubro WHERE @idUsuario = publicacion_idUsuario AND publicacion_idVisibilidad = visibilidad_id AND publicacion_idEstado = estado_id AND rubro_id = publicacion_idRubro
END
GO

/*--------------------------SP Comprar/Ofertar-------------------------*/

CREATE PROCEDURE MESSI_MAS3.get_ultimaOferta(@idPublicacion INT)
AS
BEGIN
	SELECT ISNULL(MAX(oferta_valor), (SELECT publicacion_minimoSubasta FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion)) AS valorMax
	FROM MESSI_MAS3.Oferta
	WHERE oferta_idPublicacion = @idPublicacion
END
GO

CREATE PROCEDURE MESSI_MAS3.crearOferta(@valor NUMERIC(18,2), @idUsuario INT, @idPublicacion INT)
AS
BEGIN
	INSERT INTO MESSI_MAS3.Oferta(oferta_valor, oferta_persona_id, oferta_idPublicacion, oferta_fecha)
	VALUES(@valor, @idUsuario, @idPublicacion, GETDATE())
END
GO

CREATE PROCEDURE MESSI_MAS3.crearCompra(@idPublicacion INT, @idUsuario INT, @cantidad INT)
AS
BEGIN
	INSERT INTO MESSI_MAS3.Compra(compras_publicacion_id, compras_fecha, compras_personaComprador_id, compras_cantidad)
	VALUES(@idPublicacion, GETDATE(), @idUsuario, @cantidad)

	UPDATE MESSI_MAS3.Publicacion
	SET publicacion_stock = (SELECT publicacion_stock FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion) - @cantidad
	WHERE publicacion_id = @idPublicacion
END
GO

CREATE PROCEDURE MESSI_MAS3.filtrarPublicacionPorDescripcion(@descripcion NVARCHAR(255))
AS
BEGIN
	SELECT publicacion_id, publicacion_codigo, tipoPublicacion_nombre, publicacion_descripcion, publicacion_precio, publicacion_minimoSubasta, publicacion_stock, rubro_descripcionCorta, visibilidad_id, visibilidad_descripcion
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad, MESSI_MAS3.tipoPublicacion, MESSI_MAS3.Rubro
	WHERE (publicacion_idEstado = 2
		AND publicacion_idRubro = rubro_id 
		AND publicacion_tipoPublicacionId = tipoPublicacion_id 
		AND publicacion_idVisibilidad = visibilidad_id
		AND publicacion_descripcion LIKE CONCAT('%', @descripcion, '%'))
END
GO

CREATE PROCEDURE MESSI_MAS3.filtrarPublicacionPorRubro(@idRubro INT, @descripcion NVARCHAR(255))
AS
BEGIN
	SELECT publicacion_id, publicacion_codigo, tipoPublicacion_nombre, publicacion_descripcion, publicacion_precio, publicacion_minimoSubasta, publicacion_stock, rubro_descripcionCorta, visibilidad_id, visibilidad_descripcion
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad, MESSI_MAS3.tipoPublicacion, MESSI_MAS3.Rubro
	WHERE (publicacion_idEstado = 2
		AND publicacion_tipoPublicacionId = tipoPublicacion_id 
		AND publicacion_idVisibilidad = visibilidad_id
		AND publicacion_idRubro = @idRubro
		AND publicacion_descripcion LIKE CONCAT('%', @descripcion, '%'))
END
GO






/*---------------------------EXEC DE PARA MIGRAR---------------------------*/
PRINT 'Iniciando'
EXEC MESSI_MAS3.meterDatosFijos
PRINT 'DATOS INICIALES MIGRADOS';
EXEC MESSI_MAS3.migrarRubros
PRINT 'RUBROS MIGRADOS';
EXEC MESSI_MAS3.migrarClientes
PRINT 'Clientes MIGRADAS';
EXEC MESSI_MAS3.migrarEmpresas
PRINT 'EMPRESAS MIGRADAS';
EXEC MESSI_MAS3.crearFuncionalidades
PRINT 'FUNCIONALIDADES CREADAS';
EXEC MESSI_MAS3.crearAdmin
PRINT 'ADMIN CREADO'






/*------------------Transactions para migracion---------------------------*/




/*--------------------------Migro roles contra funcionalidades - atado a cambios---------------------------*/
BEGIN TRANSACTION

--inserto funcionalidades para Cliente
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (2,5)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (2,6)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (2,7)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (2,8)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (2,9)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (2,10) --Listado estadistico, todos lo pueden ver?

--inserto funcionalidades para Empresa

INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (3,5)
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (3,9) --consulta sus propias facturas
INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_func_id, Funcionalidad_rol_id) VALUES (3,10) --Listado estadistico, todos lo pueden ver?
COMMIT



/*--------------------------Migro publicaciones de clientes---------------------------*/
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Publ_Cli_Dni AND cliente_apellido = Publ_Cli_Apeliido AND cliente_nombre = Publ_Cli_Nombre ),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		2,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Cli_Dni IS NOT NULL ) 	AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Compra Inmediata')
COMMIT


BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Publ_Cli_Dni AND cliente_apellido = Publ_Cli_Apeliido AND cliente_nombre = Publ_Cli_Nombre ),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		1,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Cli_Dni IS NOT NULL ) 	AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Subasta')
COMMIT



/*--------------------------Migro publicaciones de Empresas---------------------------*/
--Publicaciones de Empresas
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		2,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Empresa_Cuit IS NOT NULL ) AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Compra Inmediata')	
COMMIT


BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		1,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Empresa_Cuit IS NOT NULL ) AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Subasta')	
COMMIT


/*--------------------------Migro rubros_x_publicaciones---------------------------*/
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Rubro_x_Publicacion(idPublicacion,idRubro)
(SELECT publicacion_id, 
		publicacion_idRubro

FROM MESSI_MAS3.Publicacion)
COMMIT

/*--------------------------Migro Compras---------------------------*/

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Compra(compras_personaComprador_id, compras_cantidad, compras_fecha , compras_publicacion_id)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Cli_Dni AND Compra_Fecha IS NOT NULL AND Oferta_Fecha IS NULL ),
		Compra_Cantidad ,
		Compra_Fecha, 
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE Publicacion_Cod = publicacion_codigo)


FROM gd_esquema.Maestra WHERE Compra_Cantidad IS NOT NULL AND Compra_Fecha IS NOT NULL)

COMMIT

/*--------------------------Migro Calificaciones de clientes---------------------------*/
BEGIN TRANSACTION

INSERT INTO MESSI_MAS3.Calificacion(calificacion_compraId, calificacion_codigo, calificacion_detalle, calificacion_idPersonaCalificador,
									calificacion_idusuarioCalificado,calificacion_fecha, calificacion_cantidadEstrellas, 
									 calificacion_pendiente)
(SELECT DISTINCT (SELECT TOP 1 compra_id FROM MESSI_MAS3.Compra WHERE compras_fecha = Compra_Fecha AND compras_cantidad = Compra_Cantidad AND Compra_Fecha = compras_fecha AND MESSI_MAS3.coincidenCodPubliCompra(Publicacion_Cod, compra_id) = 1),
		Calificacion_Codigo ,	
		Calificacion_Descripcion, 
		(SELECT TOP 1cliente_id FROM MESSI_MAS3.cliente WHERE Cli_Dni = cliente_DNI AND Cli_Apeliido = cliente_apellido AND Cli_Nombre =cliente_nombre),
		(SELECT TOP 1 cliente_id FROM MESSI_MAS3.cliente WHERE Publ_Cli_Dni = cliente_DNI AND Publ_Cli_Apeliido = cliente_apellido AND Publ_Cli_Nombre =cliente_nombre),
		Publicacion_Fecha_Venc,
		MESSI_MAS3.adiestrarCalif(Calificacion_Cant_Estrellas),
		0
FROM gd_esquema.Maestra WHERE Publ_Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Oferta_Monto IS NULL )
COMMIT

/*--------------------------Migro Calificaciones de empresas---------------------------*/
BEGIN TRANSACTION

INSERT INTO MESSI_MAS3.Calificacion(calificacion_compraId, calificacion_codigo, calificacion_detalle, calificacion_idPersonaCalificador,
									calificacion_idusuarioCalificado,calificacion_fecha, calificacion_cantidadEstrellas, 
									 calificacion_pendiente)
(SELECT DISTINCT (SELECT TOP 1 compra_id FROM MESSI_MAS3.Compra WHERE compras_fecha = Compra_Fecha AND compras_cantidad = Compra_Cantidad AND Compra_Fecha = compras_fecha AND MESSI_MAS3.coincidenCodPubliCompra(Publicacion_Cod, compra_id) = 1),
		Calificacion_Codigo ,	
		Calificacion_Descripcion, 
		(SELECT cliente_id FROM MESSI_MAS3.cliente WHERE Cli_Dni = cliente_DNI AND Cli_Apeliido = cliente_apellido AND Cli_Nombre =cliente_nombre),
		(SELECT TOP 1 empresa_id FROM MESSI_MAS3.Empresa WHERE Publ_Empresa_Cuit = empresa_cuit),
		Publicacion_Fecha_Venc,
		MESSI_MAS3.adiestrarCalif(Calificacion_Cant_Estrellas),
		0
FROM gd_esquema.Maestra WHERE Publ_Empresa_Cuit IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Publicacion_Cod IS NOT NULL AND Oferta_Monto IS NULL )
COMMIT



/*--------------------------Migro Ofertas de clientes---------------------------*/		--NO ES PERFORMANTE
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Oferta(oferta_persona_id, oferta_idPublicacion,oferta_fecha , oferta_valor,oferta_ganador)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Cli_Dni AND cliente_apellido = Cli_Apeliido AND cliente_nombre = Cli_Nombre ),
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE Publicacion_Cod = publicacion_codigo ) ,	--TARDA 3 MIN CON ESTE CODIGO, VER QUE SE PUEDE HACER, SI INSERTAMOS EL CODIGO DE PUBLI ALCANZA Y LO DEJAMOS SIN FK
		Oferta_Fecha, 
		Oferta_Monto,
		0
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND  Oferta_Fecha IS NOT NULL AND Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NULL AND (Publ_Cli_Dni IS NOT NULL OR Publ_Empresa_Cuit IS NOT NULL))
COMMIT




/*--------------------------Migro Ofertas ganadoras a Facturas---------------------------*/
--ANTES DE EJECUTAR ESTE, HAY QUE EJECUTAR EL SP buscarGanadoresOfertas

EXEC MESSI_MAS3.buscarGanadoresOfertas

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero, factura_publicacionId)
(SELECT DISTINCT (SELECT oferta_persona_id FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Publicacion_Fecha_Venc, 
		Oferta_Monto,
		Factura_Nro,
		(SELECT oferta_idPublicacion FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod)
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL)
COMMIT

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero, factura_publicacionId)
(SELECT DISTINCT (SELECT oferta_persona_id FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Publicacion_Fecha_Venc, 
		Oferta_Monto,
		Factura_Nro,
		(SELECT oferta_idPublicacion FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod)
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL)
COMMIT


/*--------------------------Migro Facturas de clientes---------------------------*/

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero,factura_publicacionId)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Publ_Cli_Dni AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Factura_Fecha, 
		Factura_Total,
		Factura_Nro,
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE publicacion_codigo = Publicacion_Cod)


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL)
COMMIT

/*--------------------------Migro Facturas de Empresas---------------------------*/

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero, factura_publicacionId)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Factura_Fecha, 
		Factura_Total,
		Factura_Nro,
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE publicacion_codigo = Publicacion_Cod)


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL)

COMMIT
/*--------------------------Migro el detalle de Facturas---------------------------*/

--Migro a la factura detalle todo
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetall_cantidadItems, facturaDetalle_item , facturaDetalle_numero,FacturaDetalle_valorItem)
(SELECT DISTINCT (SELECT TOP 1 factura_id FROM MESSI_MAS3.Factura 
			WHERE factura_numero = Factura_Nro AND factura_fecha = Factura_Fecha AND factura_importeTotal = Factura_Total AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		Item_Factura_Cantidad ,
		NULL, 
		Factura_Nro,
		Item_Factura_Monto


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL)
COMMIT


EXEC [MESSI_MAS3].[insertarCalificacionPromedio]


