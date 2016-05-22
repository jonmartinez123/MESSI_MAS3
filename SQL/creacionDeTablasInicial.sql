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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Respuesta')
	DROP TABLE MESSI_MAS3.Respuesta

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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Pregunta')
	DROP TABLE MESSI_MAS3.Pregunta

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Empresa')
	DROP TABLE MESSI_MAS3.Empresa

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Rubro')
	DROP TABLE MESSI_MAS3.Rubro

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Persona')
	DROP TABLE MESSI_MAS3.Persona

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MESSI_MAS3' AND  TABLE_NAME = 'Publicacion')
	DROP TABLE MESSI_MAS3.Publicacion

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
   funcionalidad_descripcion NVARCHAR(255) NULL,
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Usuario
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Usuario (
  usuario_id INT PRIMARY KEY NOT NULL IDENTITY,
  usuario_nombreUsuario NVARCHAR(255) NOT NULL,  --AGREGAR UNIQUE!!!
  usuario_contrasenia VARBINARY(255) NULL,				--Cambiado de NOT NULL a NULL y el nombre a 'contrasenia'
  usuario_mail NVARCHAR(50) NULL,	--LINEA PELIGROSA VIGILAR!! AGREGAR UNIQUE SAQUE EL NOT NULL
  usuario_deleted INT DEFAULT 0,
  usuario_intentos INT DEFAULT 0, )
 


-- -----------------------------------------------------
-- Table MESSI_MAS3.Rol
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rol (
  rol_id INT PRIMARY KEY NOT NULL IDENTITY,
  rol_nombre NVARCHAR(255) NULL,
  rol_deleted INT DEFAULT 0, 
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Localidad
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Localidad (
  localidad_id INT PRIMARY KEY NOT NULL IDENTITY,
  localidad_nombre NVARCHAR(255) NULL,			--cambio de Not null a NULL
  localidad_codigoPostal NVARCHAR(50) NOT NULL,
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
  domicilio_ciudad NVARCHAR(45) NULL,)					--CAMBIO DE DEFAULT 'BUENOS AIRES' A NULL							


																							

-- -----------------------------------------------------
-- Table MESSI_MAS3.Persona
-- -----------------------------------------------------

CREATE TABLE MESSI_MAS3.Persona (
  persona_nombre NVARCHAR(255) NOT NULL,
  persona_apellido NVARCHAR(255) NOT NULL,
  persona_DNI NUMERIC(18,0) NOT NULL UNIQUE,
  persona_fechaNacimiento DATETIME NOT NULL,
  persona_fechaCreacion DATETIME NOT NULL,
  persona_idDomicilio INT REFERENCES MESSI_MAS3.Domicilio(domicilio_idDomicilio),
  persona_id INT PRIMARY KEY REFERENCES MESSI_MAS3.Usuario(usuario_id),
  persona_tel NUMERIC(15,0) DEFAULT 0,
  persona_mail NVARCHAR(255) NULL,			--cambie a NULL 
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Rubro
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rubro (
  rubro_id INT PRIMARY KEY NOT NULL IDENTITY,
  rubro_descripcionCorta NVARCHAR(255) NOT NULL,
  rubro_descripcionLarga NVARCHAR(255) NULL,
  )


																				 

-- -----------------------------------------------------
-- Table MESSI_MAS3.Empresa
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Empresa (
  empresa_razonSocial NVARCHAR(255) NOT NULL,
  empresa_cuit NVARCHAR(50) NOT NULL,
  empresa_id INT PRIMARY KEY REFERENCES MESSI_MAS3.Usuario (usuario_id),
  empresa_calificacionPromedio INT NULL,						--Cambio de Not null a NULL
  empresa_fechaCreacion DATETIME NOT NULL,
  empresa_idDomicilio INT REFERENCES MESSI_MAS3.Domicilio (domicilio_idDomicilio),
  empresa_telefono VARCHAR(10) NULL,													--Cambie de NOT NULL a NULL
  empresa_rubro INT REFERENCES MESSI_MAS3.Rubro (rubro_id),)
 
-- -----------------------------------------------------
-- Table MESSI_MAS3.Estado
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Estado (
  estado_id INT PRIMARY KEY NOT NULL IDENTITY,
  estado_nombre NVARCHAR(255) NOT NULL,
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Visibilidad
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Visibilidad (
  visibilidad_id INT PRIMARY KEY NOT NULL IDENTITY,
  visibilidad_codigo INT NULL,
  visibilidad_descripcion NVARCHAR(255) NOT NULL,
  visibilidad_precio NUMERIC(18,2) NOT NULL,
  visibilidad_porcentaje NUMERIC(18,2) NOT NULL,
)



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
  publicacion_admitePreguntas INT DEFAULT 0 NOT NULL,
  publicacion_tipo NVARCHAR(255) NOT NULL,
  publicacion_minimoSubasta NUMERIC(10,2) NULL,			--DUDA MIRAR KOIFFO EL TIPO DE LA VARIABLE
  publicacion_precio NUMERIC(18,2),
  publicacion_idRubro INT NOT NULL,
  publicacion_tieneEnvio INT DEFAULT 0 NULL,
  publicacion_stock NUMERIC(18,0) NULL,
  
   )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Rubro_x_Publicacion
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rubro_x_Publicacion (
  idPublicacion INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  idRubro INT REFERENCES MESSI_MAS3.Rubro (rubro_id) ,)
  
-- -----------------------------------------------------
-- Table MESSI_MAS3.RolUsuario
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Rol_Usuario (
  Usuario_id INT REFERENCES MESSI_MAS3.Usuario (usuario_id),
  Rol_id INT REFERENCES MESSI_MAS3.Rol (rol_id),
)

-- -----------------------------------------------------
-- Table MESSI_MAS3.FuncionalidadRol
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Funcionalidad_Rol (
  Rol_id INT REFERENCES MESSI_MAS3.Rol(rol_id),
  Funcionalidad_id INT REFERENCES MESSI_MAS3.Funcionalidad (funcionalidad_id),
  )

-- -----------------------------------------------------
-- Table MESSI_MAS3.Compra
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Compra (
  compra_id INT PRIMARY KEY NOT NULL IDENTITY,
  compras_publicacion_id INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  compras_fecha DATETIME NOT NULL,
  compras_personaComprador_id INT REFERENCES MESSI_MAS3.Persona(persona_id),
  compras_cantidad NUMERIC(18,0) NOT NULL, )
 
-- -----------------------------------------------------
-- Table MESSI_MAS3.Oferta
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Oferta (
  oferta_id INT PRIMARY KEY NOT NULL IDENTITY,
  oferta_valor NUMERIC(18,2) NOT NULL,
  oferta_persona_id INT REFERENCES MESSI_MAS3.Persona(persona_id),						
  oferta_idPublicacion INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  oferta_fecha DATETIME NOT NULL,
  oferta_ganador INT DEFAULT 0,
  )


-- -----------------------------------------------------
-- Table MESSI_MAS3.Calificacion										
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Calificacion (
  calificacion_id INT PRIMARY KEY NOT NULL IDENTITY,
  calificacion_idPersonaCalificador INT REFERENCES MESSI_MAS3.Persona(persona_id), 
  calificacion_compraId INT REFERENCES MESSI_MAS3.Compra(compra_id),
  calificacion_fecha DATETIME NULL,
  calificacion_cantidadEstrellas NUMERIC(18,0) NULL,
  calificacion_detalle NVARCHAR(255) NULL,
  calificacion_pendiente INT DEFAULT 1 NULL,					--ACA!!!
  calificacion_idusuarioCalificado INT REFERENCES MESSI_MAS3.Usuario(usuario_id),
  calificacion_codigo NUMERIC (18,0),
)
 

-- -----------------------------------------------------
-- Table MESSI_MAS3.FormaDePago												
-- -----------------------------------------------------

CREATE TABLE MESSI_MAS3.FormaDePago (
  formaDePago_id INT PRIMARY KEY NOT NULL IDENTITY,
  formadePago_nombre NVARCHAR(255) NULL,
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
  
)

-- -----------------------------------------------------
-- Table MESSI_MAS3.Pregunta
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Pregunta (
  pregunta_id INT PRIMARY KEY NOT NULL IDENTITY,
  pregunta NVARCHAR(255) NOT NULL,
  pregunta_idPublicacion INT REFERENCES MESSI_MAS3.Publicacion (publicacion_id),
  pregunta_idPersonaPreguntador INT REFERENCES MESSI_MAS3.Persona (persona_id), 
  pregunta_fecha DATETIME NOT NULL, )
 



-- -----------------------------------------------------
-- Table MESSI_MAS3.Respuesta
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Respuesta (
  respuesta_id INT PRIMARY KEY NOT NULL IDENTITY,
  respuesta_idPregunta INT REFERENCES MESSI_MAS3.Pregunta (pregunta_id),
  respuesta_fecha DATETIME NULL,
  respuesta_textorespuesta NVARCHAR(255) NULL,
  respuesta_idUsQueResponde INT REFERENCES MESSI_MAS3.Usuario (usuario_id),
  
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Factura_detalle
-- -----------------------------------------------------
CREATE TABLE MESSI_MAS3.Factura_detalle (
  FacturaDetalle_valorItem NUMERIC(18,2) NOT NULL,
  facturaDetalle_numero NUMERIC(18,0) NOT NULL,
  facturaDetalle_item NVARCHAR(255) NULL,
  facturaDetalle_id INT REFERENCES MESSI_MAS3.Factura (factura_id), --cambiado a FK SOLO, LE SAQUE QUE SEA PK
  facturaDetall_cantidadItems NUMERIC(18,0) NOT NULL,
  
 )

 GO
 
 
/*--------------------------MIGRACIONES---------------------------*/

--Faltaria meter un procedure que valide que no esta repetido el dni, ni el cuit ni MAIL
--Dejarlo como UNIQUE el CUIT, DNI y Mail



CREATE PROCEDURE [MESSI_MAS3].[meterDatosFijos]
AS BEGIN
	
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
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio) VALUES('10002','Platino','0.10','180.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio) VALUES('10003','Oro','0.15','140.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio) VALUES('10004','Plata','0.20','100.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio) VALUES('10005','Bronce','0.30','60.00')
	INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio) VALUES('10006','Gratis','0.00','0.00')

	

END
GO

-- sp genero el usuario y devuelvo el id, me sirve para insertarlo de nuevo
CREATE PROCEDURE [MESSI_MAS3].[generarUsuario](@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoIdInsertado INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @passHasheada VARBINARY(255)
	SET @passHasheada =  HASHBYTES('SHA2_256', @password)
	INSERT INTO MESSI_MAS3.Usuario(usuario_nombreUsuario,usuario_contrasenia, usuario_mail) 
	VALUES (@usuario,@passHasheada,@mail)
	SELECT @ultimoIdInsertado = SCOPE_IDENTITY();
	
	
	RETURN
	
END
GO  

--sp inserto localidad y devuelvo el ultimo
CREATE PROCEDURE [MESSI_MAS3].[generarLocalidad](@localidadCod NVARCHAR(50) , @ultimoIdInsertado INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO MESSI_MAS3.Localidad(localidad_codigoPostal) 
	VALUES (@localidadCod)
	SELECT @ultimoIdInsertado = SCOPE_IDENTITY();
	
	RETURN
	
END
GO  


-- inserto el domicilio y devuelvo el ultimo
CREATE PROCEDURE [MESSI_MAS3].[generarDomicilio](@calle NVARCHAR(100),@altura NUMERIC(18,0), @piso NUMERIC(18,0),@departamento NVARCHAR(50), @ciudad NVARCHAR(45), @localidadCod NVARCHAR(50), @ultimoIdInsertado INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	-- INSERTO EL NUEVO DOMICILIO Y LOCALIDAD
	DECLARE @idLocalidad int;
	EXECUTE MESSI_MAS3.generarLocalidad @localidadCod,@ultimoIdInsertado = @idLocalidad OUTPUT;

	INSERT INTO MESSI_MAS3.Domicilio(domicilio_calle,domicilio_altura, domicilio_piso,domicilio_departamento,domicilio_ciudad, domicilio_localidad_id) 
	VALUES (@calle,@altura,@piso, @departamento, @ciudad, @idLocalidad)
	
	
	-- OBTENGO EL ULTIMO ID 
	SELECT @ultimoIdInsertado = SCOPE_IDENTITY();
	
	RETURN
	
END
GO  

--SP PARA MIGRAR TODOS LAS PERSONAS DE LA TABLA MAESTRA
CREATE PROCEDURE [MESSI_MAS3].[migrarPersonas]
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
			EXECUTE MESSI_MAS3.generarUsuario @documento,'123456',@mail,@ultimoIdInsertado = @idUsuario OUTPUT; --esta bien esta linea?? por el documento pasado como param
			DECLARE @idRol int;
			SET @idRol = (select rol_id from MESSI_MAS3.Rol where rol_nombre = 'Cliente')
			INSERT INTO MESSI_MAS3.Rol_Usuario(Rol_id,Usuario_id)
			VALUES(@idRol, @idUsuario)
			DECLARE @idDomicilio int;
			EXECUTE MESSI_MAS3.generarDomicilio @calle,@numero,@piso,@dpto,NULL,@codigoPostal,@ultimoIdInsertado = @idDomicilio OUTPUT;
			
			INSERT INTO MESSI_MAS3.Persona(
				persona_nombre,
				persona_apellido,
				persona_DNI,
				persona_idDomicilio,
				persona_fechaNacimiento,
				persona_fechaCreacion,
				persona_id)
			VALUES (
				@nombre,
				@apellido,
				@documento,
				@idDomicilio,
				@fechaNac,
				GETDATE(),
				@idUsuario)
			
				
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
			
			EXECUTE MESSI_MAS3.generarUsuario @cuit, '123456', @mail, @ultimoIdInsertado = @idUsuario OUTPUT;
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
				empresa_fechaCreacion)
			VALUES (
				@razonSocial,
				@telefono,
				@idDomicilio,
				@cuit,
				@idUsuario,
				@fechaCreacion)
			
				
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

/*
--Migro publicaciones de Personas
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipo,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas, publicacion_tieneEnvio)
(SELECT DISTINCT (SELECT persona_id FROM MESSI_MAS3.Persona 
			WHERE persona_DNI = Publ_Cli_Dni AND persona_apellido = Publ_Cli_Apeliido AND persona_nombre = Publ_Cli_Nombre ),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		Publicacion_Tipo,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0,
		0
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Cli_Dni IS NOT NULL ) 	AND Publicacion_Stock IS NOT NULL)
COMMIT

--Publicaciones de Empresas
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipo,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas, publicacion_tieneEnvio)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		Publicacion_Tipo,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0,
		0
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Empresa_Cuit IS NOT NULL ) AND Publicacion_Stock IS NOT NULL)	
COMMIT

--Migrar Rubros_x_Publicacion
INSERT INTO MESSI_MAS3.Rubro_x_Publicacion(idPublicacion,idRubro)
(SELECT publicacion_id, 
		publicacion_idRubro

FROM MESSI_MAS3.Publicacion)

*/


--migro publicaciones de Clientes
CREATE PROCEDURE [MESSI_MAS3].[migrarPublicacionesClientes]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@codigoPubli INT,
			@estadoPubli NVARCHAR(255),
			@codigoVisibilidadPublicacion INT,
			@fechaInicio DATETIME,
			@fechaFin DATETIME,
			@descripcion NVARCHAR(255),	
			@tipoPublicacion NVARCHAR(255),
			@tienePreguntas INT,
			@descripcionRubro NVARCHAR(255),
			@dni NVARCHAR(255),
			@publiPrecio NUMERIC(18,0),
			@stock NUMERIC(18,0)

	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Cod,
		Publicacion_Estado,
		Publicacion_Visibilidad_Cod,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Descripcion,
		Publicacion_Tipo,
		Publicacion_Rubro_Descripcion,
		Publ_Cli_Dni,
		Publicacion_Precio,
		Publicacion_Stock
	FROM gd_esquema.Maestra
	WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Cli_Dni IS NOT NULL ) 	AND Publicacion_Stock IS NOT NULL


	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@codigoPubli,
		@estadoPubli,
		@codigoVisibilidadPublicacion,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@tipoPublicacion,
		@descripcionRubro,
		@dni,
		@publiPrecio,
		@stock	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		DECLARE @idRubro INT,@idUserPublicador INT, @idEstado INT, @idVisibilidad INT
		SET @idRubro = (SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE (rubro_descripcionCorta = @descripcionRubro))
		SET @idUserPublicador = (SELECT usuario_id FROM MESSI_MAS3.Usuario WHERE (usuario_nombreUsuario = @dni))
		--SET @idEstado = (SELECT estado_id FROM MESSI_MAS3.Estado WHERE (estado_nombre = @estadoPubli))
		SET @idEstado = 4
		SET @idVisibilidad = (SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE ( @codigoVisibilidadPublicacion = visibilidad_codigo))
		INSERT INTO MESSI_MAS3.Publicacion(
		publicacion_idUsuario,
		publicacion_fechaInicio,
		publicacion_fechaFin,
		publicacion_descripcion,
		publicacion_tipo,
		publicacion_idVisibilidad,
		publicacion_idRubro,
		publicacion_idEstado,
		publicacion_codigo,
		publicacion_tieneEnvio,
		publicacion_precio,
		publicacion_stock)
		VALUES (@idUserPublicador,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@tipoPublicacion,
		@idVisibilidad,
		@idRubro,
		@idEstado,
		@codigoPubli,
		0,
		@publiPrecio,
		@stock)

		FETCH NEXT FROM cur
		INTO 
			@codigoPubli,
			@estadoPubli,
			@codigoVisibilidadPublicacion,
			@fechaInicio,
			@fechaFin,
			@descripcion,
			@tipoPublicacion,
			@descripcionRubro,
			@dni,
			@publiPrecio,
			@stock
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO

--migro publicaciones de Empresas
CREATE PROCEDURE [MESSI_MAS3].[migrarPublicacionesEmpresa]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@codigoPubli INT,
			@estadoPubli NVARCHAR(255),
			@codigoVisibilidadPublicacion INT,
			@fechaInicio DATETIME,
			@fechaFin DATETIME,
			@descripcion NVARCHAR(255),	
			@tipoPublicacion NVARCHAR(255),
			@tienePreguntas INT,
			@descripcionRubro NVARCHAR(255),
			@cuit NVARCHAR(255),
			@publiPrecio NUMERIC(18,0),
			@stock NUMERIC(18,0)
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Cod,
		Publicacion_Estado,
		Publicacion_Visibilidad_Cod,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Descripcion,
		Publicacion_Tipo,
		Publicacion_Rubro_Descripcion,
		Publ_Empresa_Cuit,
		Publicacion_Precio,
		Publicacion_Stock
	FROM gd_esquema.Maestra
	WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Empresa_Cuit IS NOT NULL ) AND Publicacion_Stock IS NOT NULL	


	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@codigoPubli,
		@estadoPubli,
		@codigoVisibilidadPublicacion,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@tipoPublicacion,
		@descripcionRubro,
		@cuit,
		@publiPrecio,
		@stock
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		DECLARE @idRubro INT,@idUserPublicador INT, @idEstado INT, @idVisibilidad INT
		SET @idRubro = (SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE (rubro_descripcionCorta = @descripcionRubro))
		SET @idUserPublicador = (SELECT usuario_id FROM MESSI_MAS3.Usuario WHERE (usuario_nombreUsuario = @cuit))				--O habria que hacerlo desde la tabla de Empresa
		--SET @idEstado = (SELECT estado_id FROM MESSI_MAS3.Estado WHERE (estado_nombre = @estadoPubli))
		SET @idEstado = 4
		SET @idVisibilidad = (SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE ( @codigoVisibilidadPublicacion = visibilidad_codigo))
		INSERT INTO MESSI_MAS3.Publicacion(
		publicacion_idUsuario,
		publicacion_fechaInicio,
		publicacion_fechaFin,
		publicacion_descripcion,
		publicacion_tipo,
		publicacion_idVisibilidad,
		publicacion_idRubro,
		publicacion_idEstado,
		publicacion_codigo,
		publicacion_precio,
		publicacion_stock)
		VALUES (@idUserPublicador,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@tipoPublicacion,
		@idVisibilidad,
		@idRubro,
		@idEstado,
		@codigoPubli,
		@publiPrecio,
		@stock
		)

		FETCH NEXT FROM cur
		INTO 
			@codigoPubli,
		@estadoPubli,
		@codigoVisibilidadPublicacion,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@tipoPublicacion,
		@descripcionRubro,
		@cuit,
		@publiPrecio,
		@stock
	END
	CLOSE cur 
	DEALLOCATE cur
	
END
GO

--PRIMERO HACER LA MIGRACION DE LAS COMPRAS, LUEGO CALIFICACIONES
CREATE PROCEDURE [MESSI_MAS3].[migrarCompras]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@dni NVARCHAR(255),
			@fechaCompra DATETIME,
			@compraCant INT,
			@codPublicacion INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Cli_Dni,
		Compra_Fecha,
		Compra_Cantidad,
		Publicacion_Cod
	FROM gd_esquema.Maestra	
		WHERE Publicacion_Tipo = 'Compra Inmediata' AND Compra_Fecha IS NOT NULL AND Compra_Cantidad IS NOT NULL AND Publicacion_Cod IS NOT NULL AND Oferta_Fecha IS NULL AND Cli_Dni IS NOT NULL
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@dni,
			@fechaCompra,
			@compraCant,
			@codPublicacion
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		DECLARE @idUser INT, @idPubli INT
		SET @idUser = (SELECT usuario_id FROM MESSI_MAS3.Usuario WHERE( @dni = usuario_nombreUsuario))
		SET @idPubli = (SELECT publicacion_id FROM MESSI_MAS3.Publicacion WHERE (publicacion_codigo = @codPublicacion))
		
		
		INSERT INTO 
		MESSI_MAS3.Compra(compras_personaComprador_id,	
		compras_fecha,
		compras_publicacion_id,
		compras_cantidad)
		VALUES (@idUser,
		 @fechaCompra, 
		 @idPubli,
		 @compraCant)

		FETCH NEXT FROM cur
		INTO @dni,
			@fechaCompra,
			@compraCant,
			@codPublicacion
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


--Migramos Calificaciones de personas
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Calificacion(califica,publicacion_codigo, publicacion_descripcion, publicacion_tipo,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas, publicacion_tieneEnvio)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		Publicacion_Tipo,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0,
		0
FROM MESSI_MAS3.Compra WHERE  IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Oferta_Monto IS NULL)
COMMIT


CREATE PROCEDURE [MESSI_MAS3].[migrarCalificacionesPersonas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@codCalif	INT,
			@idUsuarioCalificador INT,
			@idCompra INT,
			@fechaVenc DATETIME,
			@cantidadEstrellas INT,
			@CodPublicacion INT,
			@detalle NVARCHAR(45),
			@pendiente INT,
			@dniVendedor NUMERIC(18,0),
			@dniComprador NUMERIC(18,0),
			@idPersonaCalificado INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Calificacion_Codigo,	
		Publicacion_Fecha_Venc,
		Publicacion_Cod,
		Calificacion_Cant_Estrellas,
		Calificacion_Descripcion,
		Publ_Cli_Dni, --dni del vendedor
		Cli_Dni --dni del comprador
	FROM gd_esquema.Maestra	
		WHERE Publ_Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Oferta_Monto IS NULL
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@codCalif,
			@fechaVenc,
			@CodPublicacion,
			@cantidadEstrellas,
			@detalle,
			@dniVendedor,
			@dniComprador
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		SET @idUsuarioCalificador = (SELECT persona_id FROM MESSI_MAS3.Persona WHERE( @dniComprador = persona_DNI))
		SET @idPersonaCalificado = (SELECT persona_id FROM MESSI_MAS3.Persona WHERE( @dniVendedor = persona_DNI))
		DECLARE @idPubli INT, @califNeto INT
		SET @idPubli = (SELECT publicacion_id FROM MESSI_MAS3.Publicacion WHERE (@CodPublicacion = publicacion_codigo))
		SET @idCompra = (SELECT compra_id FROM MESSI_MAS3.Compra WHERE (@idPubli = compras_publicacion_id))
		EXECUTE MESSI_MAS3.ConvertirCalificacion @cantidadEstrellas, @calificacionConvertida = @califNeto OUTPUT;
		SET @pendiente = 0
		
		INSERT INTO 
		MESSI_MAS3.Calificacion(calificacion_compraId,	
		calificacion_cantidadEstrellas,
		calificacion_detalle,
		calificacion_fecha,
		calificacion_idPersonaCalificador,
		calificacion_pendiente,
		calificacion_idusuarioCalificado,
		calificacion_codigo)
		VALUES (@idCompra,
		 @califNeto, 
		 @detalle,
		 @fechaVenc,
		 @idUsuarioCalificador,
		 @pendiente,
		 @idPersonaCalificado,
		 @codCalif
		 )

		FETCH NEXT FROM cur
		INTO @codCalif,
			@fechaVenc,
			@CodPublicacion,
			@cantidadEstrellas,
			@detalle,
			@dniVendedor,
			@dniComprador
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO




CREATE PROCEDURE [MESSI_MAS3].[migrarCalificacionesEmpresa]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@codCalif	INT,
			@idUsuarioCalificador INT,
			@idCompra INT,
			@fechaVenc DATETIME,
			@cantidadEstrellas INT,
			@CodPublicacion INT,
			@detalle NVARCHAR(45),
			@pendiente INT,
			@cuitVendedor NVARCHAR(50),
			@dniComprador NUMERIC(18,0),
			@idEmpresaCalificada INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Calificacion_Codigo,	
		Publicacion_Fecha_Venc,
		Publicacion_Cod,
		Calificacion_Cant_Estrellas,
		Calificacion_Descripcion,
		Publ_Empresa_Cuit, --cuit del vendedor
		Cli_Dni --dni del comprador
	FROM gd_esquema.Maestra	
		WHERE Publ_Empresa_Cuit IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Publicacion_Cod IS NOT NULL AND Oferta_Monto IS NULL
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@codCalif,
			@fechaVenc,
			@CodPublicacion,
			@cantidadEstrellas,
			@detalle,
			@cuitVendedor,
			@dniComprador
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		SET @idUsuarioCalificador = (SELECT persona_id FROM MESSI_MAS3.Persona WHERE( @dniComprador = persona_DNI))
		SET @idEmpresaCalificada = (SELECT empresa_id FROM MESSI_MAS3.Empresa WHERE( @cuitVendedor = empresa_cuit))
		DECLARE @idPubli INT, @califNeto INT
		SET @idPubli = (SELECT publicacion_id FROM MESSI_MAS3.Publicacion WHERE (publicacion_codigo = @CodPublicacion))
		SET @idCompra = (SELECT TOP 1 compra_id FROM MESSI_MAS3.Compra WHERE (@idPubli = compras_publicacion_id AND @idUsuarioCalificador = compras_personaComprador_id))									--DEVUELVE MAS DE 1!! MITIGAR PARA QUE SEA EL CORRECTO
		
			EXECUTE MESSI_MAS3.ConvertirCalificacion @cantidadEstrellas, @calificacionConvertida = @califNeto OUTPUT;
			SET @pendiente = 0  
		
			INSERT INTO 
			MESSI_MAS3.Calificacion(calificacion_compraId,	
			calificacion_cantidadEstrellas,
			calificacion_detalle,
			calificacion_fecha,
			calificacion_idPersonaCalificador,
			calificacion_pendiente,
			calificacion_idusuarioCalificado,
			calificacion_codigo)
			VALUES (@idCompra,
			@califNeto, 
			@detalle,
			@fechaVenc,
			@idUsuarioCalificador,
			@pendiente,
			@idEmpresaCalificada,
			@codCalif
					)
		
		FETCH NEXT FROM cur
		INTO @codCalif,
			@fechaVenc,
			@CodPublicacion,
			@cantidadEstrellas,
			@detalle,
			@cuitVendedor,
			@dniComprador
	END
	CLOSE cur 
	DEALLOCATE cur

	
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
		SET @idUser = (SELECT persona_id FROM MESSI_MAS3.Persona WHERE( @dni = persona_DNI))
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
/*
--Miigro ofertas
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Oferta(oferta_persona_id, oferta_idPublicacion,oferta_fecha , oferta_valor,oferta_ganador)
(SELECT DISTINCT (SELECT persona_id FROM MESSI_MAS3.Persona 
			WHERE persona_DNI = Cli_Dni AND persona_apellido = Cli_Apeliido AND persona_nombre = Cli_Nombre ),
		MESSI_MAS3.obtenerPublicacionIdDadoCodigo(Publicacion_Cod) ,	--TARDA 3 MIN CON ESTE CODIGO, VER QUE SE PUEDE HACER, SI INSERTAMOS EL CODIGO DE PUBLI ALCANZA Y LO DEJAMOS SIN FK
		Oferta_Fecha, 
		Oferta_Monto,
		0
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND  Oferta_Fecha IS NOT NULL AND Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NULL AND (Publ_Cli_Dni IS NOT NULL OR Publ_Empresa_Cuit IS NOT NULL))
COMMIT

*/

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

--Migro las ofertas ganadoras
/*BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero)
(SELECT DISTINCT (SELECT oferta_persona_id FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Publicacion_Fecha_Venc, 
		Oferta_Monto,
		Factura_Nro
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL)
COMMIT*/


CREATE PROCEDURE [MESSI_MAS3].[migrarFacturasAPersonas]		--Tanto cabecera como detalle
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUser INT, 
			@dni NUMERIC(18,0),
			@fechaFactura DATETIME,
			@totalFactura NUMERIC (18,2),
			@nroFactura NUMERIC(18,0),
			@formaDePago NVARCHAR(255),
			@idFormaPago INT,
			@cantItemFactura NUMERIC(18,0),
			@itemMonto NUMERIC(18,2)
			
	DECLARE cur CURSOR FOR
	
	SELECT 
		Factura_Fecha,
		Factura_Total,
		Factura_Nro,
		Forma_Pago_Desc,
		Publ_Cli_Dni,
		Item_Factura_Cantidad,
		Item_Factura_Monto

		

	FROM gd_esquema.MAESTRA
	WHERE 
		Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@fechaFactura,
			@totalFactura,
			@nroFactura,
			@formaDePago,
			@dni,
			@cantItemFactura,
			@itemMonto
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		SET @idUser = (SELECT persona_id FROM MESSI_MAS3.Persona WHERE( @dni = persona_DNI))
		SET @idFormaPago = (SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE( @formaDePago = formadePago_nombre))

		INSERT INTO 
		MESSI_MAS3.Factura(factura_fecha,	
		factura_importeTotal,
		factura_numero,
		factura_idVendedor,
		factura_formaDePago)
		VALUES (@fechaFactura,
		 @totalFactura, 
		 @nroFactura,
		 @idUser,
		 @idFormaPago
		 )
		 DECLARE @idFacturaSuper INT
		 SELECT @idFacturaSuper = SCOPE_IDENTITY()
		 INSERT INTO 
		MESSI_MAS3.Factura_detalle(FacturaDetalle_valorItem,	
		facturaDetalle_numero,
		facturaDetalle_id,
		facturaDetall_cantidadItems)
		VALUES (@itemMonto,
		 @nroFactura, 
		 @idFacturaSuper,
		 @cantItemFactura
		 )

		FETCH NEXT FROM cur
		INTO @fechaFactura,
			@totalFactura,
			@nroFactura,
			@formaDePago,
			@dni,
			@cantItemFactura,
			@itemMonto
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO


CREATE PROCEDURE [MESSI_MAS3].[migrarFacturasAEmpresas]		--Tanto cabecera como detalle
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUser INT, 
			@cuit NVARCHAR(50),
			@fechaFactura DATETIME,
			@totalFactura NUMERIC (18,2),
			@nroFactura NUMERIC(18,0),
			@formaDePago NVARCHAR(255),
			@idFormaPago INT,
			@cantItemFactura NUMERIC(18,0),
			@itemMonto NUMERIC(18,2)
			
	DECLARE cur CURSOR FOR
	
	SELECT 
		Factura_Fecha,
		Factura_Total,
		Factura_Nro,
		Forma_Pago_Desc,
		Publ_Empresa_Cuit,
		Item_Factura_Cantidad,
		Item_Factura_Monto

		

	FROM gd_esquema.MAESTRA
	WHERE 
		Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@fechaFactura,
			@totalFactura,
			@nroFactura,
			@formaDePago,
			@cuit,
			@cantItemFactura,
			@itemMonto
	WHILE(@@FETCH_STATUS = 0)
	BEGIN 
		SET @idUser = (SELECT empresa_id FROM MESSI_MAS3.Empresa WHERE( @cuit = empresa_cuit))
		SET @idFormaPago = (SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE( @formaDePago = formadePago_nombre))

		INSERT INTO 
		MESSI_MAS3.Factura(factura_fecha,	
		factura_importeTotal,
		factura_numero,
		factura_idVendedor,
		factura_formaDePago)
		VALUES (@fechaFactura,
		 @totalFactura, 
		 @nroFactura,
		 @idUser,
		 @idFormaPago
		 )
		 DECLARE @idFacturaSuper INT
		 SELECT @idFacturaSuper = SCOPE_IDENTITY()
		 INSERT INTO 
		MESSI_MAS3.Factura_detalle(FacturaDetalle_valorItem,	
		facturaDetalle_numero,
		facturaDetalle_id,
		facturaDetall_cantidadItems)
		VALUES (@itemMonto,
		 @nroFactura, 
		 @idFacturaSuper,
		 @cantItemFactura
		 )

		FETCH NEXT FROM cur
		INTO @fechaFactura,
			@totalFactura,
			@nroFactura,
			@formaDePago,
			@cuit,
			@cantItemFactura,
			@itemMonto
	END
	CLOSE cur 
	DEALLOCATE cur

	
END
GO


/*
--NUEVA MIGRACION PARA FACTURAS DE EMPRESAS Y PERSONAS PROBAR SIN DETALLE
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero)
(SELECT DISTINCT (SELECT persona_id FROM MESSI_MAS3.Persona 
			WHERE persona_DNI = Publ_Cli_Dni AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Factura_Fecha, 
		Factura_Total,
		Factura_Nro


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL)
COMMIT

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Factura_Fecha, 
		Factura_Total,
		Factura_Nro


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL)

COMMIT

--Migro a la factura detalle todo
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetall_cantidadItems, facturaDetalle_item , facturaDetalle_numero,FacturaDetalle_valorItem)
(SELECT DISTINCT (SELECT factura_id FROM MESSI_MAS3.Factura 
			WHERE factura_numero = Factura_Nro AND factura_fecha = Factura_Fecha AND factura_importeTotal = Factura_Total AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		Item_Factura_Cantidad ,
		NULL, 
		Factura_Nro,
		Item_Factura_Monto


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL)
COMMIT

--MIGRACION DE COMPRAS NUEVA MODELO A SEGUIR
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Compra(compras_personaComprador_id, compras_cantidad, compras_fecha , compras_publicacion_id)
(SELECT DISTINCT (SELECT persona_id FROM MESSI_MAS3.Persona 
			WHERE persona_DNI = Cli_Dni AND Compra_Fecha IS NOT NULL AND Oferta_Fecha IS NULL ),
		Compra_Cantidad ,
		Compra_Fecha, 
		(SELECT publicacion_id FROM MESSI_MAS3.Publicacion WHERE Publicacion_Cod = publicacion_codigo)


FROM gd_esquema.Maestra WHERE Compra_Cantidad IS NOT NULL AND Compra_Fecha IS NOT NULL)

COMMIT

*/

/*---------------------------EXEC DE PARA MIGRAR---------------------------*/

EXEC MESSI_MAS3.meterDatosFijos
PRINT 'DATOS INICIALES MIGRADOS';
EXEC MESSI_MAS3.migrarRubros
PRINT 'RUBROS MIGRADOS';
EXEC MESSI_MAS3.migrarPersonas
PRINT 'PERSONAS MIGRADAS';
EXEC MESSI_MAS3.migrarEmpresas
PRINT 'EMPRESAS MIGRADAS';
/*
EXEC MESSI_MAS3.migrarPublicacionesEmpresa
PRINT 'PUBLICACIONES DE EMPRESA MIGRADAS';

EXEC MESSI_MAS3.migrarPublicacionesClientes
PRINT 'PUBLICACIONES DE CLIENTES MIGRADAS';
EXEC MESSI_MAS3.migrarCompras
PRINT 'COMPRAS INMEDIATAS MIGRADAS';
EXEC MESSI_MAS3.migrarOfertas
PRINT 'OFERTAS MIGRADAS - SIN GANADORES';
EXEC MESSI_MAS3.buscarGanadoresOfertasEInsertarEnCompras
PRINT 'SUBASTAS MIGRADAS CON GANADORES';
EXEC MESSI_MAS3.migrarFacturasAPersonas
PRINT 'FACTURAS A PERSONAS MIGRADAS';
EXEC MESSI_MAS3.migrarFacturasAEmpresas
PRINT 'FACTURAS A EMPRESAS MIGRADAS';
EXEC MESSI_MAS3.migrarCalificacionesPersonas
PRINT 'CALIFICACIONES DE PERSONAS MIGRADAS';
EXEC MESSI_MAS3.migrarCalificacionesEmpresa
PRINT 'CALIFICACIONES DE EMPRESAS MIGRADAS';*/

