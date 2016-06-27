CREATE PROCEDURE [MESSI_MAS3].getFacturaDetalles (@idFactura int)
as
begin
	select facturaDetalle_item,FacturaDetalle_valorItem,facturaDetall_cantidadItems
	from Factura,Factura_detalle
	where factura_id = @IdFactura and facturaDetalle_id=@idFactura 
end
go
CREATE PROCEDURE [MESSI_MAS3].getFacturaDetallesCabecera (@idFactura int)
as
begin
	select factura_fecha,factura_formaDePago,factura_numero,factura_idVendedor,factura_importeTotal from Factura where factura_id = @idFactura
end
go
CREATE PROCEDURE [MESSI_MAS3].esCliente (@idUsuario int)
as
begin
	if exists ( select * from Cliente where @idUsuario = cliente_id)
		begin
			return 1
		end
		else
		begin
			return -1
		end
end
go

CREATE PROCEDURE [MESSI_MAS3].getFormasDePago (@idForma int)
as
begin
	select formadePago_nombre from FormaDePago where @idForma=formaDePago_id
end
go
--CREATE PROCEDURE [MESSI_MAS3].getFacturaDetallesCabecera (@idFactura int)
--as
--begin
--declare @clienteId int
--if exists (select @clienteId=cliente_id from Factura,Cliente where @idFactura = factura_id and factura_idVendedor = cliente_id)
--	begin
--		select factura_fecha,factura_numero,factura_importeTotal,formaDePago_nombre,cliente_DNI,
--		domicilio_altura,domicilio_calle,domicilio_ciudad,
--		domicilio_codigoPostal,domicilio_departamento,domicilio_piso,domicilio_ciudad,
--		localidad_nombre,facturaDetalle_item,FacturaDetalle_valorItem,facturaDetall_cantidadItems
--		from MESSI_MAS3.Factura,MESSI_MAS3.Factura_detalle,MESSI_MAS3.Cliente
--		,MESSI_MAS3.FormaDePago,MESSI_MAS3.Domicilio,MESSI_MAS3.Localidad

--		where factura_id = @idFactura and facturaDetalle_id=@idFactura and 
--		factura_idVendedor=@clienteId
--		and  factura_formaDePago=formaDePago_id
--		and domicilio_localidad_id=localidad_id 
--		and cliente_idDomicilio=domicilio_idDomicilio
--	end
--else
--	begin
--	select factura_fecha,factura_numero,factura_importeTotal,formaDePago_nombre,empresa_cuit,
--	domicilio_altura,domicilio_calle,domicilio_ciudad,
--	domicilio_codigoPostal,domicilio_departamento,domicilio_piso,domicilio_ciudad,
--	localidad_nombre,facturaDetalle_item,FacturaDetalle_valorItem,facturaDetall_cantidadItems
--	from MESSI_MAS3.Factura,MESSI_MAS3.Factura_detalle,MESSI_MAS3.Cliente,MESSI_MAS3.Empresa,MESSI_MAS3.FormaDePago,MESSI_MAS3.Domicilio,MESSI_MAS3.Localidad
--	where factura_id = @idFactura and facturaDetalle_id=@idFactura and 
--	factura_idVendedor = empresa_id 
--	and  factura_formaDePago=formaDePago_id
--	and domicilio_localidad_id=localidad_id 
--	and empresa_idDomicilio = domicilio_idDomicilio
--	end
--end
--go