USE [master]
GO

CREATE DATABASE [RRHH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RRHH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RRHH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RRHH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RRHH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RRHH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RRHH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RRHH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RRHH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RRHH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RRHH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RRHH] SET ARITHABORT OFF 
GO
ALTER DATABASE [RRHH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RRHH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RRHH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RRHH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RRHH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RRHH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RRHH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RRHH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RRHH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RRHH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RRHH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RRHH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RRHH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RRHH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RRHH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RRHH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RRHH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RRHH] SET RECOVERY FULL 
GO
ALTER DATABASE [RRHH] SET  MULTI_USER 
GO
ALTER DATABASE [RRHH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RRHH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RRHH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RRHH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RRHH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RRHH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RRHH', N'ON'
GO
ALTER DATABASE [RRHH] SET QUERY_STORE = OFF
GO
USE [RRHH]
GO
/****** Object:  Table [dbo].[Candidatos]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidatos](
	[IdCandidato] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[PuestoAspira] [int] NOT NULL,
	[Departamento] [varchar](50) NULL,
	[SalarioAspira] [money] NULL,
	[Competencias] [int] NULL,
	[Capacitaciones] [int] NULL,
	[ExperinciaLab] [int] NOT NULL,
	[Recomendacion] [varchar](50) NULL,
	[Idioma] [int] NULL,
 CONSTRAINT [PK_Candidatos] PRIMARY KEY CLUSTERED 
(
	[IdCandidato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Capacitaciones]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Capacitaciones](
	[IdCapacitacion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Nivel] [varchar](50) NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL,
	[Institucion] [varchar](50) NULL,
 CONSTRAINT [PK_Capacitaciones] PRIMARY KEY CLUSTERED 
(
	[IdCapacitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competencias]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competencias](
	[IdCompetencia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Competencias] PRIMARY KEY CLUSTERED 
(
	[IdCompetencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](50) NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaIngreso] [date] NULL,
	[area] [varchar](50) NULL,
	[Puesto] [varchar](50) NOT NULL,
	[SalarioMensual] [money] NULL,
	[Disponibilidad] [varchar](50) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExperienciaLaboral]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExperienciaLaboral](
	[IdExperienciaLab] [int] IDENTITY(1,1) NOT NULL,
	[Empresa] [varchar](50) NULL,
	[Puesto] [varchar](50) NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL,
	[Salario] [money] NULL,
 CONSTRAINT [PK_ExperienciaLaboral] PRIMARY KEY CLUSTERED 
(
	[IdExperienciaLab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[IdIdioma] [int] IDENTITY(1,1) NOT NULL,
	[idioma] [varchar](20) NULL,
	[Disponibilidad] [varchar](50) NULL,
 CONSTRAINT [PK_Idiomas] PRIMARY KEY CLUSTERED 
(
	[IdIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[IdPuesto] [int] IDENTITY(1,1) NOT NULL,
	[Ocupacion] [varchar](50) NULL,
	[Riesgo] [varchar](50) NULL,
	[SalarioMinimo] [money] NULL,
	[SalarioMaximo] [money] NULL,
	[Idioma] [int] NOT NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[IdPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Cuenta] [varchar](50) NULL,
	[Contrasena] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidatos] ON 

INSERT [dbo].[Candidatos] ([IdCandidato], [Cedula], [Nombre], [PuestoAspira], [Departamento], [SalarioAspira], [Competencias], [Capacitaciones], [ExperinciaLab], [Recomendacion], [Idioma]) VALUES (63, N'00118958081', N'Amaurys Cabrera', 12, N'TI', 60000.0000, 8, 5, 1, N'Andres Pineda', 1)
SET IDENTITY_INSERT [dbo].[Candidatos] OFF
GO
SET IDENTITY_INSERT [dbo].[Capacitaciones] ON 

INSERT [dbo].[Capacitaciones] ([IdCapacitacion], [Descripcion], [Nivel], [FechaDesde], [FechaHasta], [Institucion]) VALUES (5, N'Aseguramiento De la calidad', N'Post-Grado', CAST(N'2022-10-09' AS Date), CAST(N'2022-11-09' AS Date), N'Canadian Collage')
INSERT [dbo].[Capacitaciones] ([IdCapacitacion], [Descripcion], [Nivel], [FechaDesde], [FechaHasta], [Institucion]) VALUES (6, N'Administracion de base de datos', N'Grado', CAST(N'2022-10-09' AS Date), CAST(N'2022-11-11' AS Date), N'Unapec')
INSERT [dbo].[Capacitaciones] ([IdCapacitacion], [Descripcion], [Nivel], [FechaDesde], [FechaHasta], [Institucion]) VALUES (7, N'PHP', N'Tecnico', CAST(N'2022-10-09' AS Date), CAST(N'2022-11-10' AS Date), N'ITLA')
INSERT [dbo].[Capacitaciones] ([IdCapacitacion], [Descripcion], [Nivel], [FechaDesde], [FechaHasta], [Institucion]) VALUES (8, N'Scrum Master', N'Tecnico', CAST(N'2022-10-09' AS Date), CAST(N'2022-10-19' AS Date), N'Infotep')
INSERT [dbo].[Capacitaciones] ([IdCapacitacion], [Descripcion], [Nivel], [FechaDesde], [FechaHasta], [Institucion]) VALUES (9, N'Dearrollo Web NET CORE', N'Tecnico', CAST(N'2022-10-09' AS Date), CAST(N'2022-11-08' AS Date), N'unapec')
SET IDENTITY_INSERT [dbo].[Capacitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Competencias] ON 

INSERT [dbo].[Competencias] ([IdCompetencia], [Descripcion], [Estado]) VALUES (8, N'Capacidad de Aprendizaje', N'Disponible')
INSERT [dbo].[Competencias] ([IdCompetencia], [Descripcion], [Estado]) VALUES (9, N'Responsabilidad', N'Disponible')
INSERT [dbo].[Competencias] ([IdCompetencia], [Descripcion], [Estado]) VALUES (10, N'Comunicacion ', N'Disponible')
INSERT [dbo].[Competencias] ([IdCompetencia], [Descripcion], [Estado]) VALUES (11, N'Trabajo en equipo', N'Disponible')
INSERT [dbo].[Competencias] ([IdCompetencia], [Descripcion], [Estado]) VALUES (12, N'Flexibilidad y Adaptacion', N'Disponible')
INSERT [dbo].[Competencias] ([IdCompetencia], [Descripcion], [Estado]) VALUES (13, N'Iniciativa', N'Disponible')
SET IDENTITY_INSERT [dbo].[Competencias] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([IdEmpleado], [Identificacion], [Nombre], [FechaIngreso], [area], [Puesto], [SalarioMensual], [Disponibilidad]) VALUES (24, N'00110641461', N'Alex Valera', CAST(N'2022-10-06' AS Date), N'TI', N'Administrador de Base de datos', 60000.0000, N'Activo ')
INSERT [dbo].[Empleados] ([IdEmpleado], [Identificacion], [Nombre], [FechaIngreso], [area], [Puesto], [SalarioMensual], [Disponibilidad]) VALUES (25, N'40214583532', N'Juan Valdez', CAST(N'2022-10-02' AS Date), N'TI', N'Programador PHP', 75000.0000, N'Activo ')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[ExperienciaLaboral] ON 

INSERT [dbo].[ExperienciaLaboral] ([IdExperienciaLab], [Empresa], [Puesto], [FechaDesde], [FechaHasta], [Salario]) VALUES (1, N'Altice', N'Administrador DBA', CAST(N'2022-08-29' AS Date), CAST(N'2022-08-29' AS Date), 15000.0000)
INSERT [dbo].[ExperienciaLaboral] ([IdExperienciaLab], [Empresa], [Puesto], [FechaDesde], [FechaHasta], [Salario]) VALUES (9, N'Solvex', N'Programador', CAST(N'2022-09-08' AS Date), CAST(N'2022-09-07' AS Date), 600000.0000)
INSERT [dbo].[ExperienciaLaboral] ([IdExperienciaLab], [Empresa], [Puesto], [FechaDesde], [FechaHasta], [Salario]) VALUES (10, N'Edeteam ed', N'maestro', CAST(N'2022-09-20' AS Date), CAST(N'2022-09-20' AS Date), 70000.0000)
INSERT [dbo].[ExperienciaLaboral] ([IdExperienciaLab], [Empresa], [Puesto], [FechaDesde], [FechaHasta], [Salario]) VALUES (12, N'Unapec', N'Mayordomo', CAST(N'2022-10-20' AS Date), CAST(N'2022-10-20' AS Date), 60000.0000)
INSERT [dbo].[ExperienciaLaboral] ([IdExperienciaLab], [Empresa], [Puesto], [FechaDesde], [FechaHasta], [Salario]) VALUES (13, N'Jerry Valera', N'Plomero', CAST(N'2022-01-01' AS Date), CAST(N'2022-10-06' AS Date), 45000.0000)
INSERT [dbo].[ExperienciaLaboral] ([IdExperienciaLab], [Empresa], [Puesto], [FechaDesde], [FechaHasta], [Salario]) VALUES (14, N'Utree', N'QA', CAST(N'2022-10-11' AS Date), CAST(N'2022-10-11' AS Date), 60000.0000)
SET IDENTITY_INSERT [dbo].[ExperienciaLaboral] OFF
GO
SET IDENTITY_INSERT [dbo].[Idiomas] ON 

INSERT [dbo].[Idiomas] ([IdIdioma], [idioma], [Disponibilidad]) VALUES (1, N'Ingles', N'Disponible')
INSERT [dbo].[Idiomas] ([IdIdioma], [idioma], [Disponibilidad]) VALUES (5, N'Frances', N'Disponible')
INSERT [dbo].[Idiomas] ([IdIdioma], [idioma], [Disponibilidad]) VALUES (6, N'Ruso', N'Disponible')
SET IDENTITY_INSERT [dbo].[Idiomas] OFF
GO
SET IDENTITY_INSERT [dbo].[Puestos] ON 

INSERT [dbo].[Puestos] ([IdPuesto], [Ocupacion], [Riesgo], [SalarioMinimo], [SalarioMaximo], [Idioma], [Estado]) VALUES (11, N'Administrador de Base de datos', N'Medio', 45000.0000, 60000.0000, 1, N'Disponible')
INSERT [dbo].[Puestos] ([IdPuesto], [Ocupacion], [Riesgo], [SalarioMinimo], [SalarioMaximo], [Idioma], [Estado]) VALUES (12, N'Desarrolldor Wep', N'Alto', 45000.0000, 70000.0000, 1, N'Disponible')
INSERT [dbo].[Puestos] ([IdPuesto], [Ocupacion], [Riesgo], [SalarioMinimo], [SalarioMaximo], [Idioma], [Estado]) VALUES (13, N'QA', N'Alto', 45000.0000, 60000.0000, 1, N'Disponible')
INSERT [dbo].[Puestos] ([IdPuesto], [Ocupacion], [Riesgo], [SalarioMinimo], [SalarioMaximo], [Idioma], [Estado]) VALUES (14, N'Programador PHP', N'Alto', 60000.0000, 85000.0000, 1, N'Disponible')
INSERT [dbo].[Puestos] ([IdPuesto], [Ocupacion], [Riesgo], [SalarioMinimo], [SalarioMaximo], [Idioma], [Estado]) VALUES (15, N'Analista de sistema', N'Alto', 45000.0000, 35000.0000, 1, N'Disponible')
SET IDENTITY_INSERT [dbo].[Puestos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Cuenta], [Contrasena], [Rol]) VALUES (23, N'Juan Valdez', N'Goku777', N'Admin')
INSERT [dbo].[Usuarios] ([IdUsuario], [Cuenta], [Contrasena], [Rol]) VALUES (24, N'Alex Valera', N'Vegueta777', N'Consultor')
INSERT [dbo].[Usuarios] ([IdUsuario], [Cuenta], [Contrasena], [Rol]) VALUES (32, N'Maria BB', N'Boo123', N'Consultor')
INSERT [dbo].[Usuarios] ([IdUsuario], [Cuenta], [Contrasena], [Rol]) VALUES (35, N'Jorge Perez', N'1234', N'Admin')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Candidatos]  WITH CHECK ADD  CONSTRAINT [FK_Candidatos_Capacitaciones] FOREIGN KEY([Capacitaciones])
REFERENCES [dbo].[Capacitaciones] ([IdCapacitacion])
GO
ALTER TABLE [dbo].[Candidatos] CHECK CONSTRAINT [FK_Candidatos_Capacitaciones]
GO
ALTER TABLE [dbo].[Candidatos]  WITH CHECK ADD  CONSTRAINT [FK_Candidatos_Competencias] FOREIGN KEY([Competencias])
REFERENCES [dbo].[Competencias] ([IdCompetencia])
GO
ALTER TABLE [dbo].[Candidatos] CHECK CONSTRAINT [FK_Candidatos_Competencias]
GO
ALTER TABLE [dbo].[Candidatos]  WITH CHECK ADD  CONSTRAINT [FK_Candidatos_ExperienciaLaboral] FOREIGN KEY([ExperinciaLab])
REFERENCES [dbo].[ExperienciaLaboral] ([IdExperienciaLab])
GO
ALTER TABLE [dbo].[Candidatos] CHECK CONSTRAINT [FK_Candidatos_ExperienciaLaboral]
GO
ALTER TABLE [dbo].[Candidatos]  WITH CHECK ADD  CONSTRAINT [FK_Candidatos_Idiomas] FOREIGN KEY([Idioma])
REFERENCES [dbo].[Idiomas] ([IdIdioma])
GO
ALTER TABLE [dbo].[Candidatos] CHECK CONSTRAINT [FK_Candidatos_Idiomas]
GO
ALTER TABLE [dbo].[Candidatos]  WITH CHECK ADD  CONSTRAINT [FK_Candidatos_Puestos1] FOREIGN KEY([PuestoAspira])
REFERENCES [dbo].[Puestos] ([IdPuesto])
GO
ALTER TABLE [dbo].[Candidatos] CHECK CONSTRAINT [FK_Candidatos_Puestos1]
GO
ALTER TABLE [dbo].[Puestos]  WITH CHECK ADD  CONSTRAINT [FK_Puestos_Idiomas1] FOREIGN KEY([Idioma])
REFERENCES [dbo].[Idiomas] ([IdIdioma])
GO
ALTER TABLE [dbo].[Puestos] CHECK CONSTRAINT [FK_Puestos_Idiomas1]
GO
/****** Object:  StoredProcedure [dbo].[EditarCan]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EditarCan]
@IdCandidato int,
@Cedula Varchar(50),
@Nombre Varchar(50),
@Puesto int,
@Departamento Varchar(50),
@SalarioAspira float,
@Competencias int,
@Capacitaciones int,
@ExperienciaLab int,
@Idioma int,
@Recomendacion varchar(50)
as
UPDATE Candidatos SET Cedula=@Cedula,Nombre=@Nombre,PuestoAspira=@Puesto,Departamento=@Departamento,
Competencias=@Competencias,Capacitaciones=@Capacitaciones,ExperinciaLab=@ExperienciaLab,
Recomendacion=@Recomendacion,Idioma=@Idioma where IdCandidato=@IdCandidato
GO
/****** Object:  StoredProcedure [dbo].[EditarCapacitaciones]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EditarCapacitaciones]
@IdCapacitacion int,
@Descripcion Varchar(50),
@Nivel Varchar(50),
@FechaDesde date,
@FechaHasta date,
@Institucion Varchar(50)
as
UPDATE Capacitaciones SET Descripcion=@Descripcion,Nivel=@Nivel,FechaDesde=@FechaDesde,
@FechaHasta=@FechaHasta,Institucion=@Institucion Where IdCapacitacion=@IdCapacitacion
GO
/****** Object:  StoredProcedure [dbo].[EditarComp]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EditarComp]
@IdCompetencia int,
@Descripcion Varchar(50),
@Estado Varchar(50)
as
UPDATE Competencias SET Descripcion=@Descripcion,Estado=@Estado WHERE IdCompetencia=@IdCompetencia
GO
/****** Object:  StoredProcedure [dbo].[EditarExp]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditarExp]
@IdExperienciaLab int,
@Empresa varchar(50),
@Puesto varchar(50),
@FechaDesde Date,
@FechaHasta Date,
@Salario float
as
UPDATE ExperienciaLaboral SET Puesto=@Puesto,Empresa = @Empresa,
FechaDesde=@FechaDesde,FechaHasta=@FechaHasta,
Salario=@Salario WHERE IdExperienciaLab=@IdExperienciaLab
GO
/****** Object:  StoredProcedure [dbo].[Editaridiomas]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Editaridiomas]
@IdIdioma int,
@Nombre Varchar(50),
@Estado Varchar(50)
as
UPDATE Idiomas SET Nombre=@Nombre,Estado=@Estado WHERE IdIdioma=@IdIdioma
GO
/****** Object:  StoredProcedure [dbo].[Editarpuesto]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Editarpuesto]
@IdPuesto int,
@Nombre Varchar(50),
@Riesgo Varchar(50),
@SalarioMinimo float,
@SalarioMaximo float,
@Estado Varchar(50)
as
UPDATE Puestos SET Nombre=@Nombre,Riesgo=@Riesgo,SalarioMinimo=@SalarioMinimo,
SalarioMaximo=@SalarioMaximo,Estado=@Estado WHERE IdPuesto=@IdPuesto
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuarios]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarUsuarios]
@Cuenta nvarchar (50),
@Contrasena nvarchar (50),
@Rol nvarchar (50),
@IdUsuario int
as
update Usuarios set Cuenta=@Cuenta, Contrasena=@Contrasena, Rol=@Rol where IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[EliminarCan]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EliminarCan]
@IdCandidato int
as
DELETE FROM Candidatos WHERE IdCandidato=@IdCandidato
GO
/****** Object:  StoredProcedure [dbo].[EliminarCapacitaciones]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EliminarCapacitaciones]
@IdCapacitacion int
as
DELETE FROM Capacitaciones WHERE IdCapacitacion=@IdCapacitacion
GO
/****** Object:  StoredProcedure [dbo].[EliminarComp]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EliminarComp]
@IdCompetencia int
as
DELETE FROM Competencias WHERE IdCompetencia=@IdCompetencia
GO
/****** Object:  StoredProcedure [dbo].[EliminarExperiencia]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EliminarExperiencia]
@IdExperienciaLab int
as
DELETE FROM ExperienciaLaboral WHERE IdExperienciaLab=@IdExperienciaLab
GO
/****** Object:  StoredProcedure [dbo].[EliminarIdioma]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EliminarIdioma]
@IdIdioma int
as
DELETE FROM Idiomas WHERE IdIdioma=@IdIdioma
GO
/****** Object:  StoredProcedure [dbo].[Eliminarpuesto]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Eliminarpuesto]
@IdPuesto int
as
DELETE FROM Puestos WHERE IdPuesto=@IdPuesto
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------ELIMINAR
create proc [dbo].[EliminarUsuario]
@IdUsuario int
as
delete from Usuarios where IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[InsertarCan]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[InsertarCan]
@Cedula Varchar(50),
@Nombre Varchar(50),
@PuestoAspira float,
@Departamento Varchar(50),
@SalarioAspira float,
@Competencias int,
@Capacitaciones int,
@ExperinciaLab int,
@Recomendacion varchar(50),
@Idioma int
as
INSERT INTO Candidatos VALUES(@Cedula,@Nombre,@PuestoAspira,@Departamento,@SalarioAspira,
@Competencias,@Capacitaciones,@ExperinciaLab,@Recomendacion,@Idioma)
GO
/****** Object:  StoredProcedure [dbo].[InsertarCapacitaciones]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[InsertarCapacitaciones]
@Descripcion Varchar(50),
@Nivel Varchar(50),
@FechaDesde date,
@FechaHasta date,
@Institucion Varchar(50)
as
INSERT INTO Capacitaciones VALUES (@Descripcion,@Nivel,@FechaDesde,@FechaHasta,@Institucion)
GO
/****** Object:  StoredProcedure [dbo].[InsertarComp]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[InsertarComp]
@Descripcion Varchar(50),
@Estado Varchar(50)
as
INSERT INTO Competencias VALUES (@Descripcion,@Estado)
GO
/****** Object:  StoredProcedure [dbo].[InsertarExperiencias]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarExperiencias]
@Empresa varchar(50),
@Puesto varchar(50),
@FechaDesde Date,
@FechaHasta Date,
@Salario float
as
INSERT INTO ExperienciaLaboral VALUES (@Empresa,@Puesto,@FechaDesde,@FechaDesde,@Salario)
GO
/****** Object:  StoredProcedure [dbo].[Insertaridiomas]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Insertaridiomas]
@idioma Varchar(50),
@Disponibilidad Varchar(50)

as
INSERT INTO Idiomas VALUES (@idioma,@Disponibilidad)
GO
/****** Object:  StoredProcedure [dbo].[Insertarpuesto]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Insertarpuesto]
@Ocupacion Varchar(50),
@Riesgo Varchar(50),
@SalarioMinimo float,
@SalarioMaximo float,
@Idioma int,
@Estado Varchar(50)
as
INSERT INTO Puestos VALUES (@Ocupacion,@Riesgo,@SalarioMinimo,@SalarioMaximo,@Idioma,
@Estado
)
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuarios]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarUsuarios]
@Cuenta nvarchar (50),
@Contrasena nvarchar (50),
@Rol nvarchar (50)
as
insert into Usuarios values (@Cuenta,@Contrasena,@Rol)
GO
/****** Object:  StoredProcedure [dbo].[ListarCandidatos]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarCandidatos]
as
SELECT IdCandidato as ID,Cedula as cédula,Nombre,Puestos.Ocupacion as Puesto,Departamento,SalarioAspira,
Competencias.Descripcion as Competencias,Capacitaciones.Descripcion	as Capacitacion,ExperienciaLaboral.Puesto as Experiencia,Recomendacion,Idiomas.idioma as Idioma FROM Candidatos

INNER JOIN Puestos ON Candidatos.PuestoAspira = Puestos.IdPuesto
INNER JOIN Competencias ON Candidatos.Competencias = Competencias.IdCompetencia
INNER JOIN Capacitaciones ON Candidatos.Capacitaciones = Capacitaciones.IdCapacitacion
INNER JOIN ExperienciaLaboral ON Candidatos.ExperinciaLab = ExperienciaLaboral.IdExperienciaLab
INNER JOIN Idiomas ON Candidatos.Idioma = Idiomas.IdIdioma
GO
/****** Object:  StoredProcedure [dbo].[ListarCapacitaciones]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarCapacitaciones]
as
select IdCapacitacion as ID,Descripcion as Descripción,Nivel,FechaDesde AS Desde,FechaHasta AS 
Hasta ,Institucion  AS Institución from Capacitaciones
GO
/****** Object:  StoredProcedure [dbo].[ListarComp]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarComp]
as
select IdCompetencia as ID,Descripcion as Descripción,Estado from Competencias
GO
/****** Object:  StoredProcedure [dbo].[Listaridioma]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Listaridioma]
as
select IdIdioma AS ID,idioma AS Descripción ,Disponibilidad as Estado from Idiomas
GO
/****** Object:  StoredProcedure [dbo].[ListarPuesto]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarPuesto]
as
SELECT IdPuesto AS ID,Ocupacion AS Ocupación,Riesgo,SalarioMinimo,SalarioMaximo,Idiomas.idioma as Idioma,
Estado FROM Puestos

INNER JOIN Idiomas ON Puestos.Idioma = Idiomas.IdIdioma
GO
/****** Object:  StoredProcedure [dbo].[MostrarEmpleados]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarEmpleados]
as
SELECT IdEmpleado AS ID,Identificacion AS Cédula,Nombre,
FechaIngreso As Ingreso,area AS Departamento,Puesto,
SalarioMensual AS Salario, Disponibilidad AS Estado From Empleados 
GO
/****** Object:  StoredProcedure [dbo].[MostrarExperiencias]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[MostrarExperiencias]
as
SELECT IdExperienciaLab as ID ,Empresa,Puesto,FechaDesde,FechaHasta,Salario FROM ExperienciaLaboral
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuaios]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarUsuaios]
as
select *from Usuarios
GO
/****** Object:  StoredProcedure [dbo].[reportes]    Script Date: 10/25/2022 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[reportes](
@Fecha1 date,
@Fecha2 date
)
as
BEGIN
SELECT IdEmpleado AS ID,Identificacion as Cedula,Nombre,
FechaIngreso as Ingreso,area as Departamento,Puesto,SalarioMensual as Salario,
Disponibilidad as Estado FROM Empleados WHERE FechaIngreso between @Fecha1 and @Fecha2
end
GO
USE [master]
GO
ALTER DATABASE [RRHH] SET  READ_WRITE 
GO
