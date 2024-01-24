create database tabuada;

use tabuada;

DELIMITER $$
CREATE PROCEDURE tabuada(p_numero int )
BEGIN

DECLARE count int default 1;
declare soma int;
declare jaExiste int;

    CREATE TABLE IF NOT EXISTS tabuada.tabuada(
    numero int not null,
    multiplicador int not null,
    resultado int not null,
    primary key (numero, multiplicador)
    );
    
set jaExiste = (select count(numero) from tabuada.tabuada where numero = p_numero);

if (jaExiste = 0)then

	while (count <= 10) do
		insert into tabuada (numero, multiplicador, resultado)
		values (p_numero, count, p_numero * count);
        set count = count + 1;
	end while;
end if;

select * from tabuada.tabuada where numero = p_numero;  
    
END $$
DELIMITER ;


call tabuada(7);


drop procedure tabuada;