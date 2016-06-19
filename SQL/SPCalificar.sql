

/*------------------------------lo uso cada vez que se califica------------------------*/

CREATE PROCEDURE [MESSI_MAS3].[updatearPromedioAnteNuevaCalificacion](@idUsuarioCalificado INT)
AS BEGIN
DECLARE @promedio INT
SELECT @promedio = FLOOR(AVG(calificacion_cantidadEstrellas)) FROM MESSI_MAS3.Calificacion WHERE calificacion_idusuarioCalificado = @idUsuarioCalificado
   GROUP BY calificacion_idusuarioCalificado

IF (MESSI_MAS3.esEmpresa(@idUsuarioCalificado) = 0) --significa que no es empresa
	BEGIN
		UPDATE MESSI_MAS3.Cliente SET cliente_calificacionPromedio = @promedio WHERE @idUsuarioCalificado = cliente_id
	END

ELSE
	BEGIN
		UPDATE MESSI_MAS3.Empresa SET empresa_calificacionPromedio = @promedio WHERE @idUsuarioCalificado = empresa_id
	END


END
GO


--get_calificacionesPendientesDe
CREATE PROCEDURE [MESSI_MAS3].[get_calificacionesPendientesDeID](@idUsuario NVARCHAR(255))
AS BEGIN
DECLARE @idCasteado int
SET @idCasteado = CAST(@idUsuario AS INT)
SELECT DISTINCT calificacion_id, calificacion_compraId, compras_publicacion_id, tipoPublicacion_nombre, publicacion_fechaFin, publicacion_descripcion  FROM MESSI_MAS3.Calificacion, MESSI_MAS3.Compra, MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 

WHERE calificacion_pendiente = 1 AND (compra_id = calificacion_compraId AND calificacion_compraId IS NOT NULL AND calificacion_idPersonaCalificador = @idCasteado) AND (publicacion_id = compras_publicacion_id AND tipoPublicacion_id = publicacion_tipoPublicacionId) 

END
GO

--get_ultimas5CalificacionesHechasDe

CREATE PROCEDURE [MESSI_MAS3].[get_ultimas5CalificacionesHechasDe](@idUsuario NVARCHAR(255))
AS BEGIN
DECLARE @idCasteado int
SET @idCasteado = CAST(@idUsuario AS INT)
SELECT DISTINCT TOP 5 calificacion_id, tipoPublicacion_nombre, calificacion_cantidadEstrellas, calificacion_detalle  FROM MESSI_MAS3.Calificacion, MESSI_MAS3.Compra, MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion 

WHERE calificacion_pendiente = 0 AND compra_id = calificacion_compraId AND calificacion_idPersonaCalificador = @idCasteado AND (publicacion_id = compras_publicacion_id AND tipoPublicacion_id = publicacion_tipoPublicacionId)

END
GO



CREATE PROCEDURE [MESSI_MAS3].[get_comprasXEstrellasSegunId](@idUsuario NVARCHAR(255))
AS BEGIN
DECLARE @idCasteado int
SET @idCasteado = CAST(@idUsuario AS INT)

SELECT (SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 1 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 2 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 3 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 4 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario),
		(SELECT COUNT(*) FROM MESSI_MAS3.Calificacion WHERE calificacion_cantidadEstrellas = 5 AND calificacion_pendiente = 0 AND calificacion_idPersonaCalificador = @idUsuario)

END
GO

CREATE PROCEDURE [MESSI_MAS3].[actualizar_calificacionDe](@idCalificacion INT, @mensaje NVARCHAR(255), @cantidadEstrellas INT)
AS BEGIN

UPDATE MESSI_MAS3.Calificacion SET calificacion_pendiente = 0, calificacion_cantidadEstrellas = @cantidadEstrellas, calificacion_detalle = @mensaje WHERE calificacion_id = @idCalificacion

END
GO

CREATE PROCEDURE [MESSI_MAS3].[tieneMasde3calificacionesPendientesSegun](@idUsuario int)
AS BEGIN
DECLARE @cant int

SELECT @cant = COUNT(*) FROM MESSI_MAS3.Calificacion WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 1)

IF (@cant > 2)
BEGIN
	RETURN 1
END
ELSE
BEGIN
	RETURN 0
END


END 
GO

