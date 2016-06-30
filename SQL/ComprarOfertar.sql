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

CREATE PROCEDURE MESSI_MAS3.crearCompra(@idPublicacion INT, @idUsuario INT, @cantidad INT)
AS
BEGIN
	INSERT INTO MESSI_MAS3.Compra(compras_publicacion_id, compras_fecha, compras_personaComprador_id, compras_cantidad)
	VALUES(@idPublicacion, GETDATE(), @idUsuario, @cantidad)

	DECLARE @stock INT
	SELECT @stock = (publicacion_stock - @cantidad) FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion

	UPDATE MESSI_MAS3.Publicacion
	SET publicacion_stock = @stock
	WHERE publicacion_id = @idPublicacion

	IF @stock = 0
		BEGIN
		UPDATE MESSI_MAS3.Publicacion
		SET publicacion_idEstado = 4
		WHERE publicacion_id = @idPublicacion
		END

	DECLARE @idFactura INT
	SELECT @idFactura = factura_id FROM MESSI_MAS3.Factura WHERE factura_publicacionId = @idPublicacion

	DECLARE @valorItem numeric(18,2)
	SELECT @valorItem = (publicacion_precio * @cantidad * visibilidad_porcentaje)
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad
	WHERE publicacion_id = @idPublicacion AND publicacion_idVisibilidad = visibilidad_id

	DECLARE @ultimoNumero int
	select top 1 @ultimoNumero=factura_numero from Factura order by factura_numero desc
	SET @ultimoNumero = @ultimoNumero + 1

	INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetalle_item,FacturaDetalle_valorItem, facturaDetall_cantidadItems, facturaDetalle_numero)
	VALUES(@idFactura, 'Comision por visibilidad', @valorItem , 1, @ultimoNumero)

	DECLARE @costoEnvio numeric(18, 2) = 0
	IF (SELECT publicacion_seCobraEnvio FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion) = 1
		BEGIN
		SELECT @costoEnvio = visibilidad_costoEnvio FROM MESSI_MAS3.Visibilidad, MESSI_MAS3.Publicacion WHERE publicacion_idVisibilidad = visibilidad_id

		INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetalle_item, FacturaDetalle_valorItem, facturaDetall_cantidadItems, facturaDetalle_numero)
		VALUES(@idFactura, 'Costo de envio', @costoEnvio , 1, @ultimoNumero)
		END

	UPDATE MESSI_MAS3.Factura
	SET factura_importeTotal = (SELECT factura_importeTotal FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion) + @costoEnvio + @valorItem
	WHERE factura_publicacionId = @idPublicacion

	RETURN @idFactura

END
GO

CREATE PROCEDURE MESSI_MAS3.obtenerPublicacionesActivas(@idUsuario INT)
AS
BEGIN
	SELECT publicacion_id, publicacion_codigo, tipoPublicacion_nombre, publicacion_descripcion, publicacion_precio, publicacion_minimoSubasta, publicacion_stock, visibilidad_id, visibilidad_descripcion
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad, MESSI_MAS3.tipoPublicacion
	WHERE (publicacion_idEstado = 2
		AND publicacion_tipoPublicacionId = tipoPublicacion_id 
		AND publicacion_idVisibilidad = visibilidad_id
		AND publicacion_idUsuario <> @idUsuario)
END
GO

CREATE PROCEDURE MESSI_MAS3.filtrarPublicacionPorRubro(@idRubro INT, @descripcion NVARCHAR(255), @idUsuario INT)
AS
BEGIN
	SELECT publicacion_id, publicacion_codigo, tipoPublicacion_nombre, publicacion_descripcion, publicacion_precio, publicacion_minimoSubasta, publicacion_stock, visibilidad_id, visibilidad_descripcion
	FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad, MESSI_MAS3.tipoPublicacion, MESSI_MAS3.Rubro_x_Publicacion
	WHERE (publicacion_idEstado = 2
		AND publicacion_tipoPublicacionId = tipoPublicacion_id 
		AND publicacion_idVisibilidad = visibilidad_id
		AND Rubro_x_Publicacion.idRubro = @idRubro
		AND Rubro_x_Publicacion.idPublicacion = publicacion_id
		AND publicacion_descripcion LIKE CONCAT('%', @descripcion, '%')
		AND publicacion_idUsuario <> @idUsuario)
END
GO

CREATE PROCEDURE MESSI_MAS3.get_formasDePago
AS
BEGIN
	SELECT formaDePago_id, formaDePago_nombre
	FROM MESSI_MAS3.FormaDePago
END
GO