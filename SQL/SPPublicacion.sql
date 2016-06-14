CREATE PROCEDURE [MESSI_MAS3].getPublicaciones @idUsuario int
AS
BEGIN
SELECT publicacion_id,publicacion_idEstado,estado_nombre,visibilidad_id,visibilidad_descripcion,publicacion_fechaInicio,publicacion_fechaFin,publicacion_descripcion,publicacion_precio,publicacion_idRubro,rubro_descripcionCorta,publicacion_stock FROM Estado,Visibilidad,Publicacion,Rubro WHERE @idUsuario = publicacion_idUsuario AND publicacion_idVisibilidad = visibilidad_id AND publicacion_idEstado = estado_id AND rubro_id = publicacion_idRubro
END
GO