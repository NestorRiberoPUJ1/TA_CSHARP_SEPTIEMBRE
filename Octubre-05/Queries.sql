SELECT * FROM mydb.usuarios;

SELECT id,nombre,apellido,alias,celular,disponibilidad as estado FROM usuarios 
/*Condiciones*/
ORDER BY apellido ASC	/*Ordenamiento*/
LIMIT 2	/*Limita la cantidad de resultados*/
OFFSET 4 	/*saltarnos los resultados iniciales por una cantidad en específica*/
;

/*
burton jagger
perez-ribero
verstappen
*/

/*JOIN 1-1 Incluyendo valores sin relacion */
SELECT usuarios.id,usuarios.alias as username, estado.contenido as estado FROM usuarios
LEFT JOIN estado ON usuarios.id=estado.usuarios_id
;

/* JOIN 1-M mensajes enviados */
SELECT usuarios.id,usuarios.alias as username, mensajes.contenido as contenido FROM usuarios
JOIN mensajes ON usuarios.id = mensajes.remitente_id
;

/* JOIN 1-M mensajes enviados */
SELECT usuarios.id,usuarios.alias as destinatario, mensajes.contenido as contenido FROM usuarios
JOIN mensajes ON usuarios.id = mensajes.destinatario_usuario_id
;

SELECT usuarios.id, usuarios.alias, COUNT(mensajes.contenido) as mensajes_enviados FROM usuarios
JOIN mensajes ON usuarios.id = mensajes.remitente_id
GROUP BY usuarios.id
ORDER BY mensajes_enviados DESC
;

/*M-M usuarios en grupos*/

SELECT usuarios.alias, UG.grupo_id,grupos.nombre FROM usuarios 
JOIN usuarios_en_grupos UG ON usuarios.id=UG.usuario_id
JOIN grupos ON UG.grupo_id=grupos.id
;


/*Mensajes entre usuarios M-M*/
SELECT remitentes.id as id_remitente, remitentes.alias AS remitente, mensajes.contenido, receptores.alias as receptor FROM usuarios remitentes
JOIN mensajes ON remitentes.id = mensajes.remitente_id
JOIN usuarios receptores ON  mensajes.destinatario_usuario_id = receptores.id

WHERE (remitentes.id=5 OR remitentes.id=6) AND (receptores.id=6 OR receptores.id=5)
;
SELECT remitentes.id as id_remitente, remitentes.alias AS remitente, mensajes.contenido, receptores.alias as receptor FROM usuarios remitentes
JOIN mensajes ON remitentes.id = mensajes.remitente_id
JOIN usuarios receptores ON  mensajes.destinatario_usuario_id = receptores.id

WHERE remitentes.id IN (5,6) AND receptores.id IN (5,6)
;


/*Mensajes grupales*/
SELECT remitentes.id as id_remitente, remitentes.alias AS remitente, mensajes.contenido, grupos.nombre as grupo FROM usuarios remitentes
JOIN mensajes ON remitentes.id = mensajes.remitente_id
JOIN grupos  ON  mensajes.destinatario_grupo_id = grupos.id
;


/*Self join referidos*/

SELECT usuarios.alias as user, referidos.alias as referido FROM usuarios
JOIN usuarios referidos on usuarios.referido_id=referidos.id

;





