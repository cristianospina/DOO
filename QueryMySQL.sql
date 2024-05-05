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
la piel. Eliminando células muertas y
puntos negros. además aplicamos un
activo con acción purificante en la
piel que desintoxica, limpia y ayuda a
controlar el acné.');

SELECT *
FROM servicios