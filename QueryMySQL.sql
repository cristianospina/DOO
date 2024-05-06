CREATE TABLE servicios (
    id int PRIMARY KEY,
    nombre VARCHAR(255),
    descripcion TEXT
);

SELECT s.nombre , s.descripcion
FROM servicios s
WHERE s.id = 1;

UPDATE servicios
SET valorservicio = 140000
WHERE id = 2;


INSERT INTO servicios (id,nombre, descripcion) VALUES (2,'Limpieza facial profunda +
activo purificante','Es un procedimiento ideal para
mejorar la salud y la apariencia de
la piel. Eliminando c�lulas muertas y
puntos negros. adem�s aplicamos un
activo con acci�n purificante en la
piel que desintoxica, limpia y ayuda a
controlar el acn�.');

SELECT *
FROM servicios

ALTER TABLE servicios
ADD TipoServicio VARCHAR(100);

ALTER TABLE servicios
ADD valorservicio numeric(12);

ALTER TABLE TipoServicio
RENAME TO tiposervicio;

