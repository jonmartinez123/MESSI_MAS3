
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
	SELECT MESSI_MAS3.Rol.rol_id, rol_nombre FROM MESSI_MAS3.Rol_Usuario,MESSI_MAS3.Rol WHERE Usuario_id=@id AND MESSI_MAS3.Rol_Usuario.Rol_id = MESSI_MAS3.Rol.rol_id AND rol_deleted=0
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

CREATE PROCEDURE [MESSI_MAS3].getMail (@id int)
AS
BEGIN
	SELECT  usuario_mail FROM MESSI_MAS3.Usuario WHERE usuario_id=@id
END
GO

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