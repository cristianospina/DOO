CREATE TABLE servicios (
    id int PRIMARY KEY,
    nombre VARCHAR(255),
    descripcion TEXT
);

SELECT s.nombre , s.descripcion
FROM servicios s
WHERE s.id = 1;

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