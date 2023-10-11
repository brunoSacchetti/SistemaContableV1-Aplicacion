CREATE database cuentas;
use cuentas;

CREATE TABLE cuentas (
	id INT AUTO_INCREMENT PRIMARY KEY,
    rubro VARCHAR(64),
    cuenta VARCHAR(64)
);

INSERT into cuentas values (null,"Activo", "Caja");
insert into cuentas values (null,"Activo","Banco c/c");
insert into cuentas values (null,"Activo","Mercaderias");
insert into cuentas values (null,"Resultado +","Intereses Ganados");
insert into cuentas values (null,"Activo","Rodados");
insert into cuentas values (null,"Activo","Inmuebles");
insert into cuentas values (null,"Pasivo","Proveedores");
insert into cuentas values (null,"PN","Capital");

select * from cuentas;