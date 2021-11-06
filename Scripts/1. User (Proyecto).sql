
-- Crear nuevo usuario(esquema) con el password "oracle" 
CREATE USER FERRETERIA
  IDENTIFIED BY "oracle"
  DEFAULT TABLESPACE USERS
  TEMPORARY TABLESPACE TEMP;

  -- Asignar cuota ilimitada al tablespace por defecto  
ALTER USER FERRETERIA QUOTA UNLIMITED ON USERS;

-- Asignar privilegios basicos
GRANT create session TO FERRETERIA;
GRANT create table TO FERRETERIA;
GRANT create view TO FERRETERIA;
GRANT create materialized view TO FERRETERIA;
GRANT create any trigger TO FERRETERIA;
GRANT create any procedure TO FERRETERIA;
GRANT create sequence TO FERRETERIA;
GRANT create synonym TO FERRETERIA;


