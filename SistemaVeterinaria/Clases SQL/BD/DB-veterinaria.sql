--create database veterinaria
drop database veterinaria
--ROL Y USUARIOS
create table ROL (
	id_rol int identity(1,1) not null primary key,
	nombre_rol varchar(20) not null
)
insert into ROL values('ADMINISTRADOR'),
						('VETERINARIO'),
						('SECRETARIA')


create table USUARIO (
	id_usuario int identity(1,1) not null primary key,
	eliminado_logico bit not null,
	codigo_usuario char(10) not null,
	clave_usuario int not null,
	rut_usuario varchar(12) not null,
	nombre_usuario varchar (40) not null,
	apellidos_usuario varchar (50) not null,
	fono_usuario varchar(13) , 
	cel_usuario char (12) not null,
	direccion_usuario varchar(60) not null,
	correo_usuario varchar (100) not null,
	id_rol_usuario int not null,
	constraint rol_usuario foreign key (id_rol_usuario) references ROL (id_rol)
)

insert into USUARIO values(1,'CRIST37149',12345,'18.973.714-9','Cristopher','Pérez Vargas','','+56978829337','Villa El Remanso, psj. Mariano LaTorre','vargas.cristopher@hotmail.com',1),
							(1, 'ANHIS44449',12345,'19.444.444-9','Anhis','Acevedo Carvallo','','+56954232354','Avenida Los Pajaritos s/n','acevedo_carvallo@hotmail.com',2),
							(1, 'KEVIN88889',12345,'14.888.888-9','Kevin','Labarca Muñoz','','+56924112233','Calle Los Molinos con Las Ciruelas','ratalabarca@hotmail.com',3)

--CLIENTE, MASCOTA Y CATEGORIA
create table CLIENTE(
	id_cliente int identity(1,1) not null primary key,
	rut_cliente varchar(12) not null,
	nombre_cliente varchar (50) not null,
	apellidos_cliente varchar (50) not null,
	fono_cliente varchar(13),
	cel_cliente char(12) not null,
	direccion_cliente varchar(50) not null 
)

create table CATEGORIA_MASCOTA(
	id_categoria int identity(1,1) not null primary key,
	nombre_categoria varchar(20) not null,
	descripcion_categoria varchar (20) not null
)

insert into CATEGORIA_MASCOTA values('ESCIÚRIDOS','Ardillas'),
									('MÚRIDOS','Ratones, ratas'),
									('CRICÉTIDOS','Hamsters'),
									('FÉLIDOS','Gatos'),
									('CÁNIDOS','Perros, zorros'),
									('MUSTÉLIDOS','Comadreja, tejon'),
									('GALLINÁCEAS','Gallos'),
									('TESTUDÍNIDOS','Tortugas'),
									('TITÓNIDOS','Lechuzas');

create table MASCOTA(
	id_mascota int identity(1,1) not null primary key,
	nombre_mascota varchar(50) not null,
	edad_mascota int not null,
	peso_mascota float not null,
	estatura_mascota float not null,
	raza_mascota varchar(30) not null,
	observacion_mascota varchar (200),
	id_cliente_mascota int not null,
	id_categoria_mascota int not null,
	id_usuario_mascota int not null,
	constraint cliente_mascota foreign key (id_cliente_mascota) references CLIENTE (id_cliente),
	constraint categoria_mascotas foreign key (id_categoria_mascota) references CATEGORIA_MASCOTA (id_categoria),
	constraint usuario_mascota foreign key (id_usuario_mascota) references USUARIO (id_usuario)
)

--CITA, TRATAMIENTO/RECETA, CONSULTA E HISTORIAL VACUNAS
create table CITA (
	id_cita int identity(1,1) not null primary key,
	fecha_cita datetime not null,
	descripcion_cita varchar (40) not null,
	estado_cita bit not null,
	id_cita_cliente int not null,
	constraint cita_cliente foreign key (id_cita_cliente) references CLIENTE (id_cliente)
)

create table TRATAMIENTO (
	id_tratamiento int identity(1,1) not null primary key,
	descripcion_tratamiento varchar(200) not null,
	id_tratamiento_mascota int not null,
	constraint tratamiento_mascota foreign key (id_tratamiento_mascota) references MASCOTA (id_mascota)
)

create table CONSULTA(
	id_consulta int identity(1,1) not null primary key,
	fecha_consulta datetime not null,
	sintomas_consulta varchar (200),
	diagnostico_consulta varchar (200),
	otra_consulta varchar (200) not null,
	estado_cosulta bit not null,
	id_consulta_mascota int not null,
	constraint consulta_mascota foreign key (id_consulta_mascota) references MASCOTA (id_mascota)
)

create table VACUNA(
	id_vacuna int identity (1,1) not null primary key,
	nombre_vacuna varchar (30) not null,
	fecha_programada datetime not null,
	fecha_realizada datetime,
	otros_vacuna varchar (100),
	estado_vacuna bit not null,
	id_vacuna_mascota int not null,
	constraint vacuna_mascota foreign key (id_vacuna_mascota) references MASCOTA (id_mascota)
)
