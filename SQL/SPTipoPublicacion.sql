CREATE PROCEDURE [MESSI_MAS3].getIdTipoPublicacion @tipo nvarchar(255)
AS
BEGIN
DECLARE @id int
SELECT @id=tipoPublicacion_id FROM tipoPublicacion WHERE tipoPublicacion_nombre = @tipo
RETURN @id
END
GO