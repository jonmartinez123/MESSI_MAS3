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

/*CREATE PROCEDURE [MESSI_MAS3].[get_facturasEntreFechas](@idUsuario INT, @dateDesde DATE, @dateHasta DATE)
AS BEGIN
SELECT factura_id, factura_fecha, factura_publicacionId, factura_importeTotal, formadePago_nombre FROM MESSI_MAS3.Factura, MESSI_MAS3.FormaDePago 
	WHERE (factura_idVendedor = @idUsuario AND (CONVERT(DATE,factura_fecha) BETWEEN @dateDesde AND @dateHasta) AND formaDePago_id = factura_formaDePago)

END 
GO*/