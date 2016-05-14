USE[GD1C2016]
GO

CREATE SCHEMA [MESSI_MAS3] AUTHORIZATION [gd]

-- -----------------------------------------------------
-- Table MESSI_MAS3.Funcionalidad
-- -----------------------------------------------------
CREATE TABLE Funcionalidad (
   funcionalidad_id INT PRIMARY KEY NOT NULL IDENTITY,
   funcionalidad_descripcion NVARCHAR(255) NULL,
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Usuario
-- -----------------------------------------------------
CREATE TABLE Usuario (
  usuario_id INT PRIMARY KEY NOT NULL IDENTITY,
  usuario_nombreUsuario NVARCHAR(255) NOT NULL UNIQUE,
  usuario_contraseña NVARCHAR(30) NOT NULL,
  usuario_mail NVARCHAR(50) NOT NULL UNIQUE,
  usuario_deleted INT DEFAULT 0,
  usuario_intentos INT DEFAULT 0, )
 


-- -----------------------------------------------------
-- Table MESSI_MAS3.Rol
-- -----------------------------------------------------
CREATE TABLE Rol (
  rol_id INT PRIMARY KEY NOT NULL IDENTITY,
  rol_nombre NVARCHAR(255) NULL,
  rol_deleted INT DEFAULT 0, 
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Localidad
-- -----------------------------------------------------
CREATE TABLE Localidad (
  localidad_id INT PRIMARY KEY NOT NULL IDENTITY,
  localidad_nombre NVARCHAR(255) NOT NULL,
  localidad_codigoPostal NVARCHAR(50) NOT NULL,
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Domicilio
-- -----------------------------------------------------
CREATE TABLE Domicilio (
  domicilio_idDomicilio INT PRIMARY KEY NOT NULL IDENTITY,
  domicilio_localidad_id INT REFERENCES Localidad(Localidad_id),
  domicilio_calle NVARCHAR(100) NOT NULL,
  domicilio_altura NUMERIC(18,0) NOT NULL,
  domicilio_piso NUMERIC(18,0) NOT NULL,
  domicilio_departamento NVARCHAR(50) NOT NULL,
  domicilio_ciudad VARCHAR(45) DEFAULT 'Buenos aires',)								--Esto esta bien?
 


																							

-- -----------------------------------------------------
-- Table MESSI_MAS3.Persona
-- -----------------------------------------------------

CREATE TABLE Persona (
  persona_nombre NVARCHAR(255) NOT NULL,
  persona_apellido NVARCHAR(255) NOT NULL,
  persona_DNI NUMERIC(18,0) NOT NULL UNIQUE,
  persona_fechaNacimiento DATETIME NOT NULL,
  persona_fechaCreacion DATETIME NOT NULL,
  persona_idDomicilio INT REFERENCES Domicilio(domicilio_idDomicilio),
  persona_id INT PRIMARY KEY REFERENCES Usuario(usuario_id),
  persona_tel NUMERIC(15,0) DEFAULT 0,
  persona_mail NVARCHAR(255) NOT NULL,
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Rubro
-- -----------------------------------------------------
CREATE TABLE Rubro (
  rubro_id INT PRIMARY KEY NOT NULL IDENTITY,
  rubro_descripcionCorta NVARCHAR(255) NOT NULL,
  rubro_descripcionLarga NVARCHAR(255) NULL,
  )


																				 

-- -----------------------------------------------------
-- Table MESSI_MAS3.Empresa
-- -----------------------------------------------------
CREATE TABLE Empresa (
  empresa_razonSocial NVARCHAR(255) NOT NULL,
  empresa_cuit NVARCHAR(50) NOT NULL,
  empresa_id INT PRIMARY KEY REFERENCES Usuario (usuario_id),
  empresa_calificacionPromedio INT NOT NULL,
  empresa_fechaCreacion DATETIME NOT NULL,
  empresa_idDomicilio INT REFERENCES Domicilio (domicilio_idDomicilio),
  empresa_telefono VARCHAR(10) NOT NULL,
  empresa_rubro INT REFERENCES Rubro (rubro_id),)
 
-- -----------------------------------------------------
-- Table MESSI_MAS3.Estado
-- -----------------------------------------------------
CREATE TABLE Estado (
  estado_id INT PRIMARY KEY NOT NULL IDENTITY,
  estado_nombre NVARCHAR(255) NOT NULL,
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Visibilidad
-- -----------------------------------------------------
CREATE TABLE Visibilidad (
  visibilidad_id INT PRIMARY KEY NOT NULL IDENTITY,
  visibilidad_descripcion NVARCHAR(255) NOT NULL,
  visibilidad_precio NUMERIC(18,2) NOT NULL,
  visibilidad_porcentaje NUMERIC(18,2) NOT NULL,
)



-- -----------------------------------------------------
-- Table MESSI_MAS3.Publicacion
-- -----------------------------------------------------
CREATE TABLE Publicacion (
  publicacion_id INT PRIMARY KEY NOT NULL IDENTITY,
  publicacion_idEstado INT REFERENCES Estado (estado_id),
  publicacion_idVisibilidad INT REFERENCES Visibilidad (visibilidad_id),
  publicacion_idUsuario INT REFERENCES Usuario (usuario_id),
  publicacion_fechaInicio DATETIME NOT NULL,
  publicacion_fechaFin DATETIME NOT NULL,
  publicacion_descripcion VARCHAR(255) NULL,
  publicacion_admitePreguntas INT DEFAULT 0 NOT NULL,
  publicacion_tipo NVARCHAR(255) NOT NULL,
  publicacion_minimoSubasta NUMERIC(10,2) DEFAULT 0.00,			--DUDA MIRAR KOIFFO EL TIPO DE LA VARIABLE
  publicacion_precio NUMERIC(18,2),
  publicacion_idRubro INT NOT NULL,
  publiacion_tieneEnvio INT NOT NULL,
  
   )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Rubro_x_Publicacion
-- -----------------------------------------------------
CREATE TABLE Rubro_x_Publicacion (
  idPublicacion INT REFERENCES Publicacion (publicacion_id),
  idRubro INT REFERENCES Rubro (rubro_id) ,)
  
-- -----------------------------------------------------
-- Table MESSI_MAS3.RolUsuario
-- -----------------------------------------------------
CREATE TABLE Rol_Usuario (
  Usuario_id INT REFERENCES Usuario (usuario_id),
  Rol_id INT REFERENCES Rol (rol_id),
)

-- -----------------------------------------------------
-- Table MESSI_MAS3.FuncionalidadRol
-- -----------------------------------------------------
CREATE TABLE Funcionalidad_Rol (
  Rol_id INT REFERENCES Rol(rol_id),
  Funcionalidad_id INT REFERENCES Funcionalidad (funcionalidad_id),
  )

-- -----------------------------------------------------
-- Table MESSI_MAS3.Compra
-- -----------------------------------------------------
CREATE TABLE Compra (
  compra_id INT PRIMARY KEY NOT NULL IDENTITY,
  compras_publicacion_id INT REFERENCES Publicacion (publicacion_id),
  compras_fecha DATETIME NOT NULL,
  compras_personaComprador_id INT REFERENCES Persona(persona_id),
  compras_cantidad NUMERIC(18,0) NOT NULL, )
 
-- -----------------------------------------------------
-- Table MESSI_MAS3.Oferta
-- -----------------------------------------------------
CREATE TABLE Oferta (
  oferta_id INT PRIMARY KEY NOT NULL IDENTITY,
  oferta_valor NUMERIC(18,2) NOT NULL,
  oferta_persona_id INT REFERENCES Persona(persona_id),						
  oferta_idPublicacion INT REFERENCES Publicacion (publicacion_id),
  oferta_fecha DATETIME NOT NULL,
  oferta_ganador INT DEFAULT 0,
  )


-- -----------------------------------------------------
-- Table MESSI_MAS3.Calificacion										
-- -----------------------------------------------------
CREATE TABLE Calificacion (
  calificacion_id INT PRIMARY KEY NOT NULL IDENTITY,
  calificacion_idPersonaCalificador INT REFERENCES Persona(persona_id), 
  calificacion_compraId INT REFERENCES Compra(compra_id),
  calificacion_fecha DATETIME NULL,
  calificacion_cantidadEstrellas NUMERIC(18,0) NULL,
  calificacion_detalle NVARCHAR(255) NULL,
  calificacion_pendiente INT DEFAULT 0 NOT NULL,					--ACA!!!
  calificacion_idusuarioCalificado INT REFERENCES Usuario(usuario_id),
)
 

-- -----------------------------------------------------
-- Table MESSI_MAS3.FormaDePago												
-- -----------------------------------------------------

CREATE TABLE FormaDePago (
  formaDePago_id INT PRIMARY KEY NOT NULL IDENTITY,
  formadePago_nombre NVARCHAR(255) NULL,
  )

-- -----------------------------------------------------
-- Table MESSI_MAS3.Factura
-- -----------------------------------------------------

CREATE TABLE Factura (
  factura_id INT PRIMARY KEY NOT NULL IDENTITY,
  factura_fecha DATETIME NOT NULL,
  factura_importeTotal NUMERIC(18,2) NOT NULL,
  factura_idVendedor INT REFERENCES Usuario (usuario_id),
  factura_numero NUMERIC(18,0) NOT NULL,
  factura_formaDePago INT REFERENCES FormaDePago (formaDePago_id),
  
)

-- -----------------------------------------------------
-- Table MESSI_MAS3.Pregunta
-- -----------------------------------------------------
CREATE TABLE Pregunta (
  pregunta_id INT PRIMARY KEY NOT NULL IDENTITY,
  pregunta NVARCHAR(255) NOT NULL,
  pregunta_idPublicacion INT REFERENCES Publicacion (publicacion_id),
  pregunta_idPersonaPreguntador INT REFERENCES Persona (persona_id), 
  pregunta_fecha DATETIME NOT NULL, )
 



-- -----------------------------------------------------
-- Table MESSI_MAS3.Respuesta
-- -----------------------------------------------------
CREATE TABLE Respuesta (
  respuesta_id INT PRIMARY KEY NOT NULL IDENTITY,
  respuesta_idPregunta INT REFERENCES Pregunta (pregunta_id),
  respuesta_fecha DATETIME NULL,
  respuesta_textorespuesta NVARCHAR(255) NULL,
  respuesta_idUsQueResponde INT REFERENCES Usuario (usuario_id),
  
  )



-- -----------------------------------------------------
-- Table MESSI_MAS3.Factura_detalle
-- -----------------------------------------------------
CREATE TABLE Factura_detalle (
  FacturaDetalle_valorItem NUMERIC(18,2) NOT NULL,
  facturaDetalle_numero NUMERIC(18,0) NOT NULL,
  facturaDetalle_item NVARCHAR(255) NOT NULL,
  facturaDetalle_id INT PRIMARY KEY REFERENCES Factura (factura_id),
  facturaDetall_cantidadItems NUMERIC(18,0) NOT NULL,
  
 )



