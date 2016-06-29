
CREATE PROCEDURE [MESSI_MAS3].getRubrosString
AS BEGIN
SELECT rubro_descripcionCorta FROM MESSI_MAS3.Rubro

END
GO

CREATE PROCEDURE [MESSI_MAS3].get_visibilidades
AS				
BEGIN
	SELECT visibilidad_id, visibilidad_descripcion
	FROM MESSI_MAS3.Visibilidad
END
GO

CREATE PROCEDURE [MESSI_MAS3].get_top5ConMasFacturas(@anio NVARCHAR(255), @nroTrimestre INT)
AS BEGIN
DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @anioCasteado int
SET @anioCasteado = CONVERT(INT, @anio)

IF @nroTrimestre = 0 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @nroTrimestre = 1
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @nroTrimestre = 2
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @nroTrimestre = 3
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5	cliempresa.cliente_id	AS idUsuario,
				usu.usuario_nombreUsuario		AS nombre,
				count (*)		AS cantidadDeFacturas
FROM				MESSI_MAS3.Factura fac
		LEFT JOIN	MESSI_MAS3.Publicacion pub ON fac.factura_publicacionId = pub.publicacion_id
		LEFT JOIN  (SELECT cliente_id, cliente_apellido FROM MESSI_MAS3.Cliente
					UNION
					SELECT empresa_id, empresa_razonSocial FROM MESSI_MAS3.Empresa) AS cliempresa ON cliempresa.cliente_id = pub.publicacion_idUsuario
		LEFT JOIN	MESSI_MAS3.Usuario usu ON pub.publicacion_idUsuario = usu.usuario_id
WHERE	(MONTH(fac.factura_fecha) = @mes1 OR MONTH(fac.factura_fecha) = @mes2 OR MONTH(fac.factura_fecha) = @mes3)
		AND
		YEAR(fac.factura_fecha) = @anio
GROUP BY cliempresa.cliente_id, usu.usuario_nombreUsuario
ORDER BY cantidadDeFacturas DESC


END
GO 



CREATE PROCEDURE [MESSI_MAS3].get_top5ConMayorMontoFacturado(@anio NVARCHAR(255), @nroTrimestre INT)
AS BEGIN


DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @anioCasteado int
SET @anioCasteado = CONVERT(INT,@anio)

IF @nroTrimestre = 0 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @nroTrimestre = 1
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @nroTrimestre = 2
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @nroTrimestre = 3
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5	cliempresa.cliente_id,			
				users.usuario_nombreUsuario,				
				cliempresa.cliente_nombre,		
				SUM(factura.factura_importeTotal)
FROM				MESSI_MAS3.Factura factura
		LEFT JOIN	MESSI_MAS3.Publicacion pub ON factura_publicacionId = pub.publicacion_id
		LEFT JOIN  (SELECT cliente_id, cliente_nombre FROM MESSI_MAS3.Cliente
					UNION
					SELECT empresa_id, empresa_razonSocial FROM MESSI_MAS3.Empresa) AS cliempresa ON cliempresa.cliente_id = pub.publicacion_idUsuario
		LEFT JOIN	MESSI_MAS3.Usuario users ON pub.publicacion_idUsuario = users.usuario_id
WHERE	
		(MONTH(factura.factura_fecha) = @mes1 OR MONTH(factura.factura_fecha) = @mes2 OR MONTH(factura.factura_fecha) = @mes3)	AND YEAR(factura.factura_fecha) = @anioCasteado
GROUP BY cliempresa.cliente_id, cliempresa.cliente_nombre, users.usuario_nombreUsuario
ORDER BY SUM(factura.factura_importeTotal) DESC



END
GO

CREATE PROCEDURE [MESSI_MAS3].get_top5clientesConMasCompraSegunRubro(@anio NVARCHAR(255), @nroTrimestre INT, @nombreRubro NVARCHAR(255))
AS BEGIN

DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @idRubro INT
SELECT @idRubro = rubro_id FROM MESSI_MAS3.Rubro WHERE @nombreRubro = rubro_descripcionCorta
DECLARE @anioCasteado int

SET @anioCasteado = CONVERT(INT,@anio)

IF @nroTrimestre = 0 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @nroTrimestre = 1
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @nroTrimestre = 2
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @nroTrimestre = 3
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END


SELECT TOP 5 
		compra.compras_personaComprador_id		AS idUsuario,
		cliente.cliente_DNI		AS documento,
		cliente.cliente_nombre			AS nombre,
		cliente.cliente_apellido		AS apellido,
		COUNT(*)			AS cantidadCompras
FROM 			MESSI_MAS3.Compra compra
	LEFT JOIN	MESSI_MAS3.Publicacion publi ON compra.compras_publicacion_id = publi.publicacion_id
	LEFT JOIN	MESSI_MAS3.Cliente cliente on cliente.cliente_id = compra.compras_personaComprador_id
WHERE 
	EXISTS (SELECT * FROM MESSI_MAS3.Rubro_x_Publicacion WHERE @idRubro = idRubro AND publi.publicacion_id = idPublicacion)
	AND
	YEAR(publi.publicacion_fechaFin) = @anio
	AND
	(MONTH(publi.publicacion_fechaFin) = @mes1 OR MONTH(publi.publicacion_fechaFin) = @mes2 OR MONTH(publi.publicacion_fechaFin) = @mes3)
GROUP BY compra.compras_personaComprador_id, cliente.cliente_nombre, cliente.cliente_DNI, cliente.cliente_apellido
ORDER BY cantidadCompras DESC
END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_top5vendedoresConMayorCantidadDeProductosNoVendidos] (@trimestre INT, @anio INT, @visibilidad NVARCHAR(255))
AS
BEGIN

DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @idVisibilidad INT
SELECT @idVisibilidad = visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE @visibilidad = visibilidad_descripcion
IF @trimestre = 0 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @trimestre = 1
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @trimestre = 2
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @trimestre = 3
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5 publicacionQueNoFiguraEnCompras.cliente_id, 
			COUNT(*) AS cantidad, 
			publicacionQueNoFiguraEnCompras.cliente_nombre FROM (SELECT cliempresa.cliente_id, usu.usuario_nombreUsuario, cliempresa.cliente_nombre, publi.publicacion_descripcion, publi.publicacion_fechaFin, publicacion_idVisibilidad 
					FROM MESSI_MAS3.Publicacion publi
					LEFT JOIN (	SELECT cliente_id, cliente_nombre FROM MESSI_MAS3.Cliente
								UNION
								SELECT empresa_id, empresa_razonSocial FROM MESSI_MAS3.Empresa) as cliempresa ON cliempresa.cliente_id = publi.publicacion_idUsuario
					LEFT JOIN  MESSI_MAS3.Usuario usu ON cliempresa.cliente_id = usu.usuario_id
				WHERE	 NOT EXISTS(SELECT * FROM MESSI_MAS3.Compra compra where publi.publicacion_id = compra.compras_publicacion_id) 
						AND 
						publi.publicacion_idEstado = 4
						AND
						(MONTH(publi.publicacion_fechaFin) = @mes1 OR MONTH(publi.publicacion_fechaFin) = @mes2 OR MONTH(publi.publicacion_fechaFin) = @mes3)
						AND
						YEAR(publi.publicacion_fechaFin) = @anio
						AND
						publi.publicacion_idVisibilidad = @idVisibilidad) publicacionQueNoFiguraEnCompras
GROUP BY publicacionQueNoFiguraEnCompras.cliente_id, publicacionQueNoFiguraEnCompras.cliente_nombre
ORDER BY cantidad DESC
END
GO


