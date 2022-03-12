create database Hotel5taReal

GO

USE Hotel5taReal

GO

CREATE TABLE  CATEGORIA(
IdCategoria int primary key identity,
Descripcion varchar(50),
Estado bit default 1,
FechaCreacion datetime default getdate()
)


GO

CREATE TABLE  PISO(
IdPiso int primary key identity,
Descripcion varchar(50),
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go

CREATE TABLE  ESTADO_HABITACION(
IdEstadoHabitacion int primary key,
Descripcion varchar(50),
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go

CREATE TABLE  HABITACION(
IdHabitacion int primary key identity,
Numero varchar(50),
Detalle varchar(100),
Precio decimal(10,2),
IdEstadoHabitacion int references ESTADO_HABITACION(IdEstadoHabitacion),
IdPiso int references PISO(IdPiso),
IdCategoria int references CATEGORIA(IdCategoria),
Estado bit default 1,
FechaCreacion datetime default getdate()
)


go

create table PRODUCTO(
IdProducto int primary key identity,
Nombre varchar(50),
Detalle varchar(100),
Precio decimal(10,2),
Cantidad int,
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go
CREATE TABLE TIPO_PERSONA(
IdTipoPersona  int primary key,
Descripcion varchar(50),
Estado bit default 1,
FechaCreacion datetime default getdate()
)

go

CREATE TABLE PERSONA(
IdPersona int not null primary key identity,
TipoDocumento  varchar(15),
Documento varchar(15),
Nombre varchar(50),
Apellido varchar(50),
Correo varchar(50),
Clave varchar(50),
IdTipoPersona int references TIPO_PERSONA(IdTipoPersona),
Estado bit default 1,
FechaCreacion datetime default getdate()
)


go


CREATE TABLE RECEPCION(
IdRecepcion int primary key identity,
IdCliente int references PERSONA(IdPersona),
IdHabitacion int references HABITACION(IdHabitacion),
FechaEntrada datetime default getdate(),
FechaSalida datetime,
FechaSalidaConfirmacion datetime,
PrecioInicial decimal(10,2),
Adelanto decimal(10,2),
PrecioRestante decimal(10,2),
TotalPagado decimal(10,2) default 0,
CostoPenalidad decimal(10,2) default 0,
Observacion varchar(500),
Estado bit
)

go

create table VENTA(
IdVenta int primary key identity,
IdRecepcion int references RECEPCION(IdRecepcion),
Total decimal(10,2),
Estado varchar(50) 
)

go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int,
SubTotal decimal(10,2)
)




-- tabla TRABAJADORES
create table TRABAJADORES(
TRA_codigo int primary key identity(1,1),
TRA_nombres varchar(50) not null,
TRA_apellidoPaterno varchar(50) not null,
TRA_apellidoMaterno varchar(50) not null,
TRA_dni char(8) not null,
TRA_fechaContrato date default(getdate()),
TRA_cargo varchar(50) not null check(TRA_cargo='Obrero' or TRA_cargo='Operador' or TRA_cargo='Ejecutivo') default('Operador'),
TRA_sueldoMensual money not null,
TRA_descuentoAFP float check(TRA_descuentoAFP<1 and TRA_descuentoAFP>0 )
)



--tabla USUARIOS
create table USUARIOS(
USU_codigo varchar(200) primary key,
TRA_codigo int references TRABAJADORES(TRA_codigo),
TRA_contraseña varchar(200) not null,

)
-- tabla REGISTROS
create table REGISTROS(
REG_codigo int primary key identity(1,1),
TRA_codigo int references TRABAJADORES(TRA_codigo),
REG_horaEntrada tinyint not null check(REG_horaEntrada<24),
REG_horaSalida tinyint not null check(REG_horaSalida<24),
REG_fecha date not null default(getdate())
)
-- tabla HORARIO
create table HORARIOS(
HOR_codigo int primary key identity(1,1),
TRA_codigo int references TRABAJADORES(TRA_codigo)
)
-- tabla TURNOS
create table TURNOS(
TUR_codigo int primary key identity(1,1),
TUR_turno varchar(50) not null check(TUR_turno='Mañana' or TUR_turno='Tarde' or TUR_turno='Noche') default('Mañana'),
TUR_horaInicio tinyint not null check(TUR_horaInicio<=24 and(TUR_horaInicio=8 or TUR_horaInicio=16 or TUR_horaInicio=24)),
TUR_horaFinal tinyint not null check(TUR_horaFinal<=24 and(TUR_horaFinal=16 or TUR_horaFinal=24 or TUR_horaFinal=8))

)

-- tabla DETALLE_HORARIOS
create table DETALLE_HORARIOS(
HOR_codigo int references HORARIOS(HOR_codigo),
TUR_codigo int references TURNOS(TUR_codigo),
DHO_dia varchar(50) not null
)
--tabla HORAS_EXTRAS
create table HORAS_EXTRAS(
HEX_codigo int primary key identity(1,1),
TRA_codigo int references TRABAJADORES(TRA_codigo),
HEX_fecha date not null default(getdate()),
HEX_horaEntrada tinyint not null,
HEX_horaSalida tinyint not null,
HEX_totalHoras tinyint not null
)
--tabla TAREAS
create table TAREAS(
TAR_codigo int primary key identity(1,1),
TAR_nombre varchar(200) not null,
TAR_descripcion text
)

-- tabla RESOLUCIONES
create table RESOLUCIONES(
RES_codigo int primary key identity(1,1),
HEX_codigo int references HORAS_EXTRAS(HEX_codigo),
TAR_codigo int references TAREAS(TAR_codigo)
)