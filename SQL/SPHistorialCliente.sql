CREATE PROCEDURE [MESSI_MAS3].[get_historialClienteID](@idUsuario INT)
AS BEGIN

SELECT compras_publicacion_id, compras_fecha, tipoPublicacion_nombre, publicacion_precio  FROM MESSI_MAS3.Compra,MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 
	WHERE (compras_publicacion_id = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_id) AND (compras_personaComprador_id = @idUsuario)

UNION ALL

SELECT oferta_idPublicacion, oferta_fecha, tipoPublicacion_nombre, oferta_valor  FROM MESSI_MAS3.Oferta,MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion
	WHERE (oferta_idPublicacion = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_id) AND (oferta_persona_id = @idUsuario)


END
GO

