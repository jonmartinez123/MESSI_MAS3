CREATE PROCEDURE [MESSI_MAS3].getFuncionalidadesFuncionalidades (@idRol int)
AS
BEGIN
	SELECT Funcionalidad.funcionalidad_id,Funcionalidad.funcionalidad_descripcion FROM Funcionalidad,Funcionalidad_Rol WHERE Rol_func_id = @idRol AND Funcionalidad_Rol.Funcionalidad_rol_id = Funcionalidad.funcionalidad_id AND Funcionalidad_Rol.deleted=0
END 
GO