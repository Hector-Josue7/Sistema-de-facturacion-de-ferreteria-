-- Generated by Oracle SQL Developer Data Modeler 4.1.0.866
--   at:        2015-12-12 14:07:17 CST
--   site:      Oracle Database 11g
--   type:      Oracle Database 11g




CREATE TABLE TBL_ARTICULOS
  (
    "CODIGO ARTICULO"          INTEGER NOT NULL ,
    DESCRIPCION                VARCHAR2 (50) NOT NULL ,
    "PRECIO UNITARIO DE VENTA" NUMBER NOT NULL ,
    "DIAS DE VIDA UTIL"        INTEGER ,
    "CODIGO MARCA"             INTEGER NOT NULL ,
    "CODIGO PROVEEDOR"         INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_ARTICULOS ADD CONSTRAINT TBL_ARTICULOS_PK PRIMARY KEY ( "CODIGO ARTICULO" ) ;

CREATE TABLE TBL_BITACORA
  (
    "CODIGO BITACORA"       INTEGER NOT NULL ,
    FECHA                   DATE NOT NULL ,
    "NOMBRE DEL FORMULARIO" VARCHAR2 (40) NOT NULL ,
    "CODIGO EMPLEADO"       INTEGER NOT NULL ,
    "CODIGO CARGO"          INTEGER NOT NULL ,
    "CODIGO SUCURSAL"       INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_BITACORA ADD CONSTRAINT TBL_BITACORA_PK PRIMARY KEY ( "CODIGO BITACORA" ) ;

CREATE TABLE TBL_CARGOS
  (
    "CODIGO CARGO" INTEGER NOT NULL ,
    NOMBRE         VARCHAR2 (50) NOT NULL
  ) ;
ALTER TABLE TBL_CARGOS ADD CONSTRAINT TBL_CARGOS_PK PRIMARY KEY ( "CODIGO CARGO" ) ;

CREATE TABLE TBL_CLIENTES
  (
    "CODIGO CLIENTE"         INTEGER NOT NULL ,
    IDENTIDAD                VARCHAR2 (13) NOT NULL ,
    NOMBRE                   VARCHAR2 (100) NOT NULL ,
    TELEFONO                 INTEGER ,
    DIRECCION                VARCHAR2 (120) ,
    RTN                      VARCHAR2 (14) NOT NULL ,
    CORREO                   VARCHAR2 (50) ,
    "CODIGO TIPO DE CLIENTE" INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_CLIENTES ADD CONSTRAINT TBL_CLIENTES_PK PRIMARY KEY ( "CODIGO CLIENTE" ) ;
ALTER TABLE TBL_CLIENTES ADD CONSTRAINT TBL_CLIENTES__UN UNIQUE ( IDENTIDAD , RTN , CORREO ) ;

CREATE TABLE TBL_DETALLES_DE_PLANILLA
  (
    "CODIGO PLANILLA" INTEGER NOT NULL ,
    "CODIGO EMPLEADO" INTEGER NOT NULL ,
    IHSS              NUMBER NOT NULL ,
    "RAP/FOSOVI"      NUMBER NOT NULL ,
    INFOP             NUMBER NOT NULL ,
    BONIFICACION      NUMBER ,
    "SUELDO NETO"     NUMBER NOT NULL ,
    "CODIGO CARGO"    INTEGER NOT NULL ,
    "CODIGO SUCURSAL" INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_DETALLES_DE_PLANILLA ADD CONSTRAINT TBL_DETALLES_DE_PLANILLA_PK PRIMARY KEY ( "CODIGO PLANILLA", "CODIGO EMPLEADO" ) ;

CREATE TABLE TBL_DETALLE_FACTURA
  (
    "CANTIDAD ARTICULOS COMPRADOS" INTEGER NOT NULL ,
    "COSTO UNITARIO HISTORICO"     NUMBER NOT NULL ,
    "COSTO ACUMULADO"              NUMBER NOT NULL ,
    "CODIGO ARTICULO"              INTEGER NOT NULL ,
    "CODIGO FACTURA"               INTEGER NOT NULL ,
    "CODIGO SUCURSAL"              INTEGER NOT NULL
  ) ;

CREATE TABLE TBL_DETALLE_LOTE
  (
    "CODIGO SUCURSAL"           INTEGER NOT NULL ,
    "CODIGO LOTE"               INTEGER NOT NULL ,
    "CODIGO ARTICULO"           INTEGER NOT NULL ,
    "CANTIDAD COMPRADA"         INTEGER NOT NULL ,
    "PRECIO UNITARIO DE COMPRA" NUMBER NOT NULL ,
    "COSTO ACUMULADO"           NUMBER NOT NULL
  ) ;
ALTER TABLE TBL_DETALLE_LOTE ADD CONSTRAINT TBL_DETALLE_LOTE_PK PRIMARY KEY ( "CODIGO SUCURSAL", "CODIGO LOTE", "CODIGO ARTICULO" ) ;

CREATE TABLE TBL_EMPLEADOS
  (
    "CODIGO EMPLEADO" INTEGER NOT NULL ,
    "CODIGO CARGO"    INTEGER NOT NULL ,
    "CODIGO SUCURSAL" INTEGER NOT NULL ,
    IDENTIDAD         VARCHAR2 (13) NOT NULL ,
    NOMBRE            VARCHAR2 (100) NOT NULL ,
    "SUELDO BASE"     NUMBER NOT NULL ,
    "HORA ENTRADA"    DATE NOT NULL ,
    "HORA SALIDA"     DATE NOT NULL ,
    DIRECCION         VARCHAR2 (120) NOT NULL ,
    "TELEFONO FIJO"   NUMBER ,
    "TELEFONO MOVIL"  NUMBER ,
    CORREO            VARCHAR2 (50)
  ) ;
ALTER TABLE TBL_EMPLEADOS ADD CONSTRAINT TBL_EMPLEADOS_PK PRIMARY KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;
ALTER TABLE TBL_EMPLEADOS ADD CONSTRAINT TBL_EMPLEADOS__UN UNIQUE ( IDENTIDAD , CORREO ) ;

CREATE TABLE TBL_FACTURAS
  (
    "CODIGO FACTURA"       INTEGER NOT NULL ,
    "CODIGO SUCURSAL"      INTEGER NOT NULL ,
    FECHA                  DATE NOT NULL ,
    DESCUENTO              NUMBER ,
    SUBTOTAL               NUMBER NOT NULL ,
    "IMPUESTO S/V COBRADO" NUMBER NOT NULL ,
    TOTAL                  NUMBER NOT NULL ,
    "CODIGO EMPLEADO"      INTEGER NOT NULL ,
    "CODIGO CARGO"         INTEGER NOT NULL ,
    "CODIGO CLIENTE"       INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_FACTURAS ADD CONSTRAINT TBL_FACTURAS_PK PRIMARY KEY ( "CODIGO FACTURA", "CODIGO SUCURSAL" ) ;

CREATE TABLE TBL_INVENTARIOS
  (
    "CODIGO SUCURSAL"    INTEGER NOT NULL ,
    "CODIGO ARTICULO"    INTEGER NOT NULL ,
    "CANTIDAD EN BODEGA" INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_INVENTARIOS ADD CONSTRAINT TBL_INVENTARIOS_PK PRIMARY KEY ( "CODIGO SUCURSAL", "CODIGO ARTICULO" ) ;

CREATE TABLE TBL_LOTES
  (
    "CODIGO LOTE"         INTEGER NOT NULL ,
    "CODIGO SUCURSAL"     INTEGER NOT NULL ,
    "FECHA DE INGRESO"    DATE NOT NULL ,
    "IMPUESTO S/V PAGADO" NUMBER NOT NULL ,
    "COSTO TOTAL"         NUMBER NOT NULL
  ) ;
ALTER TABLE TBL_LOTES ADD CONSTRAINT TBL_LOTES_PK PRIMARY KEY ( "CODIGO SUCURSAL", "CODIGO LOTE" ) ;

CREATE TABLE TBL_MARCAS
  (
    "CODIGO MARCA" INTEGER NOT NULL ,
    NOMBRE         VARCHAR2 (30) NOT NULL
  ) ;
ALTER TABLE TBL_MARCAS ADD CONSTRAINT TBL_MARCAS_PK PRIMARY KEY ( "CODIGO MARCA" ) ;

CREATE TABLE TBL_PERMISOS
  (
    "CODIGO CARGO"      INTEGER NOT NULL ,
    PERMISO_INVENTARIO  CHAR (1) NOT NULL ,
    PERMISO_FACTURACION CHAR (1) NOT NULL ,
    PERMISO_REPORTES    CHAR (1) NOT NULL ,
    PERMISO_PLANILLA    CHAR (1) NOT NULL
  ) ;
ALTER TABLE TBL_PERMISOS ADD CONSTRAINT TBL_PERMISOS_PK PRIMARY KEY ( "CODIGO CARGO" ) ;

CREATE TABLE TBL_PLANILLAS
  (
    "CODIGO PLANILLA" INTEGER NOT NULL ,
    FECHA             DATE NOT NULL ,
    "CODIGO EMPLEADO" INTEGER NOT NULL ,
    "CODIGO CARGO"    INTEGER NOT NULL ,
    "CODIGO SUCURSAL" INTEGER NOT NULL
  ) ;
ALTER TABLE TBL_PLANILLAS ADD CONSTRAINT TBL_PLANILLAS_PK PRIMARY KEY ( "CODIGO PLANILLA" ) ;

CREATE TABLE TBL_PROVEEDORES
  (
    "CODIGO PROVEEDOR" INTEGER NOT NULL ,
    NOMBRE             VARCHAR2 (50) NOT NULL ,
    DIRECCION          VARCHAR2 (120) NOT NULL ,
    TELEFONO           INTEGER NOT NULL ,
    CORREO             VARCHAR2 (50) ,
    RTN                VARCHAR2 (14)
  ) ;
ALTER TABLE TBL_PROVEEDORES ADD CONSTRAINT TBL_PROVEEDORES_PK PRIMARY KEY ( "CODIGO PROVEEDOR" ) ;
ALTER TABLE TBL_PROVEEDORES ADD CONSTRAINT TBL_PROVEEDORES__UN UNIQUE ( CORREO ) ;

CREATE TABLE TBL_SUCURSALES
  (
    "CODIGO SUCURSAL" INTEGER NOT NULL ,
    NOMBRE            VARCHAR2 (100) NOT NULL ,
    CORREO            VARCHAR2 (30) NOT NULL ,
    TELEFONO          NUMBER NOT NULL ,
    RTN               VARCHAR2 (14) NOT NULL ,
    CAI               NUMBER NOT NULL
  ) ;
ALTER TABLE TBL_SUCURSALES ADD CONSTRAINT TBL_SUCURSALES_PK PRIMARY KEY ( "CODIGO SUCURSAL" ) ;
ALTER TABLE TBL_SUCURSALES ADD CONSTRAINT TBL_SUCURSALES__UN UNIQUE ( RTN , CAI ) ;

CREATE TABLE TBL_TIPO_CLIENTE
  (
    "CODIGO TIPO DE CLIENTE" INTEGER NOT NULL ,
    DESCRIPCION              VARCHAR2 (15) NOT NULL ,
    DESCUENTO                NUMBER NOT NULL
  ) ;
ALTER TABLE TBL_TIPO_CLIENTE ADD CONSTRAINT "TBL_TIPO CLIENTE_PK" PRIMARY KEY ( "CODIGO TIPO DE CLIENTE" ) ;

CREATE TABLE TBL_USUARIOS_DEL_SISTEMA
  (
    "CODIGO EMPLEADO" INTEGER NOT NULL ,
    "CODIGO CARGO"    INTEGER NOT NULL ,
    "CODIGO SUCURSAL" INTEGER NOT NULL ,
    USUARIO           VARCHAR2 (30) NOT NULL ,
    CONTRASENIA       VARCHAR2 (30) NOT NULL
  ) ;
ALTER TABLE TBL_USUARIOS_DEL_SISTEMA ADD CONSTRAINT TBL_USUARIOS_DEL_SISTEMA_PK PRIMARY KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_ARTICULOS ADD CONSTRAINT TBL_ART_TBL_MAR_FK FOREIGN KEY ( "CODIGO MARCA" ) REFERENCES TBL_MARCAS ( "CODIGO MARCA" ) ;

ALTER TABLE TBL_ARTICULOS ADD CONSTRAINT TBL_ART_TBL_PRO_FK FOREIGN KEY ( "CODIGO PROVEEDOR" ) REFERENCES TBL_PROVEEDORES ( "CODIGO PROVEEDOR" ) ;

ALTER TABLE TBL_BITACORA ADD CONSTRAINT TBL_BIT_TBL_USU_DEL_SIS_FK FOREIGN KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) REFERENCES TBL_USUARIOS_DEL_SISTEMA ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_CLIENTES ADD CONSTRAINT "TBL_CLI_TBL_TIP CLI_FK" FOREIGN KEY ( "CODIGO TIPO DE CLIENTE" ) REFERENCES TBL_TIPO_CLIENTE ( "CODIGO TIPO DE CLIENTE" ) ;

ALTER TABLE TBL_DETALLES_DE_PLANILLA ADD CONSTRAINT TBL_DET_DE_PLA_TBL_EMP_FK FOREIGN KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) REFERENCES TBL_EMPLEADOS ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_DETALLES_DE_PLANILLA ADD CONSTRAINT TBL_DET_DE_PLA_TBL_PLA_FK FOREIGN KEY ( "CODIGO PLANILLA" ) REFERENCES TBL_PLANILLAS ( "CODIGO PLANILLA" ) ;

ALTER TABLE TBL_DETALLE_FACTURA ADD CONSTRAINT TBL_DET_FAC_TBL_ART_FK FOREIGN KEY ( "CODIGO ARTICULO" ) REFERENCES TBL_ARTICULOS ( "CODIGO ARTICULO" ) ;

ALTER TABLE TBL_DETALLE_FACTURA ADD CONSTRAINT TBL_DET_FAC_TBL_FAC_FK FOREIGN KEY ( "CODIGO FACTURA", "CODIGO SUCURSAL" ) REFERENCES TBL_FACTURAS ( "CODIGO FACTURA", "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_DETALLE_LOTE ADD CONSTRAINT TBL_DET_LOT_TBL_ART_FK FOREIGN KEY ( "CODIGO ARTICULO" ) REFERENCES TBL_ARTICULOS ( "CODIGO ARTICULO" ) ;

ALTER TABLE TBL_DETALLE_LOTE ADD CONSTRAINT TBL_DET_LOT_TBL_LOT_FK FOREIGN KEY ( "CODIGO SUCURSAL", "CODIGO LOTE" ) REFERENCES TBL_LOTES ( "CODIGO SUCURSAL", "CODIGO LOTE" ) ;

ALTER TABLE TBL_EMPLEADOS ADD CONSTRAINT TBL_EMP_TBL_CAR_FK FOREIGN KEY ( "CODIGO CARGO" ) REFERENCES TBL_CARGOS ( "CODIGO CARGO" ) ;

ALTER TABLE TBL_EMPLEADOS ADD CONSTRAINT TBL_EMP_TBL_SUC_FK FOREIGN KEY ( "CODIGO SUCURSAL" ) REFERENCES TBL_SUCURSALES ( "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_FACTURAS ADD CONSTRAINT TBL_FAC_TBL_CLI_FK FOREIGN KEY ( "CODIGO CLIENTE" ) REFERENCES TBL_CLIENTES ( "CODIGO CLIENTE" ) ;

ALTER TABLE TBL_FACTURAS ADD CONSTRAINT "TBL_FAC_TBL_USU_DEL SIS_FK" FOREIGN KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) REFERENCES TBL_USUARIOS_DEL_SISTEMA ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_INVENTARIOS ADD CONSTRAINT TBL_INV_TBL_ART_FK FOREIGN KEY ( "CODIGO ARTICULO" ) REFERENCES TBL_ARTICULOS ( "CODIGO ARTICULO" ) ;

ALTER TABLE TBL_INVENTARIOS ADD CONSTRAINT TBL_INV_TBL_SUC_FK FOREIGN KEY ( "CODIGO SUCURSAL" ) REFERENCES TBL_SUCURSALES ( "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_LOTES ADD CONSTRAINT TBL_LOT_TBL_SUC_FK FOREIGN KEY ( "CODIGO SUCURSAL" ) REFERENCES TBL_SUCURSALES ( "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_PERMISOS ADD CONSTRAINT TBL_PER_TBL_CAR_FK FOREIGN KEY ( "CODIGO CARGO" ) REFERENCES TBL_CARGOS ( "CODIGO CARGO" ) ;

ALTER TABLE TBL_PLANILLAS ADD CONSTRAINT TBL_PLA_TBL_USU_DEL_SIS_FK FOREIGN KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) REFERENCES TBL_USUARIOS_DEL_SISTEMA ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;

ALTER TABLE TBL_USUARIOS_DEL_SISTEMA ADD CONSTRAINT TBL_USU_DEL_SIS_TBL_EMP_FK FOREIGN KEY ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) REFERENCES TBL_EMPLEADOS ( "CODIGO EMPLEADO", "CODIGO CARGO", "CODIGO SUCURSAL" ) ;


-- Oracle SQL Developer Data Modeler Summary Report: 
-- 
-- CREATE TABLE                            18
-- CREATE INDEX                             0
-- ALTER TABLE                             41
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
