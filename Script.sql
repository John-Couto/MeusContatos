create table banco_herois (
id serial primary key, 
poder varchar(50),
nome varchar(10),
sexo varchar(9),
peso int,
studio varchar(20),
tamanho int,
cor_do_uniforme varchar(15)
)

INSERT INTO banco_herois(poder, nome, sexo, peso, studio, tamanho, cor_do_uniforme)
VALUES ('voar', 'baitola', 'feminino', 75, 'marvel', 2, 'azul' );

SELECT
   *
FROM
   banco_herois;