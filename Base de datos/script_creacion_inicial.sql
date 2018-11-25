IF OBJECT_ID('EQUISDE.premio_x_cliente') IS NOT NULL
DROP TABLE EQUISDE.premio_x_cliente
IF OBJECT_ID('EQUISDE.premio') IS NOT NULL
DROP TABLE EQUISDE.premio 
IF OBJECT_ID('EQUISDE.item') IS NOT NULL
DROP TABLE EQUISDE.item 
IF OBJECT_ID('EQUISDE.factura') IS NOT NULL
DROP TABLE EQUISDE.factura
IF OBJECT_ID('EQUISDE.compra_x_ubicacion') IS NOT NULL
DROP TABLE EQUISDE.compra_x_ubicacion
IF OBJECT_ID('EQUISDE.compra') IS NOT NULL
DROP TABLE EQUISDE.compra 
IF OBJECT_ID('EQUISDE.ubicacion') IS NOT NULL
DROP TABLE EQUISDE.ubicacion 
IF OBJECT_ID('EQUISDE.tipo') IS NOT NULL
DROP TABLE EQUISDE.tipo 
IF OBJECT_ID('EQUISDE.publicacion') IS NOT NULL
DROP TABLE EQUISDE.publicacion
IF OBJECT_ID('EQUISDE.grado') IS NOT NULL
DROP TABLE EQUISDE.grado 
IF OBJECT_ID('EQUISDE.estado') IS NOT NULL
DROP TABLE EQUISDE.estado
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
IF OBJECT_ID('EQUISDE.tarjeta') IS NOT NULL
DROP TABLE EQUISDE.tarjeta
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
	password varchar(64),
	habilitado bit DEFAULT 1
);

CREATE TABLE EQUISDE.direccion(
	id_direccion bigint PRIMARY KEY IDENTITY,
	calle nvarchar(50),
	nro_calle numeric(18,0),
	piso numeric(18,0),
	ciudad nvarchar(50),
	depto nvarchar(50),
	cpostal nvarchar(50),
	localidad nvarchar(50)
)

CREATE TABLE EQUISDE.empresa(
	username varchar(50) PRIMARY KEY REFERENCES EQUISDE.usuario,
	id_direccion bigint references EQUISDE.direccion,
	razon_social nvarchar(255),
	cuit nvarchar(255),
	fecha_creacion datetime,
	mail nvarchar(50),
	habilitado bit DEFAULT 1
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
	habilitado bit DEFAULT 1,
	puntos bigint,
	cuil nvarchar(255),
	tipo_documento nvarchar(30) DEFAULT 'DNI'
)

CREATE TABLE EQUISDE.rol(
	id_rol bigint PRIMARY KEY IDENTITY,
	nombre nvarchar(255),
	habilitado bit DEFAULT 1
)

CREATE TABLE EQUISDE.rol_x_usuario(
	id_rol bigint REFERENCES EQUISDE.rol,
	username varchar(50) REFERENCES EQUISDE.usuario,
	primary key(id_rol,username)
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

CREATE TABLE EQUISDE.estado(
	id_estado bigint PRIMARY KEY IDENTITY,
	estado char(1),
	CHECK(estado IN ('P','B','F'))
)


CREATE TABLE EQUISDE.grado(
	id_grado bigint PRIMARY KEY IDENTITY,
	estado varchar(30),
	CHECK(estado IN ('Alta','Baja','Media'))
)
CREATE TABLE EQUISDE.publicacion(
	id_publicacion numeric(18,0) PRIMARY KEY IDENTITY,
	id_rubro bigint REFERENCES EQUISDE.rubro,
	id_direccion bigint REFERENCES EQUISDE.direccion,
	id_estado bigint REFERENCES EQUISDE.estado,
	id_grado bigint REFERENCES EQUISDE.grado,
	username varchar(50) REFERENCES EQUISDE.usuario,
	descripcion nvarchar(255),
	fecha_publicacion datetime,
	fecha_vencimiento datetime,
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
	email nvarchar(255),
	fecha_compra datetime,
	cantidad numeric(18,0),
	puntos bigint DEFAULT 0
)

CREATE TABLE EQUISDE.compra_x_ubicacion(
	id_ubicacion bigint REFERENCES EQUISDE.ubicacion,
	id_compra bigint REFERENCES EQUISDE.compra,
	PRIMARY KEY(id_compra,id_ubicacion)
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
	puntos_necesarios bigint,
	descripcion nvarchar(255)
)

CREATE TABLE EQUISDE.premio_x_cliente(
	id_premio bigint REFERENCES EQUISDE.premio,
	username varchar(50) REFERENCES EQUISDE.cliente,
	fecha_de_obtencion datetime,
	PRIMARY KEY(id_premio,username)
)

CREATE TABLE EQUISDE.tarjeta(
	nro_tarjeta bigint PRIMARY KEY,
	username varchar(50) REFERENCES EQUISDE.cliente,
	fecha_vencimiento datetime,
	cod_seguridad numeric(10,0),
	nombre_titular nvarchar(255),
	importe numeric(18,0)
)

GO
MERGE EQUISDE.usuario d
USING (SELECT DISTINCT Espec_Empresa_Cuit username FROM gd_esquema.Maestra WHERE Espec_Empresa_Cuit IS NOT NULL) f
ON f.username = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,password)
	VALUES(f.username, HASHBYTES('SHA2_256',f.username));

GO

INSERT INTO EQUISDE.rol
(nombre,habilitado)
VALUES('empresa',1),('cliente',1),('admin',1);

INSERT INTO EQUISDE.funcionalidad
(nombre)
VALUES('abm de rol'),('registro de usuario'),('abm de clientes'),('abm de empresa de espectaculos'),('abm de rubro'),('abm grado de publicacion'),('generar publicacion'),('editar publicacion'),('comprar'),('historial de cliente'),
('canje de administracion de puntos'),('generar rendicion de comisiones'),('listado estadistico');

INSERT INTO EQUISDE.rol_x_funcionalidad
(id_funcionalidad,id_rol)
SELECT id_funcionalidad,id_rol FROM EQUISDE.rol r JOIN EQUISDE.funcionalidad f ON(f.nombre = 'abm de rol' OR f.nombre = 'abm de clientes' OR f.nombre = 'abm de empresa de espectaculos' OR f.nombre = 'abm de rubro' OR f.nombre = 'listado estadistico') WHERE r.nombre = 'admin' 

INSERT INTO EQUISDE.rol_x_funcionalidad
(id_funcionalidad,id_rol)
SELECT id_funcionalidad,id_rol FROM EQUISDE.rol r JOIN EQUISDE.funcionalidad f ON(f.nombre = 'registro de usuario' OR f.nombre = 'historial de cliente' OR f.nombre = 'comprar' OR f.nombre = 'canje de administracion de puntos') WHERE r.nombre = 'cliente' 

INSERT INTO EQUISDE.rol_x_funcionalidad
(id_funcionalidad,id_rol)
SELECT id_funcionalidad,id_rol FROM EQUISDE.rol r JOIN EQUISDE.funcionalidad f ON(f.nombre = 'registro de usuario' OR f.nombre = 'abm grado de publicacion' OR f.nombre = 'generar publicacion' OR f.nombre = 'editar publicacion' OR f.nombre = 'generar rendicion de comisiones') WHERE r.nombre = 'empresa' 


MERGE EQUISDE.rol_x_usuario d
USING (SELECT DISTINCT Espec_Empresa_Cuit username,id_rol FROM gd_esquema.Maestra JOIN EQUISDE.rol ON(nombre='empresa') WHERE Espec_Empresa_Cuit IS NOT NULL) f
ON d.username = f.username AND d.id_rol = f.id_rol
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,id_rol)
	VALUES(f.username,f.id_rol);

MERGE EQUISDE.usuario d
USING (SELECT DISTINCT CAST(Cli_Dni AS varchar(255)) username FROM gd_esquema.Maestra WHERE Cli_Dni IS NOT NULL) f
ON f.username = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,password)
	VALUES(f.username, HASHBYTES('SHA2_256',username));

GO

MERGE EQUISDE.rol_x_usuario d
USING (SELECT DISTINCT CAST(Cli_Dni AS varchar(255)) username,id_rol FROM gd_esquema.Maestra JOIN EQUISDE.rol ON(nombre='cliente') WHERE Cli_Dni IS NOT NULL) f
ON d.username = f.username AND d.id_rol = f.id_rol
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,id_rol)
	VALUES(f.username,f.id_rol);


MERGE EQUISDE.direccion d
USING (SELECT DISTINCT Espec_Empresa_Dom_Calle,Espec_Empresa_Nro_Calle,Espec_Empresa_Piso,Espec_Empresa_Depto,Espec_Empresa_Cod_Postal FROM gd_esquema.Maestra WHERE Espec_Empresa_Dom_Calle IS NOT NULL) f
ON d.calle = f.Espec_Empresa_Dom_Calle AND d.nro_calle = f.Espec_Empresa_Nro_Calle AND d.piso = f.Espec_Empresa_Piso AND d.depto = f.Espec_Empresa_Depto AND d.cpostal = f.Espec_Empresa_Cod_Postal 
WHEN NOT MATCHED BY TARGET THEN
	INSERT(calle,nro_calle,piso,depto,cpostal)
	VALUES(f.Espec_Empresa_Dom_Calle,f.Espec_Empresa_Nro_Calle,f.Espec_Empresa_Piso,f.Espec_Empresa_Depto,f.Espec_Empresa_Cod_Postal);

MERGE EQUISDE.direccion d
USING (SELECT DISTINCT Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso, Cli_Depto, Cli_Cod_Postal FROM gd_esquema.Maestra WHERE Cli_Dom_Calle IS NOT NULL)f
ON d.calle = f.Cli_Dom_Calle AND d.nro_calle = f.Cli_Nro_Calle AND d.piso = f.Cli_Piso AND d.depto = f.Cli_Depto AND d.cpostal = f.Cli_Cod_Postal 
WHEN NOT MATCHED BY TARGET THEN
	INSERT(calle,nro_calle,piso,depto,cpostal)
	VALUES(f.Cli_Dom_Calle,f.Cli_Nro_Calle,f.Cli_Piso,f.Cli_Depto,f.Cli_Cod_Postal);

MERGE EQUISDE.empresa d
USING (SELECT DISTINCT Espec_Empresa_Razon_Social,Espec_Empresa_Cuit,Espec_Empresa_Fecha_Creacion,Espec_Empresa_Mail,id_direccion FROM gd_esquema.Maestra gd JOIN EQUISDE.direccion di
ON(gd.Espec_Empresa_Dom_Calle = di.calle AND gd.Espec_Empresa_Nro_Calle= di.nro_calle AND gd.Espec_Empresa_Piso=di.piso AND gd.Espec_Empresa_Depto = di.depto AND gd.Espec_Empresa_Cod_Postal = di.cpostal))f
ON f.Espec_Empresa_Cuit = d.username
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,razon_social,cuit,fecha_creacion,mail,id_direccion)
	VALUES(f.Espec_Empresa_Cuit,f.Espec_Empresa_Razon_Social,f.Espec_Empresa_Cuit,f.Espec_Empresa_Fecha_Creacion,f.Espec_Empresa_Mail,f.id_direccion);

MERGE EQUISDE.cliente d
USING (SELECT DISTINCT Cli_Dni,Cli_Apeliido,Cli_Nombre,Cli_Fecha_Nac,Cli_Mail,GETDATE() fecha_creacion, id_direccion FROM gd_esquema.Maestra gd JOIN EQUISDE.direccion di
ON(gd.Cli_Dom_Calle = di.calle AND gd.Cli_Nro_Calle= di.nro_calle AND gd.Cli_Piso=di.piso AND gd.Cli_Depto = di.depto AND gd.Cli_Cod_Postal = di.cpostal))f
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

MERGE EQUISDE.estado d
USING (SELECT DISTINCT SUBSTRING(Espectaculo_Estado,1,1) estado FROM gd_esquema.Maestra)f
ON f.estado = d.estado
WHEN NOT MATCHED BY TARGET THEN
	INSERT(estado)
	VALUES(f.estado);


SET IDENTITY_INSERT EQUISDE.publicacion ON 
MERGE EQUISDE.publicacion d
USING (SELECT DISTINCT Espec_Empresa_Cuit,Espectaculo_Cod,Espectaculo_Descripcion,Espectaculo_Fecha,Espectaculo_Fecha_Venc,id_rubro,id_estado FROM gd_esquema.Maestra JOIN EQUISDE.rubro ON(descripcion = Espectaculo_Rubro_Descripcion) JOIN EQUISDE.estado ON (SUBSTRING(Espectaculo_Estado,1,1) = estado))f
ON f.Espectaculo_Cod = d.id_publicacion
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_publicacion, id_rubro, username,descripcion, fecha_publicacion,fecha_vencimiento,id_estado)
	VALUES(f.Espectaculo_Cod,f.id_rubro,f.Espec_Empresa_Cuit,f.Espectaculo_Descripcion,f.Espectaculo_Fecha,f.Espectaculo_Fecha_Venc,id_estado);
SET IDENTITY_INSERT EQUISDE.publicacion OFF 

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
USING(SELECT DISTINCT Compra_Fecha,Compra_Cantidad,Cli_Dni FROM gd_esquema.Maestra  WHERE Compra_Fecha IS NOT NULL) f
ON d.username = f.Cli_Dni AND d.cantidad = f.Compra_Cantidad AND d.fecha_compra = f.Compra_Fecha
WHEN NOT MATCHED BY TARGET THEN
	INSERT(username,fecha_compra,cantidad)
	VALUES(f.Cli_Dni,f.Compra_Fecha,f.Compra_Cantidad);

MERGE EQUISDE.compra_x_ubicacion d
USING(SELECT DISTINCT id_ubicacion, id_compra FROM EQUISDE.ubicacion u JOIN gd_esquema.Maestra m ON (u.id_publicacion = m.Espectaculo_Cod AND u.codigo_tipo = m.Ubicacion_Tipo_Codigo AND u.fila = m.Ubicacion_Fila AND u.asiento = m.Ubicacion_Asiento AND u.precio = m.Ubicacion_Precio AND u.sin_numerar = m.Ubicacion_Sin_numerar)
JOIN EQUISDE.compra c ON (c.username=m.Cli_Dni AND c.fecha_compra = m.Compra_Fecha AND c.cantidad = m.Compra_Cantidad) WHERE id_ubicacion IS NOT NULL AND id_compra IS NOT NULL)f
ON d.id_ubicacion = f.id_ubicacion AND d.id_compra = f.id_compra
WHEN NOT MATCHED BY TARGET THEN
	INSERT(id_compra,id_ubicacion)
	VALUES(f.id_compra,f.id_ubicacion);

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

INSERT INTO EQUISDE.premio
(fecha_vencimiento,fecha_emision,puntos_necesarios,descripcion)
VALUES('01/01/2019','10/03/2018',321,'Entradas al superclasico'),('10/01/2019','11/22/2018',120,'Peluche de Winnie Pooh'),('02/15/2019','09/08/2018',0,'Alienware')

INSERT INTO EQUISDE.grado
VALUES('Alta'),('Media'),('Baja');