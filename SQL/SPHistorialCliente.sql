CREATE PROCEDURE [MESSI_MAS3].[get_historialClienteID](@idUsuario INT)
AS BEGIN

SELECT compras_publicacion_id, compras_fecha, tipoPublicacion_nombre, publicacion_precio, publicacion_descripcion  FROM MESSI_MAS3.Compra,MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 
	WHERE (compras_publicacion_id = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_id) AND (compras_personaComprador_id = @idUsuario)

UNION ALL

SELECT oferta_idPublicacion, oferta_fecha, tipoPublicacion_nombre, oferta_valor, publicacion_descripcion  FROM MESSI_MAS3.Oferta,MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion
	WHERE (oferta_idPublicacion = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_id) AND (oferta_persona_id = @idUsuario)


END
GO

CREATE PROCEDURE [MESSI_MAS3].[get_resumenComprasUsuario](@idUsuario INT)
AS BEGIN

SELECT
	(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 1)),
	(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 0)),
	(SELECT SUM(calificacion_cantidadEstrellas) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 0)),
	(SELECT COUNT(*) FROM MESSI_MAS3.Oferta WHERE (oferta_persona_id = @idUsuario AND oferta_ganador = 1))



END
GO

