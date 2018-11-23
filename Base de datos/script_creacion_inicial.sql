IF OBJECT_ID('EQUISDE.premio_x_cliente') IS NOT NULL
DROP TABLE EQUISDE.premio_x_cliente
IF OBJECT_ID('EQUISDE.premio') IS NOT NULL
DROP TABLE EQUISDE.premio 
IF OBJECT_ID('EQUISDE.item') IS NOT NULL
DROP TABLE EQUISDE.item 
IF OBJECT_ID('EQUISDE.factura') IS NOT NULL
DROP TABLE EQUISDE.factura 
IF OBJECT_ID('EQUISDE.compra') IS NOT NULL
DROP TABLE EQUISDE.compra 
IF OBJECT_ID('EQUISDE.ubicacion') IS NOT NULL
DROP TABLE EQUISDE.ubicacion 
IF OBJECT_ID('EQUISDE.tipo') IS NOT NULL
DROP TABLE EQUISDE.tipo 
IF OBJECT_ID('EQUISDE.grado') IS NOT NULL
DROP TABLE EQUISDE.grado 
IF OBJECT_ID('EQUISDE.estado') IS NOT NULL
DROP TABLE EQUISDE.estado
IF OBJECT_ID('EQUISDE.publicacion') IS NOT NULL
DROP TABLE EQUISDE.publicacion
IF OBJECT_ID('EQUISDE.rubro') IS NOT NULL
DROP TABLE EQUISDE.rubro
IF OBJECT_ID('EQUISDE.rol_x_funcionalidad') IS NOT NULL
DROP TABLE EQUISDE.rol_x_funcionalidad
IF OBJECT_ID('EQUISDE.funcionalidad') IS NOT NULL
DROP TABLE EQUISDE.funcionalidad 
IF OBJECT_ID('EQUISDE.rol_x_usuario') IS NOT NULL
DROP TABLE EQUISDE.rol_x_usuario 
IF OBJECT_ID('EQUISDE.rol') IS NOT NULL
DROP TABLE EQUISDE.rol  
IF OBJECT_ID('EQUISDE.cliente') IS NOT NULL
DROP TABLE EQUISDE.cliente 
IF OBJECT_ID('EQUISDE.empresa') IS NOT NULL
DROP TABLE EQUISDE.empresa 
IF OBJECT_ID('EQUISDE.direccion') IS NOT NULL
DROP TABLE EQUISDE.direccion
IF OBJECT_ID('EQUISDE.usuario') IS NOT NULL
DROP TABLE EQUISDE.usuario
GO
IF SCHEMA_ID('EQUISDE') IS NOT NULL
DROP SCHEMA EQUISDE

GO
CREATE SCHEMA EQUISDE
GO
CREATE TABLE EQUISDE.usuario(
	username varchar(50) PRIMARY KEY,
	password varchar(64)
);

CREATE TABLE EQUISDE.direccion(
	id_direccion bigint PRIMARY KEY IDENTITY,
	calle nvarchar(50),
	nro_calle numeric(18,0),
	piso numeric(18,0),
	depto nvarchar(50),
	cod_postal nvarchar(50),
	localidad nvarchar(50)
)

CREATE TABLE EQUISDE.empresa(
	username varchar(50) PRIMARY KEY REFERENCES EQUISDE.usuario,
	id_direccion bigint references EQUISDE.direccion,
	razon_social nvarchar(255),
	cuit nvarchar(255),
	fechar_creacion datetime,
	mail nvarchar(50),
	habilitado bit
)

CREATE TABLE EQUISDE.cliente(
	username varchar(50) PRIMARY KEY REFERENCES EQUISDE.usuario,
	nombre nvarchar(255),
	apellido nvarchar(255),
	fecha_nacimiento datetime,
	mail nvarchar(255),
	dni numeric(18,0),
	id_direccion bigint REFERENCES EQUISDE.direccion,
	telefono nvarchar(50),
	fecha_creacion datetime,
	habilitado bit,
	puntos bigint,
	cuil nvarchar(255),
	tipo_documento nvarchar(30)
)

CREATE TABLE EQUISDE.rol(
	id_rol bigint PRIMARY KEY IDENTITY,
	nombre nvarchar(255) UNIQUE,
	habilitado bit
)

CREATE TABLE EQUISDE.rol_x_usuario(
	id_rol bigint REFERENCES EQUISDE.rol,
	usuario varchar(50) REFERENCES EQUISDE.usuario,
	primary key(id_rol,usuario)
)

CREATE TABLE EQUISDE.funcionalidad(
	id_funcionalidad bigint PRIMARY KEY IDENTITY,
	nombre nvarchar(255)
)

CREATE TABLE EQUISDE.rol_x_funcionalidad(
	id_rol bigint REFERENCES EQUISDE.rol,
	id_funcionalidad bigint REFERENCES EQUISDE.funcionalidad
)

CREATE TABLE EQUISDE.rubro(
	id_rubro bigint PRIMARY KEY IDENTITY,
	descripcion nvarchar(255)
)

CREATE TABLE EQUISDE.publicacion(
	id_publicacion numeric(18,0) PRIMARY KEY IDENTITY,
	id_rubro bigint REFERENCES EQUISDE.rubro,
	id_direccion bigint REFERENCES EQUISDE.direccion,
	username varchar(50) REFERENCES EQUISDE.usuario,
	descripcion nvarchar(255),
	fecha_publicacion datetime,
	fecha_vencimiento datetime,
)

CREATE TABLE EQUISDE.estado(
	id_estado bigint PRIMARY KEY IDENTITY,
	id_publicacion numeric(18,0) REFERENCES EQUISDE.publicacion,
	estado char(1),
	CHECK(estado IN ('A','B','F'))
)


CREATE TABLE EQUISDE.grado(
	id_grado bigint PRIMARY KEY IDENTITY,
	id_publicacion numeric(18,0) REFERENCES EQUISDE.publicacion,
	grado char(1),
	CHECK(grado IN ('A','B','M'))
)

CREATE TABLE EQUISDE.tipo(
	codigo_tipo numeric(18,0) PRIMARY KEY IDENTITY,
	descripcion nvarchar(255)
)


CREATE TABLE EQUISDE.ubicacion(
	id_ubicacion bigint PRIMARY KEY IDENTITY,
	id_publicacion numeric(18,0) REFERENCES EQUISDE.publicacion,
	codigo_tipo numeric(18,0) REFERENCES EQUISDE.tipo,
	fila varchar(3),
	asiento numeric(18,0),
	sin_numerar bit
)

CREATE TABLE EQUISDE.compra(
	id_compra bigint PRIMARY KEY IDENTITY,
	username varchar(50) REFERENCES EQUISDE.cliente,
	id_ubicacion bigint REFERENCES EQUISDE.ubicacion,
	main nvarchar(255),
	fecha_compra datetime,
	cantidad numeric(18,0),
	puntos bigint
)

CREATE TABLE EQUISDE.factura(
	id_factura numeric(18,0) PRIMARY KEY IDENTITY,
	fecha_emision datetime,
	factura_total numeric(18,2),
	forma_de_pago nvarchar(255)
)

CREATE TABLE EQUISDE.item(
	id_compra bigint PRIMARY KEY REFERENCES EQUISDE.compra,
	id_factura numeric(18,0) REFERENCES EQUISDE.factura,
	cantidad numeric(18,0),
	descripcion nvarchar(60),
	importe_venta numeric(18,2),
	importe_comiscion numeric(18,2)
)

CREATE TABLE EQUISDE.premio(
	id_premio bigint PRIMARY KEY IDENTITY,
	fecha_vencimiento datetime,
	fecha_emision datetime,
	puntos_necesario bigint,
	descripcion nvarchar(255)
)

CREATE TABLE EQUISDE.premio_x_cliente(
	id_premio bigint REFERENCES EQUISDE.premio,
	username varchar(50) REFERENCES EQUISDE.cliente,
	fecha_de_obtencion datetime,
	PRIMARY KEY(id_premio,username)
)