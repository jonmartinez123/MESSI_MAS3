

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