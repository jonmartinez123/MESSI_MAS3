
/*--------------------------Migro publicaciones de clientes---------------------------*/
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Publ_Cli_Dni AND cliente_apellido = Publ_Cli_Apeliido AND cliente_nombre = Publ_Cli_Nombre ),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		2,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Cli_Dni IS NOT NULL ) 	AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Compra Inmediata')
COMMIT


BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Publ_Cli_Dni AND cliente_apellido = Publ_Cli_Apeliido AND cliente_nombre = Publ_Cli_Nombre ),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		1,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Cli_Dni IS NOT NULL ) 	AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Subasta')
COMMIT



/*--------------------------Migro publicaciones de Empresas---------------------------*/
--Publicaciones de Empresas
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		2,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Empresa_Cuit IS NOT NULL ) AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Compra Inmediata')	
COMMIT


BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Publicacion(publicacion_idUsuario,publicacion_codigo, publicacion_descripcion, publicacion_tipoPublicacionId,
									publicacion_fechaInicio,publicacion_fechaFin, publicacion_idEstado, publicacion_idRubro,
									 publicacion_idVisibilidad, publicacion_precio, publicacion_stock,publicacion_admitePreguntas)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit),
		Publicacion_Cod ,	
		Publicacion_Descripcion, 
		1,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		4,
		(SELECT rubro_id FROM MESSI_MAS3.Rubro WHERE rubro_descripcionCorta = Publicacion_Rubro_Descripcion),
		(SELECT visibilidad_id FROM MESSI_MAS3.Visibilidad WHERE visibilidad_codigo = Publicacion_Visibilidad_Cod),
		Publicacion_Precio,
		Publicacion_Stock,
		0
FROM gd_esquema.Maestra WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) AND (Publ_Empresa_Cuit IS NOT NULL ) AND Publicacion_Stock IS NOT NULL AND Publicacion_Tipo = 'Subasta')	
COMMIT


/*--------------------------Migro rubros_x_publicaciones---------------------------*/
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Rubro_x_Publicacion(idPublicacion,idRubro)
(SELECT publicacion_id, 
		publicacion_idRubro

FROM MESSI_MAS3.Publicacion)
COMMIT

/*--------------------------Migro Compras---------------------------*/

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Compra(compras_personaComprador_id, compras_cantidad, compras_fecha , compras_publicacion_id)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Cli_Dni AND Compra_Fecha IS NOT NULL AND Oferta_Fecha IS NULL ),
		Compra_Cantidad ,
		Compra_Fecha, 
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE Publicacion_Cod = publicacion_codigo)


FROM gd_esquema.Maestra WHERE Compra_Cantidad IS NOT NULL AND Compra_Fecha IS NOT NULL)

COMMIT

/*--------------------------Migro Calificaciones de clientes---------------------------*/
BEGIN TRANSACTION

INSERT INTO MESSI_MAS3.Calificacion(calificacion_compraId, calificacion_codigo, calificacion_detalle, calificacion_idPersonaCalificador,
									calificacion_idusuarioCalificado,calificacion_fecha, calificacion_cantidadEstrellas, 
									 calificacion_pendiente)
(SELECT DISTINCT (SELECT TOP 1 compra_id FROM MESSI_MAS3.Compra WHERE compras_fecha = Compra_Fecha AND compras_cantidad = Compra_Cantidad AND Compra_Fecha = compras_fecha AND MESSI_MAS3.coincidenCodPubliCompra(Publicacion_Cod, compra_id) = 1),
		Calificacion_Codigo ,	
		Calificacion_Descripcion, 
		(SELECT TOP 1cliente_id FROM MESSI_MAS3.cliente WHERE Cli_Dni = cliente_DNI AND Cli_Apeliido = cliente_apellido AND Cli_Nombre =cliente_nombre),
		(SELECT TOP 1 cliente_id FROM MESSI_MAS3.cliente WHERE Publ_Cli_Dni = cliente_DNI AND Publ_Cli_Apeliido = cliente_apellido AND Publ_Cli_Nombre =cliente_nombre),
		Publicacion_Fecha_Venc,
		MESSI_MAS3.adiestrarCalif(Calificacion_Cant_Estrellas),
		0
FROM gd_esquema.Maestra WHERE Publ_Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Oferta_Monto IS NULL )
COMMIT

/*--------------------------Migro Calificaciones de empresas---------------------------*/
BEGIN TRANSACTION

INSERT INTO MESSI_MAS3.Calificacion(calificacion_compraId, calificacion_codigo, calificacion_detalle, calificacion_idPersonaCalificador,
									calificacion_idusuarioCalificado,calificacion_fecha, calificacion_cantidadEstrellas, 
									 calificacion_pendiente)
(SELECT DISTINCT (SELECT TOP 1 compra_id FROM MESSI_MAS3.Compra WHERE compras_fecha = Compra_Fecha AND compras_cantidad = Compra_Cantidad AND Compra_Fecha = compras_fecha AND MESSI_MAS3.coincidenCodPubliCompra(Publicacion_Cod, compra_id) = 1),
		Calificacion_Codigo ,	
		Calificacion_Descripcion, 
		(SELECT cliente_id FROM MESSI_MAS3.cliente WHERE Cli_Dni = cliente_DNI AND Cli_Apeliido = cliente_apellido AND Cli_Nombre =cliente_nombre),
		(SELECT TOP 1 empresa_id FROM MESSI_MAS3.Empresa WHERE Publ_Empresa_Cuit = empresa_cuit),
		Publicacion_Fecha_Venc,
		MESSI_MAS3.adiestrarCalif(Calificacion_Cant_Estrellas),
		0
FROM gd_esquema.Maestra WHERE Publ_Empresa_Cuit IS NOT NULL AND Calificacion_Cant_Estrellas IS NOT NULL AND Cli_Dni IS NOT NULL AND Publicacion_Cod IS NOT NULL AND Oferta_Monto IS NULL )
COMMIT



/*--------------------------Migro Ofertas de clientes---------------------------*/		--NO ES PERFORMANTE
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Oferta(oferta_persona_id, oferta_idPublicacion,oferta_fecha , oferta_valor,oferta_ganador)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Cli_Dni AND cliente_apellido = Cli_Apeliido AND cliente_nombre = Cli_Nombre ),
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE Publicacion_Cod = publicacion_codigo ) ,	--TARDA 3 MIN CON ESTE CODIGO, VER QUE SE PUEDE HACER, SI INSERTAMOS EL CODIGO DE PUBLI ALCANZA Y LO DEJAMOS SIN FK
		Oferta_Fecha, 
		Oferta_Monto,
		0
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND  Oferta_Fecha IS NOT NULL AND Cli_Dni IS NOT NULL AND Calificacion_Cant_Estrellas IS NULL AND (Publ_Cli_Dni IS NOT NULL OR Publ_Empresa_Cuit IS NOT NULL))
COMMIT




/*--------------------------Migro Ofertas ganadoras a Facturas---------------------------*/
--ANTES DE EJECUTAR ESTE, HAY QUE EJECUTAR EL SP buscarGanadoresOfertas

EXEC MESSI_MAS3.buscarGanadoresOfertas

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero, factura_publicacionId)
(SELECT DISTINCT (SELECT oferta_persona_id FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Publicacion_Fecha_Venc, 
		Oferta_Monto,
		Factura_Nro,
		(SELECT oferta_idPublicacion FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod)
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL)
COMMIT

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero, factura_publicacionId)
(SELECT DISTINCT (SELECT oferta_persona_id FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Publicacion_Fecha_Venc, 
		Oferta_Monto,
		Factura_Nro,
		(SELECT oferta_idPublicacion FROM MESSI_MAS3.Oferta 
			WHERE oferta_ganador = 1  AND oferta_fecha = Oferta_Fecha AND (SELECT publicacion_codigo FROM MESSI_MAS3.Publicacion WHERE publicacion_id = oferta_idPublicacion) = Publicacion_Cod)
FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Subasta' AND Oferta_Monto IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL)
COMMIT


/*--------------------------Migro Facturas de clientes---------------------------*/

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero,factura_publicacionId)
(SELECT DISTINCT (SELECT cliente_id FROM MESSI_MAS3.cliente 
			WHERE cliente_DNI = Publ_Cli_Dni AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Factura_Fecha, 
		Factura_Total,
		Factura_Nro,
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE publicacion_codigo = Publicacion_Cod)


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Cli_Dni IS NOT NULL)
COMMIT

/*--------------------------Migro Facturas de Empresas---------------------------*/

BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura(factura_idVendedor, factura_formaDePago, factura_fecha , factura_importeTotal,factura_numero, factura_publicacionId)
(SELECT DISTINCT (SELECT empresa_id FROM MESSI_MAS3.Empresa 
			WHERE empresa_cuit = Publ_Empresa_Cuit AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		(SELECT formaDePago_id FROM MESSI_MAS3.FormaDePago WHERE formadePago_nombre = Forma_Pago_Desc) ,
		Factura_Fecha, 
		Factura_Total,
		Factura_Nro,
		(SELECT TOP 1 publicacion_id FROM MESSI_MAS3.Publicacion WHERE publicacion_codigo = Publicacion_Cod)


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL AND Publ_Empresa_Cuit IS NOT NULL)

COMMIT
/*--------------------------Migro el detalle de Facturas---------------------------*/

--Migro a la factura detalle todo
BEGIN TRANSACTION
INSERT INTO MESSI_MAS3.Factura_detalle(facturaDetalle_id, facturaDetall_cantidadItems, facturaDetalle_item , facturaDetalle_numero,FacturaDetalle_valorItem)
(SELECT DISTINCT (SELECT TOP 1 factura_id FROM MESSI_MAS3.Factura 
			WHERE factura_numero = Factura_Nro AND factura_fecha = Factura_Fecha AND factura_importeTotal = Factura_Total AND Factura_Fecha IS NOT NULL AND Oferta_Fecha IS NULL AND Item_Factura_Cantidad IS NOT NULL ),
		Item_Factura_Cantidad ,
		NULL, 
		Factura_Nro,
		Item_Factura_Monto


FROM gd_esquema.Maestra WHERE Publicacion_Tipo = 'Compra Inmediata' AND Oferta_Monto IS NULL AND Item_Factura_Cantidad IS NOT NULL AND Factura_Fecha IS NOT NULL AND  Forma_Pago_Desc IS NOT NULL)
COMMIT


EXEC [MESSI_MAS3].[insertarCalificacionPromedio]

