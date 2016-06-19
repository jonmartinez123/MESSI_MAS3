CREATE PROCEDURE [MESSI_MAS3].getPublicaciones @idUsuario int
AS
BEGIN
SELECT publicacion_id,publicacion_tipoPublicacionId,tipoPublicacion_nombre,tipoPublicacion_tieneEnvio,publicacion_idEstado,estado_nombre,visibilidad_id,visibilidad_descripcion,visibilidad_precio,visibilidad_porcentaje,visibilidad_costoEnvio,publicacion_fechaInicio,publicacion_fechaFin,publicacion_descripcion,publicacion_minimoSubasta,publicacion_precio,publicacion_seCobraEnvio,publicacion_stock FROM tipoPublicacion,Estado,Visibilidad,Publicacion WHERE @idUsuario = publicacion_idUsuario AND publicacion_idVisibilidad = visibilidad_id AND publicacion_idEstado = estado_id AND publicacion_tipoPublicacionId = tipoPublicacion_id
END
GO

CREATE PROCEDURE [MESSI_MAS3].getRubrosPorPublicacion @idPublicacion int
AS
BEGIN
SELECT rubro_id,rubro_descripcionCorta,rubro_descripcionLarga FROM Publicacion,Rubro_x_Publicacion,Rubro WHERE publicacion_id=@idPublicacion AND publicacion_id=Rubro_x_Publicacion.idPublicacion AND rubro_id = Rubro_x_Publicacion.idRubro
END
GO

CREATE PROCEDURE [MESSI_MAS3].insertarPublicacion @idEstado int, @idVisibilidad int,@idUsuario int,@idTipoPublicacion int, @descripcion nvarchar(255),@fechaInicio dateTime, @fechaFin dateTime,@minimoSubasta numeric(10,2),@precio numeric(18,2),@stock numeric(18,0),@seCobraEnvio int
AS
BEGIN
INSERT INTO Publicacion(publicacion_idEstado,publicacion_idVisibilidad,publicacion_idUsuario,publicacion_fechaInicio,publicacion_fechaFin,publicacion_descripcion,publicacion_tipoPublicacionId,publicacion_minimoSubasta,publicacion_precio,publicacion_stock,publicacion_seCobraEnvio) VALUES(@idEstado,@idVisibilidad,@idUsuario,@fechaInicio,@fechaFin,@descripcion,@idTipoPublicacion,@minimoSubasta,@precio,@stock,@seCobraEnvio)
END
GO