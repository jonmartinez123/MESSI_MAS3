CREATE PROCEDURE [MESSI_MAS3].get_top5ConMasFacturas(@anio NVARCHAR(255), @nroTrimestre INT)
AS BEGIN
DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @anioCasteado int
SET @anioCasteado = CONVERT(INT, @anio)

IF @nroTrimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @nroTrimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @nroTrimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @nroTrimestre = 4
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5	cliempresa.cliente_id	AS idUsuario,
				usu.usuario_nombreUsuario		AS usuario,
				cliempresa.cliente_apellido	AS nombre,
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
GROUP BY cliempresa.cliente_id, cliempresa.cliente_apellido, usu.usuario_nombreUsuario
ORDER BY cantidadDeFacturas DESC


END
GO  



CREATE PROCEDURE get_top5ConMayorMontoFacturado(@anio NVARCHAR(255), @nroTrimestre INT)
AS BEGIN


DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @anioCasteado int
SET @anioCasteado = CONVERT(INT,@anio)

IF @nroTrimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @nroTrimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @nroTrimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @nroTrimestre = 4
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5	cliempresa.cliente_id,			
				users.usuario_nombreUsuario,				
				cliempresa.cliente_apellido,		
				SUM(factura.factura_importeTotal)	AS montoTotalFacturado
FROM				MESSI_MAS3.Factura factura
		LEFT JOIN	MESSI_MAS3.Publicacion pub ON factura_publicacionId = pub.publicacion_id
		LEFT JOIN  (SELECT cliente_id, cliente_apellido FROM MESSI_MAS3.Cliente
					UNION
					SELECT empresa_id, empresa_razonSocial FROM MESSI_MAS3.Empresa) AS cliempresa ON cliempresa.cliente_id = pub.publicacion_idUsuario
		LEFT JOIN	MESSI_MAS3.Usuario users ON pub.publicacion_idUsuario = users.usuario_id
WHERE	
		(MONTH(factura.factura_fecha) = @mes1 OR MONTH(factura.factura_fecha) = @mes2 OR MONTH(factura.factura_fecha) = @mes3)	AND YEAR(factura.factura_fecha) = @anioCasteado
GROUP BY cliempresa.cliente_id, cliempresa.cliente_apellido, users.usuario_nombreUsuario
ORDER BY montoTotalFacturado DESC



END
GO

CREATE PROCEDURE get_top5clientesConMasCompraSegunRubro(@anio NVARCHAR(255), @nroTrimestre INT, @nombreRubro NVARCHAR(255))
AS BEGIN

DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT
DECLARE @idRubro INT
SELECT @idRubro = rubro_id FROM MESSI_MAS3.Rubro WHERE @nombreRubro = rubro_descripcionCorta
DECLARE @anioCasteado int

SET @anioCasteado = CONVERT(INT,@anio)

IF @nroTrimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @nroTrimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @nroTrimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @nroTrimestre = 4
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