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

--SELECT @calificacionConvertida = @calificacion /2 
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
INSERT INTO MESSI_MAS3.Funcionalidad_Rol (Rol_func_id,Funcionalidad_rol_id) VALUES (1,9) --consultar facturas realizadas, es necesario para el Administrativo?
INSERT INTO MESSI_MAS3.Funcionalidad_Rol (Rol_func_id,Funcionalidad_rol_id) VALUES (1,10) --funcionalidad listado estadistico
END
GO

/*
FALTA AGREGAR campo nombre al usuario en vez de que este en empresa y cliente Y CAMBIARLO EN DER, y ver que funcionalidades agregar
EL nombre del admin es Administrador General
*/

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


