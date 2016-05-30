/*------ABM DE ROL------*/
CREATE PROCEDURE MESSI_MAS3.get_funcionalidades(@rol nvarchar(255))
AS				--Puede crashear ya que los nombres de la columna coinciden con los de la tabla intermedia
BEGIN
	SELECT funcionalidad_id, funcionalidad_descripcion FROM MESSI_MAS3.Funcionalidad, MESSI_MAS3.Funcionalidad_Rol, MESSI_MAS3.Rol
	WHERE funcionalidad_id = Funcionalidad_id AND
	rol_id = Rol_id AND
	rol_nombre = @rol
END
GO

CREATE PROCEDURE MESSI_MAS3.get_funcionalidades_que_no_tiene(@rol nvarchar(255))
AS
BEGIN 
SELECT funcionalidad_id, funcionalidad_descripcion FROM MESSI_MAS3.FUNCIONALIDAD
WHERE NOT EXISTS (SELECT 1 FROM MESSI_MAS3.Funcionalidad_Rol, MESSI_MAS3.ROL
	WHERE Funcionalidad_id = funcionalidad_id AND 
	Rol_id = rol_id AND
	rol_nombre = @rol)
END
GO

CREATE PROCEDURE MESSI_MAS3.get_roles
AS
BEGIN
	SELECT rol_nombre, rol_deleted FROM MESSI_MAS3.ROL
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
	INSERT INTO MESSI_MAS3.ROL(rol_nombre, rol_deleted)
	VALUES(@descripcion, @estado)
END
GO


CREATE PROCEDURE MESSI_MAS3.bajar_rol(@descripcion nvarchar(255))
AS
BEGIN
	UPDATE MESSI_MAS3.ROL
	SET rol_deleted = 1
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
	INSERT INTO MESSI_MAS3.Funcionalidad_Rol(Rol_id, Funcionalidad_id) VALUES ((SELECT TOP 1 rol_id FROM MESSI_MAS3.ROL WHERE rol_nombre = @rol),
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
	WHERE Funcionalidad_id = (SELECT funcionalidad_id FROM MESSI_MAS3.FUNCIONALIDAD WHERE funcionalidad_descripcion = @descripcion_func)
	AND Rol_id = (SELECT MESSI_MAS3.getIdRol(@rol))

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
	SET rol_deleted = 0
	WHERE rol_nombre = @nombre
END
GO