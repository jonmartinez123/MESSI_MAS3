CREATE PROCEDURE [MESSI_MAS3].validar_usuario (@nombreUsuario NVARCHAR(255), @password NVARCHAR(255))
AS 
BEGIN
	RETURN SELECT COUNT (*) FROM MESSI_MAS3.Usuario WHERE usuario_nombreUsuario = @nombreUsuario AND usuario_contrasenia = @password
END
GO

CREATE PROCEDURE [MESSI_MAS3].existe_usuario (@nombreUsuario NVARCHAR(255))
AS 
BEGIN
	RETURN SELECT COUNT(*) FROM MESSI_MAS3.Usuario WHERE usuario_nombreUsuario = @nombreUsuario
END
GO

CREATE PROCEDURE [MESSI_MAS3].traer_intentos (@nombreUsuario NVARCHAR(255))
AS 
BEGIN
	RETURN SELECT usuario_intentos FROM MESSI_MAS3.Usuario WHERE usuario_nombreUsuario = @nombreUsuario
END
GO