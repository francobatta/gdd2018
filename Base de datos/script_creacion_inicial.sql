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
	fecha_creacion datetime,
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
	CHECK(estado IN ('P','B','F'))
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
	precio numeric(18,0),
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
	id_item bigint PRIMARY KEY IDENTITY, 
	id_compra bigint REFERENCES EQUISDE.compra,
	id_factura numeric(18,0) REFERENCES EQUISDE.factura,
	cantidad numeric(18,0),
	descripcion nvarchar(60),
	importe_venta numeric(18,2),
	importe_comision numeric(18,2)
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


GO
MERGE EQUISDE.usuario d
USING (SELECT DISTINCT Espec_Empresa_Cuit username FROM gd_esquema.Maestra WHERE Espec_Empresa_Cuit IS NOT NULL) f
ON f.username = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,password)
	VALUES(f.username, HASHBYTES('SHA2_256',f.username));

GO
MERGE EQUISDE.usuario d
USING (SELECT DISTINCT CAST(Cli_Dni AS varchar(255)) username FROM gd_esquema.Maestra WHERE Cli_Dni IS NOT NULL) f
ON f.username = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,password)
	VALUES(f.username, HASHBYTES('SHA2_256',username));

GO
MERGE EQUISDE.direccion d
USING (SELECT DISTINCT Espec_Empresa_Dom_Calle,Espec_Empresa_Nro_Calle,Espec_Empresa_Piso,Espec_Empresa_Depto,Espec_Empresa_Cod_Postal FROM gd_esquema.Maestra WHERE Espec_Empresa_Dom_Calle IS NOT NULL) f
ON d.calle = f.Espec_Empresa_Dom_Calle AND d.nro_calle = f.Espec_Empresa_Nro_Calle AND d.piso = f.Espec_Empresa_Piso AND d.depto = f.Espec_Empresa_Depto AND d.cod_postal = f.Espec_Empresa_Cod_Postal 
WHEN NOT MATCHED BY TARGET THEN
	INSERT(calle,nro_calle,piso,depto,cod_postal)
	VALUES(f.Espec_Empresa_Dom_Calle,f.Espec_Empresa_Nro_Calle,f.Espec_Empresa_Piso,f.Espec_Empresa_Depto,f.Espec_Empresa_Cod_Postal);

MERGE EQUISDE.direccion d
USING (SELECT DISTINCT Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso, Cli_Depto, Cli_Cod_Postal FROM gd_esquema.Maestra WHERE Cli_Dom_Calle IS NOT NULL)f
ON d.calle = f.Cli_Dom_Calle AND d.nro_calle = f.Cli_Nro_Calle AND d.piso = f.Cli_Piso AND d.depto = f.Cli_Depto AND d.cod_postal = f.Cli_Cod_Postal 
WHEN NOT MATCHED BY TARGET THEN
	INSERT(calle,nro_calle,piso,depto,cod_postal)
	VALUES(f.Cli_Dom_Calle,f.Cli_Nro_Calle,f.Cli_Piso,f.Cli_Depto,f.Cli_Cod_Postal);

MERGE EQUISDE.empresa d
USING (SELECT DISTINCT Espec_Empresa_Razon_Social,Espec_Empresa_Cuit,Espec_Empresa_Fecha_Creacion,Espec_Empresa_Mail,id_direccion FROM gd_esquema.Maestra gd JOIN EQUISDE.direccion di
ON(gd.Espec_Empresa_Dom_Calle = di.calle AND gd.Espec_Empresa_Nro_Calle= di.nro_calle AND gd.Espec_Empresa_Piso=di.piso AND gd.Espec_Empresa_Depto = di.depto AND gd.Espec_Empresa_Cod_Postal = di.cod_postal))f
ON f.Espec_Empresa_Cuit = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,razon_social,cuit,fecha_creacion,mail,id_direccion)
	VALUES(f.Espec_Empresa_Cuit,f.Espec_Empresa_Razon_Social,f.Espec_Empresa_Cuit,f.Espec_Empresa_Fecha_Creacion,f.Espec_Empresa_Mail,f.id_direccion);

MERGE EQUISDE.cliente d
USING (SELECT DISTINCT Cli_Dni,Cli_Apeliido,Cli_Nombre,Cli_Fecha_Nac,Cli_Mail,GETDATE() fecha_creacion, id_direccion FROM gd_esquema.Maestra gd JOIN EQUISDE.direccion di
ON(gd.Cli_Dom_Calle = di.calle AND gd.Cli_Nro_Calle= di.nro_calle AND gd.Cli_Piso=di.piso AND gd.Cli_Depto = di.depto AND gd.Cli_Cod_Postal = di.cod_postal))f
ON f.Cli_Dni = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,nombre, apellido, dni,mail,fecha_nacimiento, fecha_creacion, id_direccion)
	VALUES(f.Cli_Dni, f.Cli_Nombre, f.Cli_Apeliido, f.Cli_Dni, f.Cli_Mail,f.Cli_Fecha_Nac, f.fecha_creacion,id_direccion);

MERGE EQUISDE.rubro d
USING (SELECT DISTINCT Espectaculo_Rubro_Descripcion FROM gd_esquema.Maestra)f
ON f.Espectaculo_Rubro_Descripcion = d.descripcion
WHEN NOT MATCHED BY TARGET THEN
	INSERT(descripcion)
	VALUES(Espectaculo_Rubro_Descripcion);

SET IDENTITY_INSERT EQUISDE.publicacion ON 

MERGE EQUISDE.publicacion d
USING (SELECT DISTINCT Espec_Empresa_Cuit,Espectaculo_Cod,Espectaculo_Descripcion,Espectaculo_Fecha,Espectaculo_Fecha_Venc,id_rubro FROM gd_esquema.Maestra JOIN EQUISDE.rubro ON(descripcion = Espectaculo_Rubro_Descripcion))f
ON f.Espectaculo_Cod = d.id_publicacion
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_publicacion, id_rubro, username,descripcion, fecha_publicacion,fecha_vencimiento)
	VALUES(f.Espectaculo_Cod,f.id_rubro,f.Espec_Empresa_Cuit,f.Espectaculo_Descripcion,f.Espectaculo_Fecha,f.Espectaculo_Fecha_Venc);

SET IDENTITY_INSERT EQUISDE.publicacion OFF 

MERGE EQUISDE.estado d
USING (SELECT DISTINCT Espectaculo_Cod,SUBSTRING(Espectaculo_Estado,1,1) estado FROM gd_esquema.Maestra)f
ON f.Espectaculo_Cod = d.id_publicacion AND f.estado = d.estado
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_publicacion,estado)
	VALUES(f.Espectaculo_Cod,f.estado);

SET IDENTITY_INSERT EQUISDE.tipo ON 

MERGE EQUISDE.tipo d
USING (SELECT DISTINCT Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion FROM gd_esquema.Maestra)f
ON d.codigo_tipo = f.Ubicacion_Tipo_Codigo
WHEN NOT MATCHED BY TARGET THEN
	INSERT(codigo_tipo,descripcion)
	VALUES(f.Ubicacion_Tipo_Codigo,f.Ubicacion_Tipo_Descripcion);

SET IDENTITY_INSERT EQUISDE.tipo OFF 

MERGE EQUISDE.ubicacion d
USING(SELECT DISTINCT Espectaculo_Cod,Ubicacion_Fila,Ubicacion_Asiento,Ubicacion_Sin_numerar,Ubicacion_Precio,Ubicacion_Tipo_Codigo FROM gd_esquema.Maestra)f
ON d.id_publicacion = Espectaculo_Cod AND d.codigo_tipo = f.Ubicacion_Tipo_Codigo AND d.fila=f.Ubicacion_Fila AND d.asiento = f.Ubicacion_Asiento AND d.sin_numerar = f.Ubicacion_Sin_numerar AND d.precio = f.Ubicacion_Precio AND d.codigo_tipo = f.Ubicacion_Tipo_Codigo
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_publicacion, codigo_tipo,fila,asiento,precio,sin_numerar)
	VALUES(f.Espectaculo_Cod,f.Ubicacion_Tipo_Codigo,f.Ubicacion_Fila,f.Ubicacion_Asiento,f.Ubicacion_Precio,f.Ubicacion_Sin_numerar);

MERGE EQUISDE.compra d
USING(SELECT DISTINCT Compra_Fecha,Compra_Cantidad,Cli_Dni, id_ubicacion FROM gd_esquema.Maestra JOIN EQUISDE.ubicacion ON (Espectaculo_Cod=id_publicacion AND Ubicacion_Tipo_Codigo = codigo_tipo AND Ubicacion_Fila=fila
AND Ubicacion_Asiento = asiento AND Ubicacion_Precio = precio AND Ubicacion_Sin_numerar = sin_numerar) WHERE Compra_Fecha IS NOT NULL) f
ON d.username = f.Cli_Dni AND d.id_ubicacion = f.id_ubicacion AND d.cantidad = f.Compra_Cantidad AND d.fecha_compra = f.Compra_Fecha
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,id_ubicacion,fecha_compra,cantidad)
	VALUES(f.Cli_Dni,f.id_ubicacion,f.Compra_Fecha,f.Compra_Cantidad);

SET IDENTITY_INSERT EQUISDE.factura ON

MERGE EQUISDE.factura d
USING(SELECT DISTINCT Factura_Nro,Factura_Fecha,Factura_Total,Forma_Pago_Desc FROM gd_esquema.Maestra WHERE Factura_Nro IS NOT NULL)f
ON id_factura = Factura_Nro
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_factura,fecha_emision,factura_total,forma_de_pago)
	VALUES(f.Factura_Nro,f.Factura_Fecha,f.Factura_Total,f.Forma_Pago_Desc);

SET IDENTITY_INSERT EQUISDE.factura OFF


MERGE EQUISDE.item d
USING(SELECT DISTINCT Factura_Nro,Item_Factura_Monto,Item_Factura_Cantidad,Item_Factura_Descripcion, id_compra FROM gd_esquema.Maestra gd JOIN EQUISDE.compra ON(username = Cli_Dni AND fecha_compra = Compra_Fecha AND cantidad = Compra_Cantidad) WHERE Factura_Nro IS NOT NULL)f
ON f.Factura_Nro = d.id_factura AND f.id_compra = d.id_compra AND f.Item_Factura_Monto = d.importe_comision AND  d.descripcion = f.Item_Factura_Descripcion AND d.cantidad = f.Item_Factura_Cantidad
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_factura,id_compra,importe_comision,descripcion,cantidad)
	VALUES(f.Factura_Nro,f.id_compra,f.Item_Factura_Monto,f.Item_Factura_Descripcion, f.Item_Factura_Cantidad);