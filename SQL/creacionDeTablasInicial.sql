USE[GD1C2016]
GO

--CREATE SCHEMA [MESSI_MAS3] AUTHORIZATION [gd]

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
  usuario_contrasenia NVARCHAR(30) NULL,				--Cambiado de NOT NULL a NULL y el nombre a 'contrasenia'
  usuario_mail NVARCHAR(50) NOT NULL UNIQUE,	--LINEA PELIGROSA VIGILAR!!
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
  persona_mail NVARCHAR(255) NOT NULL,
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
  empresa_telefono VARCHAR(10) NOT NULL,
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
  publicacion_idEstado INT REFERENCES MESSI_MAS3.Estado (estado_id),
  publicacion_idVisibilidad INT REFERENCES MESSI_MAS3.Visibilidad (visibilidad_id),
  publicacion_idUsuario INT REFERENCES MESSI_MAS3.Usuario (usuario_id),
  publicacion_fechaInicio DATETIME NOT NULL,
  publicacion_fechaFin DATETIME NOT NULL,
  publicacion_descripcion VARCHAR(255) NULL,
  publicacion_admitePreguntas INT DEFAULT 0 NOT NULL,
  publicacion_tipo NVARCHAR(255) NOT NULL,
  publicacion_minimoSubasta NUMERIC(10,2) DEFAULT 0.00,			--DUDA MIRAR KOIFFO EL TIPO DE LA VARIABLE
  publicacion_precio NUMERIC(18,2),
  publicacion_idRubro INT NOT NULL,
  publiacion_tieneEnvio INT NOT NULL,
  
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
  calificacion_pendiente INT DEFAULT 0 NOT NULL,					--ACA!!!
  calificacion_idusuarioCalificado INT REFERENCES MESSI_MAS3.Usuario(usuario_id),
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
  facturaDetalle_item NVARCHAR(255) NOT NULL,
  facturaDetalle_id INT PRIMARY KEY REFERENCES MESSI_MAS3.Factura (factura_id),
  facturaDetall_cantidadItems NUMERIC(18,0) NOT NULL,
  
 )

 GO
 
 -- -----------------------------------------------------
-- PROCEDURES
-- -----------------------------------------------------

--CREO DATOS INICIALES
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

END
GO

-- sp genero el usuario y devuelvo el id, me sirve para insertarlo de nuevo
CREATE PROCEDURE [MESSI_MAS3].[generarUsuario](@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoIdInsertado INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO MESSI_MAS3.Usuario(usuario_nombreUsuario,usuario_contrasenia, usuario_mail) 
	VALUES (@usuario,@password,@mail)
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
		Cli_Dni IS NOT NULL

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
			EXECUTE MESSI_MAS3.generarUsuario @documento,'123',@mail,@ultimoIdInsertado = @idUsuario OUTPUT; --esta bien esta linea?? por el documento pasado como param
			DECLARE @idRol int;
			SET @idRol = (select rol_id from MESSI_MAS3.Rol where rol_nombre = 'Cliente')
			INSERT INTO MESSI_MAS3.Rol_Usuario(Rol_id,Usuario_id)
			VALUES(@idRol, @idUsuario)
			DECLARE @idDomicilio int;
			EXECUTE MESSI_MAS3.generarDomicilio @calle,@numero,@piso,@dpto,NULL,@codigoPostal,@ultimoIdInsertado = @idDomicilio;
			
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
		Publ_Empresa_Cuit IS NOT NULL
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
			
			EXECUTE MESSI_MAS3.generarUsuario @cuit, NULL, @mail, @ultimoIdInsertado = @idUsuario OUTPUT;
			DECLARE @idRol int;
			DECLARE @idDomicilio int;
			EXECUTE MESSI_MAS3.generarDomicilio @calle,@numero,@piso,@dpto,NULL,@codigoPostal,@ultimoIdInsertado = @idDomicilio;
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

--migrar todas las visibilidades
CREATE PROCEDURE [MESSI_MAS3].[migrarVisibilidades]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@codigo INT,
			@descripcion NVARCHAR(255),
			@precio numeric(18,2),
			@porcentaje numeric(18,2)
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Visibilidad_Cod, 
		Publicacion_Visibilidad_Desc, 
		Publicacion_Visibilidad_Precio,
		Publicacion_Visibilidad_Porcentaje
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@codigo,
		@descripcion,
		@precio,
		@porcentaje
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO MESSI_MAS3.Visibilidad(visibilidad_codigo, visibilidad_descripcion, visibilidad_precio, visibilidad_porcentaje)
		VALUES (@codigo, @descripcion, @precio, @porcentaje)

		FETCH NEXT FROM cur
		INTO 
			@codigo,
			@descripcion,
			@precio,
			@porcentaje
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO

--CONTINUAR CON ESTO
CREATE PROCEDURE [MESSI_MAS3].[migrarCalificaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
		@id	INT,
		@idUsuarioCalificador INT,
		@idPublicacion INT,
		@fecha DATETIME,
		@valor INT,
		@detalle NVARCHAR(45),
		@pendiente INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Calificacion_Codigo,	
		Publicacion_Fecha_Venc,
		Calificacion_Cant_Estrellas,
		Calificacion_Descripcion
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@id,
			@fecha,
			@valor,
			@detalle
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		-- SET @id 
		SET @idUsuarioCalificador = (SELECT id FROM MESSI_MAS3.Usuario WHERE (SELECT Publ_Cli_Dni from gd_esquema.Maestra) = usuario or (SELECT Publ_Empresa_Cuit from gd_esquema.Maestra) = usuario )
		SET @pendiente = 1
		
		INSERT INTO 
		MESSI_MAS3.Calificacion(idPublicacion,	
		fecha,
		valor,
		detalle)
		VALUES (@idPublicacion,
		 @fecha, 
		 @valor,
		 @detalle)

		FETCH NEXT FROM cur
		INTO @idPublicacion,
		 @fecha, 
		 @valor,
		 @detalle
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO

