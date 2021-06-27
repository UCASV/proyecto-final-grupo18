Create Database Vacunacion_DB;
USE Vacunacion_DB

Create table Empleo(
id int not null primary key,
Empleo varchar (50),
)
Create table Enfermedades(
id int not null primary key,
Enfermedades varchar (100),
)
create table Dosis(
id int  not null primary key,
dosis varchar(50)
)
create table Ciudadano(
DUI int not null primary key ,
nombre varchar(100),
direccion_casa char (100),
email varchar (50),
telefono varchar(50),
id_enfermedades int not null,
foreign key (id_enfermedades) references Enfermedades (id),
id_empleo int not null,
foreign key (id_empleo) references Empleo (id),
id_dosis int not null,
foreign key (id_dosis) references Dosis (id)
)
Create table Cita(
id int identity(1,1) not null primary key,
lugar varchar (1000),
fecha date,
hora varchar(50),
id_dosis int null,
foreign key (id_dosis) references Dosis (id),
DUI_ciudadano int not null,
foreign key (DUI_ciudadano) references Ciudadano (DUI)
)
create table Preguntas (
id int not null primary key,
pregunta varchar(100)
)

Create table Gestor(
id int identity(1,1) not null primary key,
nombre varchar(100),
contrasena varchar(100),
correo_institucional varchar (50),
direccion varchar (100),
id_pregunta int not null
foreign key (id_pregunta) references Preguntas(id),
respuesta varchar (100)
)
create table Registro(
id int identity(1,1) not null primary key,
Fechayhora datetime, 
id_gestor int not null,
foreign key (id_gestor) references Gestor (id)
)
Create table Cabina(
id int identity(1,1) not null primary key,
ubicacion varchar(50),
id_gestor int not null,
foreign key (id_gestor) references Gestor (id),
email varchar(50),
telefono varchar(50)
)
Create table CitaXCabina(
id int identity(1,1) not null primary key,
id_cita int not null 
foreign key (id_cita) references Cita (id),
id_cabina int not null,
foreign key (id_cabina) references Cabina (id),
)
Create table CabinaXCiudadano(
id int identity(1,1) not null primary key,
id_cabina int not null,
foreign key (id_cabina) references Cabina (id),
Dui_ciudadano int not null,
foreign key (DUI_ciudadano) references Ciudadano (DUI),
)
----INSERTS
insert into Enfermedades values (1, 'Cancer');
insert into Enfermedades values (2, 'Artritis');
insert into Enfermedades values (3, 'Diabetes');
insert into Enfermedades values (4, 'Sida');
insert into Enfermedades values (5, 'Hepatitis');
insert into Enfermedades values (6, 'Asma');
insert into Enfermedades values (7, 'Alzheimer y demensia');
insert into Enfermedades values (8, 'EPOC');
insert into Enfermedades values (9, 'Enfermedad de Crohn');
insert into Enfermedades values (10, 'Fibrosis Quistica');
insert into Enfermedades values (11, 'Epilepsia');
insert into Enfermedades values (12, 'Enfermedad del corazon');
insert into Enfermedades values (13, 'Transtornos del humor');
insert into Enfermedades values (14, 'Esclerosis multiple');
insert into Enfermedades values (15, 'Mal de parkinson');

insert into Empleo values (1, 'Doctores')
insert into Empleo values (2, 'Enfermeros')
insert into Empleo values (3, 'Militares')
insert into Empleo values (4, 'Profesores')
insert into Empleo values (5, 'Policia')

insert into Dosis values (1, 'Primara dosis')
insert into Dosis values (2, 'Segunda dosis')

insert into Preguntas values (1, 'Cual es tu color favorito?')

insert into Gestor values ('Alonso', '1234', 'dorito@gmail.com', 'La gloria', 1, 'azul')

--insert into Registro values (1, )

insert into Ciudadano values (01234567, 'Alonso', 'La cima', '@Erazo', '78236530', 1, 1, 1)

insert into Cita Values ('La gran via', '2021/8/20', '7:00 am', 1, 01234567)

insert into Cabina values ('Por ahí', 1, '@Istambul', '0000-2222')



insert into CitaXCabina (id_cita, id_cabina) Values (1, 1)

Insert into CabinaXCiudadano Values (1, 01234567)





drop database Vacunacion_DB

select * from Cita

select * from Ciudadano

select * from Gestor

select * from CitaXCabina

select * from CabinaXCiudadano

select * from Enfermedades

--CRUD de CITA

--READ
SELECT c.id 'Id', c.lugar 'Lugar', c.fecha 'Fecha', c.hora 'hora', d.dosis 'Dosis' , ciu.nombre 'Ciudadano'
FROM Cita as c
INNER JOIN Dosis as d ON c.id_dosis = d.id
INNER JOIN Ciudadano as ciu ON c.DUI_ciudadano = ciu.DUI


select c.id 'Id', c.lugar 'Lugar', c.fecha 'Fecha', c.hora 'Hora', c.id_dosis 'Dosis', c.DUI_ciudadano 'DUI ciudadano' from Cita as c


SELECT  c.DUI, c.nombre, c.direccion_casa, c.email, c.telefono, e.Enfermedades, em.Empleo, d.dosis
FROM Ciudadano as c
INNER JOIN Enfermedades as e ON c.id_enfermedades = e.id
INNER JOIN Empleo as em ON c.id_empleo = em.id
INNER JOIN Dosis as d ON c.id_dosis = d.id
