CREATE DATABASE PracticaFinal

CREATE TABLE T_usuarios(
	ID_usuario int Primary key,
	Nombre varchar(20),
	Apellido varchar(20),
	Clave int,
	Sexo Char,
	Rol varchar(20),
	Fehca_registro date,
	Fecha_acceso date,
	B_activo char

);

--Trigger de acceso Prueba
UPDATE T_usuarios 
SET Fecha_acceso = GETDATE()
WHERE ID_usuario = 193440920
--

--LLenado de tabla usuarios 
INSERT INTO T_usuarios
VALUES(193440920,'Alfredo','Lopez',1234,'M','MAESTRO','2016-05-01','','T');
INSERT INTO T_usuarios
VALUES(593440121,'Martha','Romero',1234,'F','ALUMNO','2016-05-01','','T');
INSERT INTO T_usuarios
VALUES(593440122,'Juan','Infarte',1234,'M','ALUMNO','2016-05-01','','T');
INSERT INTO T_usuarios
VALUES(593440123,'María','Zamora',1234,'F','ALUMNO','2016-05-01','','T');
INSERT INTO T_usuarios
VALUES(593440124,'Diana','Reyes',1234,'F','ALUMNO','2016-05-01','','T');
INSERT INTO T_usuarios
VALUES(193440921,'Luis','Pasteur',1234,'M','ADMIN','2016-05-01','','T');
INSERT INTO T_usuarios
VALUES(193440930,'Cecilia','Arana',1234,'F','MAESTRO','2016-05-01','','T');
--

--Pruebas
SELECT * FROM T_usuarios;
SELECT * FROM T_CALIFICACIONES;
SELECT * FROM aux_Acceso;
--

--Tabla Calificaciones
CREATE TABLE T_CALIFICACIONES(
	ID_maestro int FOREIGN KEY REFERENCES T_usuarios(ID_usuario),
	ID_alumno int FOREIGN KEY REFERENCES T_usuarios(ID_usuario),
	Calificacion int,
	B_final char,
	Fecha_Final date,
);
--

--LLenado Calificaciones
INSERT INTO T_CALIFICACIONES
VALUES(193440920,593440121,100,'F','');
INSERT INTO T_CALIFICACIONES
VALUES(193440920,593440122,50,'F','');
INSERT INTO T_CALIFICACIONES
VALUES(193440930,593440123,100,'F','');
--

--Tabla Aux Acceso
CREATE TABLE aux_Acceso(
	ID_usuario int Primary key not null,
	clave varchar(20) not null
);
--

--Trigger de clave Prueba
UPDATE aux_Acceso 
SET clave = 'Solovino321'
WHERE ID_usuario = 193440920
--

--LLenado de claves
INSERT INTO aux_Acceso
VALUES(193440920,'Prueba123');
--

--Tablas AUX para los Trigers
CREATE TABLE TH_acceso
(
 ID_seq INT IDENTITY(1,1),
 ID_usuario int not null, 
 Fecha_acceso date,
);
--
CREATE TABLE TH_clave
(
 ID_seq INT IDENTITY(1,1),
 ID_usuario int not null,
 Clave_ant varchar(20),
 Fecha date
);
--

--Prubas de la tabla AUX de Trigg
SELECT * FROM TH_acceso
SELECT * FROM TH_clave
--

--Triger de acceso
CREATE TRIGGER TR_I_ACCESO ON [dbo].[T_usuarios]  
FOR UPDATE
AS
	declare @usuid int;

	select @usuid=i.ID_usuario from inserted i;	

	if update(Fecha_acceso)
	insert into TH_acceso
           (ID_usuario,Fecha_acceso) 
	values(@usuid,getdate());

	PRINT 'Acceso trigger disparado.'
GO
--
--Trigger cambio de clave
CREATE TRIGGER TR_I_CLAVES ON [dbo].[aux_Acceso]  
FOR UPDATE
AS
	declare @usuid int;
	declare @usupass varchar(20);
	declare @usupass_old varchar(20);

	select @usuid=i.ID_usuario from inserted i;
	select @usupass=i.clave from inserted i;
	select @usupass_old=d.clave from deleted d;	

	if update(clave)
	insert into TH_clave
           (ID_usuario,Clave_ant,Fecha) 
	values(@usuid,@usupass_old,getdate());

	PRINT 'Trigger de Act. de Clave.'
GO

--Procedimineto almacenado para resumen de datos
CREATE PROCEDURE sp_resumen
AS
--Cantidad Total de alumnos
SELECT COUNT(Rol) AS CantidadAlumnos FROM T_usuarios
WHERE Rol = 'ALUMNO'

--Promedio,Max,Min
SELECT (AVG(Calificacion)) AS Promedio,MAX(Calificacion) AS CalificacionMax,MIN(Calificacion) AS CalificacionMax FROM T_CALIFICACIONES

GO;
--

--VistaContulta
CREATE VIEW v_consulta AS
SELECT * FROM T_usuarios
WHERE Nombre = 'Juan'
--
--Prueba
SELECT * FROM v_consulta
--

--Funcion para saber si Alumno esta activo
CREATE FUNCTION fn_status_student(@status char)
RETURNS varchar(20)
BEGIN
	DECLARE @s_status varchar(20)
	IF @status = 'F'
		SET @s_status = 'Usuario Activo';
	ELSE
		SET @s_status = 'Usuario Inactivo';

	RETURN @s_status;
END
--

--PruebaFn
PRINT 'El estudiante esta: ' +  dbo.fn_status_student('F')
--




