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


CREATE TYPE Rubros AS TABLE 
(
idRubro INT NOT NULL
PRIMARY KEY (idRubro)
)
GO

CREATE PROCEDURE [MESSI_MAS3].updetearEstado @idPublicacion int,@idEstado int
AS
BEGIN
UPDATE Publicacion SET publicacion_idEstado = @idEstado where @idPublicacion = publicacion_id
END
GO

CREATE PROCEDURE [MESSI_MAS3].updatearPublicacion (@idPublicacion int, @idEstado int, @idVisibilidad int,@idUsuario int,@idTipoPublicacion int, @descripcion nvarchar(255),@fechaInicio dateTime, @fechaFin dateTime,@minimoSubasta numeric(10,2),@precio numeric(18,2),@stock numeric(18,0),@seCobraEnvio int, @Rubros Rubros READONLY)
AS
BEGIN
UPDATE Publicacion SET publicacion_idEstado=@idEstado,publicacion_idVisibilidad=@idVisibilidad,
	publicacion_idUsuario=@idUsuario,publicacion_fechaInicio=@fechaInicio,
	publicacion_fechaFin=@fechaFin
	,publicacion_descripcion=@descripcion,
	publicacion_tipoPublicacionId=@idTipoPublicacion
	,publicacion_minimoSubasta=@minimoSubasta,publicacion_precio=@precio,publicacion_stock=@stock,publicacion_seCobraEnvio=@seCobraEnvio
	 where @idPublicacion = publicacion_id
DELETE FROM Rubro_x_Publicacion WHERE idPublicacion = @idPublicacion
INSERT INTO Rubro_x_Publicacion(idRubro,idPublicacion) (select idRubro,@idPublicacion from @Rubros)
END
GO

CREATE PROCEDURE [MESSI_MAS3].insertarPublicacion (@idEstado int, @idVisibilidad int,@idUsuario int,@idTipoPublicacion int, @descripcion nvarchar(255),@fechaInicio dateTime, @fechaFin dateTime,@minimoSubasta numeric(10,2),@precio numeric(18,2),@stock numeric(18,0),@seCobraEnvio int, @Rubros Rubros READONLY)
AS
BEGIN
DECLARE @ultimoCodigo int 
SELECT top 1 @ultimoCodigo=publicacion_codigo from MESSI_MAS3.Publicacion order by publicacion_codigo DESC
SET @ultimoCodigo = @ultimoCodigo + 1
INSERT INTO Publicacion(publicacion_codigo,publicacion_idEstado,publicacion_idVisibilidad,publicacion_idUsuario,publicacion_fechaInicio,publicacion_fechaFin,publicacion_descripcion,publicacion_tipoPublicacionId,publicacion_minimoSubasta,publicacion_precio,publicacion_stock,publicacion_seCobraEnvio) 
VALUES(@ultimoCodigo,@idEstado,@idVisibilidad,@idUsuario,@fechaInicio,@fechaFin,@descripcion,@idTipoPublicacion,@minimoSubasta,@precio,@stock,@seCobraEnvio)
INSERT INTO Rubro_x_Publicacion(idRubro,idPublicacion) (select idRubro,SCOPE_IDENTITY() from @Rubros)
END
GO

CREATE PROCEDURE [MESSI_MAS3].getTipoPublicacion
AS
BEGIN
SELECT * FROM tipoPublicacion
END
GO

CREATE PROCEDURE [MESSI_MAS3].activarPublicacion (@idPublicacion int,@fechaActiva dateTime,@idUsuario int,@formaDePago int,@importeTotal numeric(18,2))
AS
BEGIN
	--GENERA FACTURA
	DECLARE @ultimoNumero int
	DECLARE @idFactura int
	select top 1 @ultimoNumero=factura_numero from Factura order by factura_numero desc
	SET @ultimoNumero = @ultimoNumero + 1
	
	IF((SELECT usuario_primeraPublicacion FROM MESSI_MAS3.Usuario WHERE usuario_id = @idUsuario) = 1)
	BEGIN
			IF((SELECT publicacion_idVisibilidad FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @idPublicacion) != 5)

			BEGIN
			INSERT INTO Factura(factura_fecha,factura_formaDePago,factura_idVendedor,factura_publicacionId,factura_numero,factura_importeTotal) values(@fechaActiva,@formaDePago,@idUsuario,@idPublicacion,@ultimoNumero,0)
			SET @idFactura = SCOPE_IDENTITY()
			INSERT INTO Factura_detalle(facturaDetalle_id,facturaDetalle_numero,facturaDetall_cantidadItems,FacturaDetalle_valorItem,facturaDetalle_item)
			VALUES (@idFactura,@ultimoNumero,1,0,'Primera publicacion gratis')
			UPDATE MESSI_MAS3.Usuario SET usuario_primeraPublicacion = 0 WHERE usuario_id = @idUsuario --seteamos en 0, ya no es mas usuario nuevo
			RETURN @idFactura
				END

				ELSE

				BEGIN 
					INSERT INTO Factura(factura_fecha,factura_formaDePago,factura_idVendedor,factura_publicacionId,factura_numero,factura_importeTotal) values(@fechaActiva,@formaDePago,@idUsuario,@idPublicacion,@ultimoNumero,@importeTotal)
					SET @idFactura = SCOPE_IDENTITY()
					INSERT INTO Factura_detalle(facturaDetalle_id,facturaDetalle_numero,facturaDetall_cantidadItems,FacturaDetalle_valorItem,facturaDetalle_item)
					VALUES (@idFactura,@ultimoNumero,1,@importeTotal,'Activo de publicacion')
					RETURN @idFactura

				END
	END



	IF((SELECT usuario_primeraPublicacion FROM MESSI_MAS3.Usuario WHERE usuario_id = @idUsuario) = 0 )

	BEGIN

	INSERT INTO Factura(factura_fecha,factura_formaDePago,factura_idVendedor,factura_publicacionId,factura_numero,factura_importeTotal) values(@fechaActiva,@formaDePago,@idUsuario,@idPublicacion,@ultimoNumero,@importeTotal)
	SET @idFactura = SCOPE_IDENTITY()
	INSERT INTO Factura_detalle(facturaDetalle_id,facturaDetalle_numero,facturaDetall_cantidadItems,FacturaDetalle_valorItem,facturaDetalle_item)
	VALUES (@idFactura,@ultimoNumero,1,@importeTotal,'Activo de publicacion')
	RETURN @idFactura

	END
END
GO

CREATE PROCEDURE [MESSI_MAS3].cambiarEstadoDeSubastasVencidas (@FechaSistema dateTime)
AS
DECLARE @id int
BEGIN
	DECLARE c1 CURSOR FOR (SELECT publicacion_id FROM Publicacion where publicacion_idEstado <> 4 and publicacion_tipoPublicacionId = 1 and (SELECT DATEDIFF(day,publicacion_fechaFin,@FechaSistema)) >= 1)
	OPEN c1
	FETCH NEXT FROM c1 INTO @id
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @valorMaximo numeric(18,2),@idOferta int,@idFactura INT,@costoEnvio numeric(18, 2) = 0
		SELECT top 1 @valorMaximo = oferta_valor, @idOferta=oferta_id FROM Oferta where oferta_idPublicacion = @id order by oferta_valor desc
		UPDATE Oferta SET oferta_ganador = 1 where oferta_id = @idOferta

		DECLARE @ultimoNumero int
		select top 1 @ultimoNumero=factura_numero from Factura order by factura_numero desc
		SET @ultimoNumero = @ultimoNumero + 1

		DECLARE @valorItem numeric(18,2)
		SELECT @valorItem = (@valorMaximo * visibilidad_porcentaje)
		FROM MESSI_MAS3.Publicacion, MESSI_MAS3.Visibilidad
		WHERE publicacion_id = @id AND publicacion_idVisibilidad = visibilidad_id

		SELECT @idFactura = factura_id FROM MESSI_MAS3.Factura WHERE factura_publicacionId = @id

		INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetalle_item,FacturaDetalle_valorItem, facturaDetall_cantidadItems, facturaDetalle_numero)
		VALUES(@idFactura, 'Comision por visibilidad', @valorItem , 1, @ultimoNumero)

		IF (SELECT publicacion_seCobraEnvio FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @id) = 1
		BEGIN
		SELECT @costoEnvio = visibilidad_costoEnvio FROM MESSI_MAS3.Visibilidad, MESSI_MAS3.Publicacion WHERE publicacion_idVisibilidad = visibilidad_id

		INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetalle_item, FacturaDetalle_valorItem, facturaDetall_cantidadItems, facturaDetalle_numero)
		VALUES(@idFactura, 'Costo de envio', @costoEnvio , 1, @ultimoNumero)
		END

		UPDATE MESSI_MAS3.Factura
		SET factura_importeTotal = (SELECT factura_importeTotal FROM MESSI_MAS3.Publicacion WHERE publicacion_id = @id) + @costoEnvio + @valorItem
		WHERE factura_publicacionId = @id

		UPDATE Publicacion SET publicacion_idEstado = 4  WHERE publicacion_id = @id
		FETCH NEXT FROM c1 INTO @id
	END
	close c1
	deallocate c1
END
GO