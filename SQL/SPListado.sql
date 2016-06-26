CREATE PROCEDURE [MESSI_MAS3].get_top5ConMasFacturas(@anio NVARCHAR(255), @nroTrimestre INT)
AS BEGIN
DECLARE @fechaInicio DATETIME, @fechaFin DATETIME

if (@nroTrimestre = 1)
BEGIN 
		SET @fechaInicio = CONCAT('01/01/', @anio)
		SET @fechaFin = CONCAT('31/03/', @anio)
END
if (@nroTrimestre = 2)
BEGIN 
		SET @fechaInicio = CONCAT('01/04/', @anio)
		SET @fechaFin = CONCAT('30/06/', @anio)
END
if (@nroTrimestre = 3)
BEGIN 
		SET @fechaInicio = CONCAT('01/07/', @anio)
		SET @fechaFin = CONCAT('30/09/', @anio)
END
if (@nroTrimestre = 4)
BEGIN 
		SET @fechaInicio = CONCAT('01/10/', @anio)
		SET @fechaFin = CONCAT('31/12/', @anio)
END


(SELECT TOP 5  SUM(FacturasEnTrimestre.factura_importeTotal) Monto  
	FROM (SELECT * FROM MESSI_MAS3.Factura WHERE CONVERT(DATE, factura_fecha, 5) BETWEEN CONVERT(DATE,'2015/01/01') AND CONVERT(DATE,'2015/03/31')) AS FacturasEnTrimestre, MESSI_MAS3.Usuario 
		WHERE (FacturasEnTrimestre.factura_idVendedor = usuario_id AND EXISTS (SELECT * FROM (SELECT * FROM MESSI_MAS3.Factura WHERE CONVERT(DATE,factura_fecha) BETWEEN CONVERT(DATE,'2015/01/01') AND CONVERT(DATE,'2015/03/31')) AS Factus WHERE factura_idVendedor = usuario_id) )

		) ORDER BY Monto

		/*
		(SELECT TOP 5  SUM(FacturasEnTrimestre.factura_importeTotal) Monto  
	FROM (SELECT * FROM MESSI_MAS3.Factura WHERE CONVERT(DATE, factura_fecha, 5) BETWEEN CONVERT(DATE,'2015/01/01') AND CONVERT(DATE,'2015/03/31')) AS FacturasEnTrimestre, MESSI_MAS3.Usuario
		WHERE ( factura_idVendedor= usuario_id AND  EXISTS (SELECT * FROM (SELECT * FROM MESSI_MAS3.Factura WHERE CONVERT(DATE,factura_fecha) BETWEEN CONVERT(DATE,'2015/01/01') AND CONVERT(DATE,'2015/03/31')) AS Factus WHERE factura_idVendedor = usuario_id) )

		) 
		
		*/
END
GO  