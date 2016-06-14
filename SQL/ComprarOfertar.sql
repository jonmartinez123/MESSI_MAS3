CREATE PROCEDURE MESSI_MAS3.get_ultimaOferta(@idPublicacion INT)
AS
BEGIN
	SELECT ISNULL(MAX(oferta_valor), (SELECT publicacion_minimoSubasta FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion)) AS valorMax
	FROM MESSI_MAS3.Oferta
	WHERE oferta_idPublicacion = @idPublicacion
END
GO

CREATE PROCEDURE MESSI_MAS3.crearOferta(@valor NUMERIC(18,2), @idUsuario INT, @idPublicacion INT)
AS
BEGIN
	INSERT INTO MESSI_MAS3.Oferta(oferta_valor, oferta_persona_id, oferta_idPublicacion, oferta_fecha)
	VALUES(@valor, @idUsuario, @idPublicacion, GETDATE())
END
GO

CREATE PROCEDURE MESSI_MAS3.filtrarPublicacionPorRubro(@idRubro INT)
AS
BEGIN
	SELECT publicacion_id, publicacion_codigo, publicacion_descripcion, publicacion_precio, publicacion_minimoSubasta, publicacion_stock, visibilidad_descripcion
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad
	WHERE (publicacion_idEstado = 2 
		AND publicacion_idVisibilidad = visibilidad_id
		AND publicacion_idRubro = @idRubro)
END
GO

CREATE PROCEDURE MESSI_MAS3.filtrarPublicacionPorDescripcion(@idRubro INT, @descripcion NVARCHAR(255))
AS
BEGIN
	SELECT publicacion_id, publicacion_codigo, publicacion_descripcion, publicacion_precio, publicacion_minimoSubasta, publicacion_stock, visibilidad_descripcion
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad
	WHERE publicacion_idEstado = 2 
		AND publicacion_idVisibilidad = visibilidad_id
		AND publicacion_idRubro = @idRubro
		AND publicacion_descripcion LIKE CONCAT('%', @descripcion, '%')
END
GO
