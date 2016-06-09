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

CREATE PROCEDURE MESSI_MAS3.get_clientesFiltrados(@nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni NUMERIC(18,0))
AS				
BEGIN
	SELECT usuario_id, usuario_nombreUsuario, cliente_nombre, cliente_apellido, cliente_DNI, cliente_mail, usuario_deleted 
	FROM MESSI_MAS3.Cliente, MESSI_MAS3.Usuario
	WHERE cliente_id = usuario_id 
		AND cliente_nombre LIKE CONCAT('%', @nombre, '%')
		AND cliente_apellido LIKE CONCAT('%', @apellido, '%')
		AND cliente_mail LIKE CONCAT('%', @mail, '%')
		AND cliente_DNI LIKE CONCAT('%', @dni, '%')
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
		AND empresa_cuit LIKE CONCAT('%', @cuit, '%')
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

	INSERT INTO MESSI_MAS3.Empresa(empresa_id, empresa_razonSocial, empresa_mail, empresa_cuit, empresa_telefono, empresa_nombreContacto, empresa_rubroId)
	VALUES (@idUsuario, @razonSocial, @mail, @cuit, @telefono, @nombreContacto, @idRubro)
END
GO