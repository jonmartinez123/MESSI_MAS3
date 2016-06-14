CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechas](@idUsuario INT, @dateDesde DATE, @dateHasta DATE)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) AND formaDePago_id = factura_formaDePago)

END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreImporte](@idUsuario INT, @importeDesde INT , @importeHasta INT)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND formaDePago_id = factura_formaDePago)

END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConDetalle](@idUsuario INT, @descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura,MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario 
	AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 
	AND formaDePago_id = factura_formaDePago)

END 
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechasEImporte](@idUsuario INT, @dateDesde DATE, @dateHasta DATE,@importeDesde INT , @importeHasta INT)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde 
	AND @importeHasta) AND formaDePago_id = factura_formaDePago)


END
GO



CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechasYContieneDetalle](@idUsuario INT, @dateDesde DATE, @dateHasta DATE,@descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura,MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) 
	AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 
	AND formaDePago_id = factura_formaDePago)


END
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreImporteYDetalle](@idUsuario INT, @importeDesde INT , @importeHasta INT,@descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND formaDePago_id = factura_formaDePago)
	 AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO


CREATE PROCEDURE [MESSI_MAS3].[get_facturasConTodoLosFiltros](@idUsuario INT,@dateDesde DATE, @dateHasta DATE, @importeDesde INT , @importeHasta INT,@descripcion NVARCHAR(255))
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)  AND formaDePago_id = factura_formaDePago)
	 AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO

CREATE FUNCTION [MESSI_MAS3].[cuitDeEmpresa](@dniOCuit NVARCHAR(255))
RETURNS INTEGER
AS BEGIN
DECLARE @cuitloco NVARCHAR(255), @esEmpresa INT, @idPersona INT
SET @esEmpresa = 0
SET  @cuitloco = @dniOCuit

SELECT @esEmpresa = empresa_id FROM MESSI_MAS3.Empresa WHERE @cuitloco = empresa_cuit

RETURN @esEmpresa

END
GO

CREATE FUNCTION [MESSI_MAS3].[traerIdUsuario](@dniOCuit NVARCHAR(255))
RETURNS INTEGER
AS BEGIN
DECLARE @id INT
DECLARE @dniNumeric NUMERIC(18,0)

SET @id = MESSI_MAS3.cuitDeEmpresa(@dniOCuit)
if @id = 0
	BEGIN
		SET @dniNumeric = CONVERT(NUMERIC(18,0), @dniOCuit)
		SELECT @id = cliente_id FROM MESSI_MAS3.Cliente WHERE @dniNumeric = cliente_DNI
	END

RETURN @id
END
GO

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConTodoLosFiltrosInclusoDNIOCUIT](@idUsuario INT,@dateDesde DATE, @dateHasta DATE, @importeDesde INT , @importeHasta INT,@descripcion NVARCHAR(255), @dniOCuit NVARCHAR(255))
AS BEGIN

DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago, MESSI_MAS3.Cliente, MESSI_MAS3.Empresa 
	WHERE ( factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)  AND formaDePago_id = factura_formaDePago)
	 AND ( Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO


--get_facturasHacia

CREATE PROCEDURE [MESSI_MAS3].[get_facturasHacia](@idUsuario INT,@cuitODni NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@cuitODni)

SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND formaDePago_id = factura_formaDePago)

END 
GO

--get_facturasEntreFechasYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechasYDirigido](@idUsuario INT, @dateDesde DATE, @dateHasta DATE,@cuitODni NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@cuitODni)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)
	AND formaDePago_id = factura_formaDePago)


END
GO

--get_facturasEntreImporteYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreImporteYDirigido](@idUsuario INT, @importeDesde INT , @importeHasta INT,@dniOCuit NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND formaDePago_id = factura_formaDePago)
	  

END 
GO

--get_facturasEntreDetalleYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreDetalleYDirigido](@idUsuario INT,@dniOCuit NVARCHAR(255), @descripcion NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago
	WHERE ( factura_idVendedor = @idUser AND formaDePago_id = factura_formaDePago
	 AND  Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion) 

END 
GO

--get_facturasConFechaImporteYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConFechaImporteYDirigido](@idUsuario INT,@dateDesde DATE, @dateHasta DATE, @importeDesde INT , @importeHasta INT,@dniOCuit NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)  AND formaDePago_id = factura_formaDePago)
	 
END 
GO

--get_facturasConFechaDetalleyDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConFechaDetalleyDirigido](@idUsuario INT,@dateDesde DATE, @dateHasta DATE,@dniOCuit NVARCHAR(255), @descripcion NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago
	WHERE ( factura_idVendedor = @idUser AND formaDePago_id = factura_formaDePago
	 AND  Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta)) 

END 
GO

--get_facturasConDetalleImporteYDirigido

CREATE PROCEDURE [MESSI_MAS3].[get_facturasConDetalleImporteYDirigido](@idUsuario INT,@descripcion NVARCHAR(255), @importeDesde INT , @importeHasta INT,@dniOCuit NVARCHAR(255))
AS BEGIN
DECLARE @idUser INT
SET @idUser = MESSI_MAS3.traerIdUsuario(@dniOCuit)
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.Factura_detalle, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUser AND (CONVERT(INT,factura_importeTotal) BETWEEN @importeDesde AND @importeHasta) 
	AND  (Factura_detalle.facturaDetalle_id = factura_id AND Factura_detalle.facturaDetalle_item LIKE @descripcion)  
	AND formaDePago_id = factura_formaDePago)
	 
END 
GO