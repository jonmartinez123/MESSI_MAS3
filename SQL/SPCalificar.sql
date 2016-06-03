

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
CREATE PROCEDURE [MESSI_MAS3].[get_calificacionesPendientesDe](@idUsuario INT)
AS BEGIN
SELECT calificacion_compraId, compras_publicacion_id, tipoPublicacion_nombre, publicacion_fechaFin, publicacion_descripcion
	 FROM MESSI_MAS3.Calificacion, MESSI_MAS3.Compra, MESSI_MAS3.Publicacion, MESSI_MAS3.tipoPublicacion
	WHERE (calificacion_idPersonaCalificador = @idUsuario AND calificacion_pendiente = 1 AND compras_publicacion_id = publicacion_id AND publicacion_tipoPublicacionId = tipoPublicacion_nombre)

END
GO