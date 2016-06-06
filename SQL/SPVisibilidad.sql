CREATE PROCEDURE [MESSI_MAS3].getVisibilidadades
AS
BEGIN
SELECT * FROM MESSI_MAS3.Visibilidad
END 
GO

CREATE PROCEDURE [MESSI_MAS3].modificarVisibilidad @idVisibilidad int,@visibilidad_codigo int, @visibilidad_des nvarchar(255),@visibilidad_porc numeric(18,2),@visibilidad_precio numeric(18,2)
AS
BEGIN
UPDATE MESSI_MAS3.Visibilidad SET @visibilidad_codigo=visibilidad_codigo, @visibilidad_des = visibilidad_descripcion, @visibilidad_porc=visibilidad_porcentaje,@visibilidad_precio = visibilidad_precio WHERE visibilidad_id=@idVisibilidad
END
GO

CREATE PROCEDURE [MESSI_MAS3].eliminarVisibilidad @idVisibilidad int
AS
BEGIN
	BEGIN TRY
		DELETE FROM [MESSI_MAS3].Visibilidad WHERE visibilidad_id = @idVisibilidad
	END TRY
	BEGIN CATCH
		RETURN -1
	END CATCH
END
GO

CREATE PROCEDURE [MESSI_MAS3].agregarVisibilidad @visibilidad_codigo int,@visibilidad_des nvarchar(255),@visibilidad_porc numeric(18,2),@visibilidad_precio numeric(18,2)
AS
BEGIN
INSERT INTO [MESSI_MAS3].Visibilidad(visibilidad_codigo,visibilidad_descripcion,visibilidad_porcentaje,visibilidad_precio) VALUES (@visibilidad_codigo,@visibilidad_des,@visibilidad_porc,@visibilidad_precio)
END
GO
