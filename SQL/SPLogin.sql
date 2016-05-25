CREATE PROCEDURE [MESSI_MAS3].validar_usuario (@nombreUsuario NVARCHAR(255), @password NVARCHAR(255))
AS 
BEGIN
	IF EXISTS (SELECT 1 FROM MESSI_MAS3.Usuario 
  WHERE usuario_nombreUsuario = @nombreUsuario AND usuario_contrasenia=@password)
   BEGIN
    RETURN 1
	 END
	RETURN -1
END
GO

CREATE PROCEDURE [MESSI_MAS3].traer_intentos (@nombreUsuario NVARCHAR(255))
AS 
BEGIN
	DECLARE @cant int
	SELECT @cant = usuario_intentos FROM MESSI_MAS3.Usuario WHERE usuario_nombreUsuario = @nombreUsuario
	RETURN @cant
END
GO

CREATE PROCEDURE [MESSI_MAS3].vaciar_intentos (@nombreUsuario NVARCHAR(255))
AS 
BEGIN
	UPDATE MESSI_MAS3.Usuario SET usuario_intentos=0  WHERE usuario_nombreUsuario = @nombreUsuario
END
GO

CREATE PROCEDURE [MESSI_MAS3].aumentar_intentos (@nombreUsuario NVARCHAR(255))
AS 
BEGIN
	UPDATE MESSI_MAS3.Usuario SET usuario_intentos=usuario_intentos+1  WHERE usuario_nombreUsuario = @nombreUsuario
END
GO