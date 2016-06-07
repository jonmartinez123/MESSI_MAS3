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
	SELECT cliente_nombre, cliente_apellido, cliente_DNI, cliente_tipoDocumento_id, cliente_mail, cliente_tel, domicilio_calle, domicilio_altura, domicilio_piso, domicilio_departamento, domicilio_codigoPostal, domicilio_localidad_id
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

CREATE PROCEDURE MESSI_MAS3.modificar_cliente(@idCliente INT, @nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni INT, @fechaNacimiento DATETIME, @telefono NUMERIC(15,0), @idTipoDocumento INT, @idLocalidad INT, @calle nvarchar(100), @altura NUMERIC(18,0), @piso NUMERIC(18,0), @departamento NVARCHAR(50), @ciudad NVARCHAR(45), @codigoPostal NVARCHAR(50))
AS
BEGIN
	UPDATE MESSI_MAS3.Cliente
	SET cliente_nombre = @nombre, cliente_apellido = @apellido, cliente_mail = @mail, cliente_DNI = @dni, cliente_fechaNacimiento = @fechaNacimiento, cliente_tel = @telefono, cliente_tipoDocumento_id = @idTipoDocumento 
	WHERE cliente_id = @idCliente

	DECLARE @idDomicilioCliente INT
	SELECT cliente_idDomicilio = @idDomicilioCliente FROM MESSI_MAS3.Cliente WHERE cliente_id = @idCliente

	UPDATE MESSI_MAS3.Domicilio
	SET domicilio_localidad_id = @idLocalidad, domicilio_calle = @calle , domicilio_altura = @altura, domicilio_piso = @piso, domicilio_departamento = @departamento ,domicilio_ciudad = @ciudad, domicilio_codigoPostal = @codigoPostal
	WHERE domicilio_idDomicilio = @idDomicilioCliente
END
GO