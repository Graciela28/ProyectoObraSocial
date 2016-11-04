USE [master]
GO
/****** Object:  Database [obrasocial2]    Script Date: 4/11/2016 3:30:22 p. m. ******/
CREATE DATABASE [obrasocial2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'obrasocial2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\obrasocial2.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'obrasocial2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\obrasocial2_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [obrasocial2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [obrasocial2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [obrasocial2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [obrasocial2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [obrasocial2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [obrasocial2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [obrasocial2] SET ARITHABORT OFF 
GO
ALTER DATABASE [obrasocial2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [obrasocial2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [obrasocial2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [obrasocial2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [obrasocial2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [obrasocial2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [obrasocial2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [obrasocial2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [obrasocial2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [obrasocial2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [obrasocial2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [obrasocial2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [obrasocial2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [obrasocial2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [obrasocial2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [obrasocial2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [obrasocial2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [obrasocial2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [obrasocial2] SET  MULTI_USER 
GO
ALTER DATABASE [obrasocial2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [obrasocial2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [obrasocial2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [obrasocial2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [obrasocial2] SET DELAYED_DURABILITY = DISABLED 
GO
USE [obrasocial2]
GO
/****** Object:  Table [dbo].[Afiliados]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Afiliados](
	[id_tipo_doc] [int] NOT NULL,
	[numero_doc] [int] NOT NULL,
	[id_tipo_afil] [int] NOT NULL,
	[activo] [bit] NOT NULL,
	[empresa_convenio] [nvarchar](100) NULL,
 CONSTRAINT [PK_Afiliados_tipodoc_nrodoc] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC,
	[numero_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Atenciones]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atenciones](
	[fecha_atencion] [date] NOT NULL,
	[tipo_doc_Afil] [int] NOT NULL,
	[nro_doc_Afil] [int] NOT NULL,
	[id_centro] [int] NOT NULL,
	[matricula] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[estado] [int] NOT NULL,
	[total_sc] [float] NOT NULL,
	[total_cc] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_Atenciones_fechaAtencion_tipoDocAfil_nroDocAfil_idCentro_matriculaProf_idEspecialidad_fechaAltaProf] PRIMARY KEY CLUSTERED 
(
	[fecha_atencion] ASC,
	[tipo_doc_Afil] ASC,
	[nro_doc_Afil] ASC,
	[id_centro] ASC,
	[matricula] ASC,
	[id_especialidad] ASC,
	[fecha_alta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[id_localidad] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CentrosMedicos]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CentrosMedicos](
	[id_centro] [int] NOT NULL,
	[denominacion] [nvarchar](50) NOT NULL,
	[id_domicilio] [int] NOT NULL,
	[telefono] [bigint] NULL,
	[mail] [nvarchar](100) NULL,
	[esPropio] [bit] NOT NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_centro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Coberturas]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coberturas](
	[id_tipo_afiliado] [int] NOT NULL,
	[id_practica] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[id_centro] [int] NOT NULL,
	[descripcion] [nvarchar](1000) NULL,
	[precio_practica] [float] NOT NULL,
	[porcentaje_cobertura] [int] NOT NULL,
 CONSTRAINT [PK_Coberturas_tipoAfil_idPractica_idEspec_idCentro] PRIMARY KEY CLUSTERED 
(
	[id_tipo_afiliado] ASC,
	[id_practica] ASC,
	[id_especialidad] ASC,
	[id_centro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetallesAtencion]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesAtencion](
	[fecha_atencion] [date] NOT NULL,
	[tipo_doc_Afil] [int] NOT NULL,
	[nro_doc_Afil] [int] NOT NULL,
	[id_centro] [int] NOT NULL,
	[matricula] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[id_practica] [int] NOT NULL,
	[precio_practica_sc] [float] NOT NULL,
	[cobertura] [int] NOT NULL,
	[precio_practica_cc] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK_DetallesAtencion_fechaAtencion_tipoDocAfil_nroDocAfil_idCentro_matricula_idEspecialidad_fechaAlta_codPractica] PRIMARY KEY CLUSTERED 
(
	[fecha_atencion] ASC,
	[tipo_doc_Afil] ASC,
	[nro_doc_Afil] ASC,
	[id_centro] ASC,
	[matricula] ASC,
	[id_especialidad] ASC,
	[fecha_alta] ASC,
	[id_practica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Domicilios]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilios](
	[id_domicilio] [int] NOT NULL,
	[calle] [nvarchar](100) NOT NULL,
	[numero] [int] NULL,
	[id_barrio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EstadosAtencion]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosAtencion](
	[id_estado] [int] NOT NULL,
	[n_estado] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[id] [bigint] NOT NULL,
	[id_provincia] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personas]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[id_tipo_doc] [int] NOT NULL,
	[numero_doc] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[direccion] [int] NOT NULL,
	[telefono] [bigint] NULL,
	[mail] [nvarchar](100) NULL,
 CONSTRAINT [PK_Personas_tipodoc_nrodoc] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC,
	[numero_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Practicas]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Practicas](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PracticasxEspecialidad]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PracticasxEspecialidad](
	[id_especialidad] [int] NOT NULL,
	[id_practica] [int] NOT NULL,
	[fecha_alta] [datetime] NOT NULL,
	[fecha_baja] [datetime] NULL,
 CONSTRAINT [PK_PracticasxEspecialidad_idpractica_idespecialidad] PRIMARY KEY CLUSTERED 
(
	[id_practica] ASC,
	[id_especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesionales]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesionales](
	[matricula] [int] NOT NULL,
	[id_tipo_doc] [int] NOT NULL,
	[numero_doc] [int] NOT NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfesionalesxCentro]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfesionalesxCentro](
	[matricula] [int] NOT NULL,
	[id_centro] [int] NOT NULL,
 CONSTRAINT [PK_ProfesionalesxCentro_matricula_idCentro] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC,
	[id_centro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfesionalesxCentroxEspecialidad]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfesionalesxCentroxEspecialidad](
	[id_centro] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[matricula] [int] NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_ProfesionalesxCentroxEspecialidad_idCentro_idEsp_matricula_fechaAlta] PRIMARY KEY CLUSTERED 
(
	[id_centro] ASC,
	[id_especialidad] ASC,
	[matricula] ASC,
	[fecha_alta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TiposAfiliado]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposAfiliado](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TiposDocumento]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDocumento](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Afiliados]  WITH CHECK ADD  CONSTRAINT [FK_Afiliados_tipoAfiliado] FOREIGN KEY([id_tipo_afil])
REFERENCES [dbo].[TiposAfiliado] ([id])
GO
ALTER TABLE [dbo].[Afiliados] CHECK CONSTRAINT [FK_Afiliados_tipoAfiliado]
GO
ALTER TABLE [dbo].[Atenciones]  WITH CHECK ADD  CONSTRAINT [FK_Atenciones_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[EstadosAtencion] ([id_estado])
GO
ALTER TABLE [dbo].[Atenciones] CHECK CONSTRAINT [FK_Atenciones_estado]
GO
ALTER TABLE [dbo].[Atenciones]  WITH CHECK ADD  CONSTRAINT [FK_Atenciones_idCentro_matricula_idEspecialidad_fechaAlta] FOREIGN KEY([id_centro], [id_especialidad], [matricula], [fecha_alta])
REFERENCES [dbo].[ProfesionalesxCentroxEspecialidad] ([id_centro], [id_especialidad], [matricula], [fecha_alta])
GO
ALTER TABLE [dbo].[Atenciones] CHECK CONSTRAINT [FK_Atenciones_idCentro_matricula_idEspecialidad_fechaAlta]
GO
ALTER TABLE [dbo].[Atenciones]  WITH CHECK ADD  CONSTRAINT [FK_Atenciones_tipoDocAfil_nroDocAfil] FOREIGN KEY([tipo_doc_Afil], [nro_doc_Afil])
REFERENCES [dbo].[Afiliados] ([id_tipo_doc], [numero_doc])
GO
ALTER TABLE [dbo].[Atenciones] CHECK CONSTRAINT [FK_Atenciones_tipoDocAfil_nroDocAfil]
GO
ALTER TABLE [dbo].[Barrios]  WITH CHECK ADD  CONSTRAINT [FK_barrios_id_localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidades] ([id])
GO
ALTER TABLE [dbo].[Barrios] CHECK CONSTRAINT [FK_barrios_id_localidad]
GO
ALTER TABLE [dbo].[CentrosMedicos]  WITH CHECK ADD  CONSTRAINT [FK_CentrosMedicos_domicilio] FOREIGN KEY([id_domicilio])
REFERENCES [dbo].[Domicilios] ([id_domicilio])
GO
ALTER TABLE [dbo].[CentrosMedicos] CHECK CONSTRAINT [FK_CentrosMedicos_domicilio]
GO
ALTER TABLE [dbo].[Coberturas]  WITH CHECK ADD  CONSTRAINT [FK_Coberturas_idCentro] FOREIGN KEY([id_centro])
REFERENCES [dbo].[CentrosMedicos] ([id_centro])
GO
ALTER TABLE [dbo].[Coberturas] CHECK CONSTRAINT [FK_Coberturas_idCentro]
GO
ALTER TABLE [dbo].[Coberturas]  WITH CHECK ADD  CONSTRAINT [FK_Coberturas_idPractica_idEspecialidad] FOREIGN KEY([id_practica], [id_especialidad])
REFERENCES [dbo].[PracticasxEspecialidad] ([id_practica], [id_especialidad])
GO
ALTER TABLE [dbo].[Coberturas] CHECK CONSTRAINT [FK_Coberturas_idPractica_idEspecialidad]
GO
ALTER TABLE [dbo].[Coberturas]  WITH CHECK ADD  CONSTRAINT [FK_Coberturas_tipoAfiliado] FOREIGN KEY([id_tipo_afiliado])
REFERENCES [dbo].[TiposAfiliado] ([id])
GO
ALTER TABLE [dbo].[Coberturas] CHECK CONSTRAINT [FK_Coberturas_tipoAfiliado]
GO
ALTER TABLE [dbo].[DetallesAtencion]  WITH CHECK ADD  CONSTRAINT [FK_DetallesAtencion_fechaAtencion_tipoDocAfil_nroDocAfil_idCentro_matriculaProf_idEspecialidad_fechaAlta] FOREIGN KEY([fecha_atencion], [tipo_doc_Afil], [nro_doc_Afil], [id_centro], [matricula], [id_especialidad], [fecha_alta])
REFERENCES [dbo].[Atenciones] ([fecha_atencion], [tipo_doc_Afil], [nro_doc_Afil], [id_centro], [matricula], [id_especialidad], [fecha_alta])
GO
ALTER TABLE [dbo].[DetallesAtencion] CHECK CONSTRAINT [FK_DetallesAtencion_fechaAtencion_tipoDocAfil_nroDocAfil_idCentro_matriculaProf_idEspecialidad_fechaAlta]
GO
ALTER TABLE [dbo].[DetallesAtencion]  WITH CHECK ADD  CONSTRAINT [FK_DetallesAtencion_idPractica] FOREIGN KEY([id_practica])
REFERENCES [dbo].[Practicas] ([id])
GO
ALTER TABLE [dbo].[DetallesAtencion] CHECK CONSTRAINT [FK_DetallesAtencion_idPractica]
GO
ALTER TABLE [dbo].[Domicilios]  WITH CHECK ADD  CONSTRAINT [FK_domicilios_id_barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Domicilios] CHECK CONSTRAINT [FK_domicilios_id_barrio]
GO
ALTER TABLE [dbo].[Localidades]  WITH CHECK ADD  CONSTRAINT [FK_Localidades_idProvincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincias] ([id])
GO
ALTER TABLE [dbo].[Localidades] CHECK CONSTRAINT [FK_Localidades_idProvincia]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_direccion] FOREIGN KEY([direccion])
REFERENCES [dbo].[Domicilios] ([id_domicilio])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_direccion]
GO
ALTER TABLE [dbo].[PracticasxEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_PracticasxEspecialidad_idespecialidad] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[Especialidades] ([id])
GO
ALTER TABLE [dbo].[PracticasxEspecialidad] CHECK CONSTRAINT [FK_PracticasxEspecialidad_idespecialidad]
GO
ALTER TABLE [dbo].[PracticasxEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_PracticasxEspecialidad_idpractica] FOREIGN KEY([id_practica])
REFERENCES [dbo].[Practicas] ([id])
GO
ALTER TABLE [dbo].[PracticasxEspecialidad] CHECK CONSTRAINT [FK_PracticasxEspecialidad_idpractica]
GO
ALTER TABLE [dbo].[Profesionales]  WITH CHECK ADD  CONSTRAINT [FK_Profesionales_tipodoc_nrodoc] FOREIGN KEY([id_tipo_doc], [numero_doc])
REFERENCES [dbo].[Personas] ([id_tipo_doc], [numero_doc])
GO
ALTER TABLE [dbo].[Profesionales] CHECK CONSTRAINT [FK_Profesionales_tipodoc_nrodoc]
GO
ALTER TABLE [dbo].[ProfesionalesxCentroxEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_ProfesionalesxCentroxEspecialidad_idCentro_matricula] FOREIGN KEY([matricula], [id_centro])
REFERENCES [dbo].[ProfesionalesxCentro] ([matricula], [id_centro])
GO
ALTER TABLE [dbo].[ProfesionalesxCentroxEspecialidad] CHECK CONSTRAINT [FK_ProfesionalesxCentroxEspecialidad_idCentro_matricula]
GO
ALTER TABLE [dbo].[ProfesionalesxCentroxEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_ProfesionalesxCentroxEspecialidad_idEspecialidad] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[Especialidades] ([id])
GO
ALTER TABLE [dbo].[ProfesionalesxCentroxEspecialidad] CHECK CONSTRAINT [FK_ProfesionalesxCentroxEspecialidad_idEspecialidad]
GO
ALTER TABLE [dbo].[Afiliados]  WITH CHECK ADD CHECK  (([activo]=(1) OR [activo]=(0)))
GO
ALTER TABLE [dbo].[CentrosMedicos]  WITH CHECK ADD CHECK  (([activo]=(1) OR [activo]=(0)))
GO
ALTER TABLE [dbo].[Profesionales]  WITH CHECK ADD CHECK  (([activo]=(1) OR [activo]=(0)))
GO
/****** Object:  StoredProcedure [dbo].[stpro_consultar_profesional]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpro_consultar_profesional] 
(@documento int) as
begin 
select pro.matricula, 
p.id_tipo_doc, 
p.numero_doc, 
p.nombre, 
p.apellido, 
p.fecha_nacimiento, 
p.direccion, 
p.telefono, 
p.mail, 
d.calle, 
d.numero, 
d.id_barrio, 
b.id_localidad, 
prov.id,
pro.activo 
from 
Personas p inner join Profesionales pro
on p.id_tipo_doc = pro.id_tipo_doc 
and p.numero_doc = pro.numero_doc 
inner join Domicilios d
on p.direccion = d.id_domicilio  

inner join Barrios b 
on d.id_barrio = b.id_barrio
inner join Localidades l
on b.id_localidad = l.id
inner join Provincias prov
on l.id_provincia = prov.id 
where p.numero_doc = @documento
end

GO
/****** Object:  StoredProcedure [dbo].[stpro_eliminar_profesional]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stpro_eliminar_profesional]
(@numerodocumentoE int, @tipoDocumentoE int, @activo int) as

-- inicio del proceso
begin transaction 

update Profesionales
Set activo = @activo
where numero_doc = @numeroDocumentoE
and id_tipo_doc = @tipoDocumentoE
if @@ERROR <> 0
begin 
print 'Error al eliminar un registro en Profesionales'
rollback transaction 
return 
end 
commit transaction

GO
/****** Object:  StoredProcedure [dbo].[stpro_Insertar_Afiliado]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[stpro_Insertar_Afiliado]
(@tipoDocumento int, @numeroDocumento int,
@nombre varchar(50), @apellido varchar(50), @fechaNacimiento datetime,@activo int,@tipo_afil int  , @codDomicilio int, 
@calle varchar(50), @numero int, @barrio int, @telefono bigint, @mail varchar(50)) 
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION 

insert into Domicilios(id_domicilio, calle, numero, id_barrio) 
values(@codDomicilio, @calle, @numero, @barrio)

insert into Personas(id_tipo_doc, numero_doc, nombre, apellido, fecha_nacimiento,
direccion, telefono, mail)
values(@tipoDocumento, @numeroDocumento, @nombre, @apellido, @fechaNacimiento,
@codDomicilio, @telefono, @mail)

insert into Afiliados( id_tipo_doc, numero_doc,id_tipo_afil, activo)
values ( @tipoDocumento, @numeroDocumento,@tipo_afil, @activo)

COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[stpro_Insertar_CentroMedico]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stpro_Insertar_CentroMedico]
(@id_centro int, @denominacion varchar(50), @id_domicilio int, @telefono bigint, @mail varchar(100), @esPropio bit, @activo 
int, @calle varchar(100), @numero int, @id_barrio int) 

AS BEGIN
BEGIN TRY
BEGIN TRANSACTION

insert into Domicilios(id_domicilio, calle, numero, id_barrio) 
values(@id_domicilio, @calle, @numero, @id_barrio)

insert into CentrosMedicos(id_centro, denominacion, id_domicilio, telefono, mail, esPropio, activo)
values(@id_centro, @denominacion, @id_domicilio, @telefono, @mail, @esPropio, @activo)

COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH 
END

GO
/****** Object:  StoredProcedure [dbo].[stpro_Insertar_Profesional]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stpro_Insertar_Profesional]
(@matricula int, @tipoDocumento int, @numeroDocumento int,
@nombre varchar(50), @apellido varchar(50), @fechaNacimiento datetime, @codDomicilio int, 
@calle varchar(50), @numero int, @barrio int, @telefono bigint, @mail varchar(50)) 
AS
BEGIN

BEGIN TRY
BEGIN TRANSACTION 

insert into Domicilios(id_domicilio, calle, numero, id_barrio) 
values(@codDomicilio, @calle, @numero, @barrio)

insert into Personas(id_tipo_doc, numero_doc, nombre, apellido, fecha_nacimiento,
direccion, telefono, mail)
values(@tipoDocumento, @numeroDocumento, @nombre, @apellido, @fechaNacimiento,
@codDomicilio, @telefono, @mail)

insert into Profesionales(matricula, id_tipo_doc, numero_doc, activo)
values (@matricula, @tipoDocumento, @numeroDocumento, 1)

COMMIT TRANSACTION 
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH 
END

GO
/****** Object:  StoredProcedure [dbo].[stpro_Listar_Afiliados]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpro_Listar_Afiliados] 
 (@activo nvarchar(2), @tipo_doc int, @num_doc int)
 as
 begin 
 
 Declare @sql nvarchar(1000),
 @paramDefinition nvarchar(255),
 @paramvalue nvarchar(200)
 
 SET @sql =
 'SELECT 
 P.id_tipo_doc, 
 TD.nombre as Tipo_documento,
 P.numero_doc, 
 P.nombre, 
 P.apellido, 
 P.fecha_nacimiento, 
 P.telefono, 
 P.mail, 
 D.calle, 
 D.numero, 
 D.id_barrio, 
 B.nombre as Barrio,
 L.id as id_localidad,
 L.nombre as Localidad, 
 PR.id as id_provincia,
 PR.nombre as Provincia, 
 A.id_tipo_afil, 
 A.empresa_convenio, 
 A.activo,
 TA.nombre as Tipo_Afiliado
 
 from Afiliados A inner join Personas P 
 on A.id_tipo_doc = P.id_tipo_doc 
 and A.numero_doc = P.numero_doc 
 inner join TiposAfiliado TA 
 on A.id_tipo_afil = TA.id 
 inner join TiposDocumento TD 
 on P.id_tipo_doc = TD.id 
 inner join Domicilios D
 on P.direccion = D.id_domicilio 
 inner join Barrios B 
 on D.id_barrio = B.id_barrio 
 inner join Localidades L 
 on B.id_localidad = L.id 
 inner join Provincias PR on 
 L.id_provincia = PR.id 
 where 1 = 1'
 
 If @activo IS NOT NULL
 BEGIN 
 SET @sql = @sql + ' and A.activo = @activo'
 SET @paramDefinition = '@activo int'
 SET @paramvalue = @activo
 END 
 
 If @tipo_doc IS NOT NULL
 BEGIN
 SET @sql = @sql + ' and A.id_tipo_doc = @tipo_doc'
 SET @paramDefinition = '@tipo_doc int'
 SET @paramvalue = @tipo_doc
 END
 
 If @num_doc IS NOT NULL
 BEGIN
 SET @sql = @sql + ' and A.numero_doc = @num_doc'
 SET @paramDefinition = '@num_doc int'
 SET @paramvalue = @num_doc
 END 
 
 SET @sql = @sql + ' order by P.apellido ASC'
 
 IF @activo IS NULL AND @tipo_doc IS NULL AND @num_doc IS NULL
 BEGIN
 EXEC sp_executesql @sql
 END
 
 ELSE
 BEGIN
 EXEC sp_executesql @sql, @paramDefinition, @paramValue
 END
 END

GO
/****** Object:  StoredProcedure [dbo].[stpro_Listar_Atenciones]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpro_Listar_Atenciones] 
(@fechaInicio datetime, @fechaFin datetime, @tipo_doc int, @num_doc int)

AS
BEGIN 
 
 If @fechaInicio IS NOT NULL and @fechaFin IS NOT NULL
 BEGIN  
 SELECT 
 A.fecha_atencion, 
 PER1.apellido + ' ' + PER1.nombre as nombreAfiliado,
 TD.nombre as n_tipoDocumento,
 A.tipo_doc_Afil, 
 A.nro_doc_Afil,
 TA.id as idTipoAfiliado,
 TA.nombre as nombreTipoAfiliado, 
 C.denominacion, 
 A.id_centro, 
 PER2.apellido + ' ' + PER2.nombre as nombreProfesional,
 A.matricula, 
 E.nombre as nombreEspecialidad, 
 A.id_especialidad, 
 A.fecha_alta, 
 A.estado, 
 ES.n_estado,
 A.total_sc,
 A.total_cc,
 A.total
 
 from Atenciones A inner join ProfesionalesxCentroxEspecialidad TMAM 
 on A.id_centro = TMAM.id_centro 
 and A.id_especialidad = TMAM.id_especialidad 
 and A.matricula = TMAM.matricula
 and A.fecha_alta = TMAM.fecha_alta
 inner join Afiliados AF 
 on A.tipo_doc_Afil = AF.id_tipo_doc
 and A.nro_doc_Afil = AF.numero_doc
 inner join TiposAfiliado TA 
 on AF.id_tipo_afil = TA.id
 inner join Personas PER1
 on A.tipo_doc_Afil = PER1.id_tipo_doc
 and A.nro_doc_Afil = PER1.numero_doc
 inner join TiposDocumento TD 
 on A.tipo_doc_Afil = TD.id 
 inner join CentrosMedicos C
 on A.id_centro = C.id_centro 
 inner join Profesionales PRO 
 on A.matricula = PRO.matricula
 inner join Personas PER2
 on PRO.id_tipo_doc = PER2.id_tipo_doc
 and PRO.numero_doc = PER2.numero_doc 
 inner join Especialidades E 
 on A.id_especialidad = E.id 
 inner join EstadosAtencion ES
 on A.estado = ES.id_estado 
 where 1 = 1
 and A.fecha_atencion >= @fechaInicio
 and A.fecha_atencion <= @fechaFin
 END 
 
 If @fechaInicio IS NOT NULL and @fechaFin IS NOT NULL and  @tipo_doc IS NOT NULL and @num_doc IS NOT NULL
 BEGIN
 SELECT 
 A.fecha_atencion, 
 PER1.apellido + ' ' + PER1.nombre as nombreAfiliado,
 TD.nombre as n_tipoDocumento,
 A.tipo_doc_Afil, 
 A.nro_doc_Afil,
 TA.id as idTipoAfiliado,
 TA.nombre as nombreTipoAfiliado, 
 C.denominacion, 
 A.id_centro, 
 PER2.apellido + ' ' + PER2.nombre as nombreProfesional,
 A.matricula, 
 E.nombre as nombreEspecialidad, 
 A.id_especialidad, 
 A.fecha_alta, 
 A.estado, 
 ES.n_estado,
 A.total_sc,
 A.total_cc,
 A.total
 
 from Atenciones A inner join ProfesionalesxCentroxEspecialidad TMAM 
 on A.id_centro = TMAM.id_centro 
 and A.id_especialidad = TMAM.id_especialidad 
 and A.matricula = TMAM.matricula
 and A.fecha_alta = TMAM.fecha_alta
 inner join Afiliados AF 
 on A.tipo_doc_Afil = AF.id_tipo_doc
 and A.nro_doc_Afil = AF.numero_doc
 inner join TiposAfiliado TA 
 on AF.id_tipo_afil = TA.id
 inner join Personas PER1
 on A.tipo_doc_Afil = PER1.id_tipo_doc
 and A.nro_doc_Afil = PER1.numero_doc
 inner join TiposDocumento TD 
 on A.tipo_doc_Afil = TD.id 
 inner join CentrosMedicos C
 on A.id_centro = C.id_centro 
 inner join Profesionales PRO 
 on A.matricula = PRO.matricula
 inner join Personas PER2
 on PRO.id_tipo_doc = PER2.id_tipo_doc
 and PRO.numero_doc = PER2.numero_doc 
 inner join Especialidades E 
 on A.id_especialidad = E.id 
 inner join EstadosAtencion ES
 on A.estado = ES.id_estado 
 where 1 = 1
 and A.fecha_atencion >= @fechaInicio
 and A.fecha_atencion <= @fechaFin
 and A.nro_doc_Afil = @num_doc
 and A.tipo_doc_Afil = @tipo_doc 
 END
 
 If @fechaInicio IS NULL and @fechaFin IS NULL and @tipo_doc IS NOT NULL and @num_doc IS NOT NULL
 BEGIN
 SELECT 
 A.fecha_atencion, 
 PER1.apellido + ' ' + PER1.nombre as nombreAfiliado,
 TD.nombre as n_tipoDocumento,
 A.tipo_doc_Afil, 
 A.nro_doc_Afil,
 TA.id as idTipoAfiliado,
 TA.nombre as nombreTipoAfiliado, 
 C.denominacion, 
 A.id_centro, 
 PER2.apellido + ' ' + PER2.nombre as nombreProfesional,
 A.matricula, 
 E.nombre as nombreEspecialidad, 
 A.id_especialidad, 
 A.fecha_alta, 
 A.estado, 
 ES.n_estado,
 A.total_sc,
 A.total_cc,
 A.total
 
 from Atenciones A inner join ProfesionalesxCentroxEspecialidad TMAM 
 on A.id_centro = TMAM.id_centro 
 and A.id_especialidad = TMAM.id_especialidad 
 and A.matricula = TMAM.matricula
 and A.fecha_alta = TMAM.fecha_alta
 inner join Afiliados AF 
 on A.tipo_doc_Afil = AF.id_tipo_doc
 and A.nro_doc_Afil = AF.numero_doc
 inner join TiposAfiliado TA 
 on AF.id_tipo_afil = TA.id
 inner join Personas PER1
 on A.tipo_doc_Afil = PER1.id_tipo_doc
 and A.nro_doc_Afil = PER1.numero_doc
 inner join TiposDocumento TD 
 on A.tipo_doc_Afil = TD.id 
 inner join CentrosMedicos C
 on A.id_centro = C.id_centro 
 inner join Profesionales PRO 
 on A.matricula = PRO.matricula
 inner join Personas PER2
 on PRO.id_tipo_doc = PER2.id_tipo_doc
 and PRO.numero_doc = PER2.numero_doc 
 inner join Especialidades E 
 on A.id_especialidad = E.id 
 inner join EstadosAtencion ES
 on A.estado = ES.id_estado 
 where 1 = 1
 and A.nro_doc_Afil = @num_doc
 and A.tipo_doc_Afil = @tipo_doc 
 END

 If @fechaInicio IS  NULL and @fechaFin IS  NULL and  @tipo_doc IS NULL and @num_doc IS  NULL
 BEGIN
 SELECT 
 A.fecha_atencion, 
 PER1.apellido + ' ' + PER1.nombre as nombreAfiliado,
 TD.nombre as n_tipoDocumento,
 A.tipo_doc_Afil, 
 A.nro_doc_Afil,
 TA.id as idTipoAfiliado,
 TA.nombre as nombreTipoAfiliado, 
 C.denominacion, 
 A.id_centro, 
 PER2.apellido + ' ' + PER2.nombre as nombreProfesional,
 A.matricula, 
 E.nombre as nombreEspecialidad, 
 A.id_especialidad, 
 A.fecha_alta, 
 A.estado,
 ES.n_estado, 
 A.total_sc,
 A.total_cc,
 A.total
 
 from Atenciones A inner join ProfesionalesxCentroxEspecialidad TMAM 
 on A.id_centro = TMAM.id_centro 
 and A.id_especialidad = TMAM.id_especialidad 
 and A.matricula = TMAM.matricula
 and A.fecha_alta = TMAM.fecha_alta
 inner join Afiliados AF 
 on A.tipo_doc_Afil = AF.id_tipo_doc
 and A.nro_doc_Afil = AF.numero_doc
 inner join TiposAfiliado TA 
 on AF.id_tipo_afil = TA.id
 inner join Personas PER1
 on A.tipo_doc_Afil = PER1.id_tipo_doc
 and A.nro_doc_Afil = PER1.numero_doc
 inner join TiposDocumento TD 
 on A.tipo_doc_Afil = TD.id 
 inner join CentrosMedicos C
 on A.id_centro = C.id_centro 
 inner join Profesionales PRO 
 on A.matricula = PRO.matricula
 inner join Personas PER2
 on PRO.id_tipo_doc = PER2.id_tipo_doc
 and PRO.numero_doc = PER2.numero_doc 
 inner join Especialidades E 
 on A.id_especialidad = E.id 
 inner join EstadosAtencion ES
 on A.estado = ES.id_estado 
 END
 END

GO
/****** Object:  StoredProcedure [dbo].[stpro_Listar_Profesionales]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpro_Listar_Profesionales] 
 (@activo nvarchar(2), @tipo_doc int, @num_doc int)
 AS
 BEGIN
 
 Declare @sql nvarchar(1000),
 @paramDefinition nvarchar(255),
 @paramvalue nvarchar(200)
 
 SET @sql =
 'SELECT 
 P.id_tipo_doc, 
 TD.nombre as Tipo_documento,
 P.numero_doc, 
 P.nombre, 
 P.apellido, 
 P.fecha_nacimiento, 
 P.telefono, 
 P.mail, 
 D.calle, 
 D.numero, 
 D.id_barrio, 
 B.nombre as Barrio,
 L.id as id_localidad,
 L.nombre as Localidad, 
 PR.id as id_provincia,
 PR.nombre as Provincia, 
 PROF.matricula, 
 PROF.activo
 
 from Profesionales PROF inner join Personas P 
 on PROF.id_tipo_doc = P.id_tipo_doc 
 and PROF.numero_doc = P.numero_doc 
 inner join TiposDocumento TD 
 on P.id_tipo_doc = TD.id 
 inner join Domicilios D
 on P.direccion = D.id_domicilio 
 inner join Barrios B 
 on D.id_barrio = B.id_barrio 
 inner join Localidades L 
 on B.id_localidad = L.id 
 inner join Provincias PR on 
 L.id_provincia = PR.id 
 where 1 = 1'
 
 If @activo IS NOT NULL
 BEGIN 
 SET @sql = @sql + ' and PROF.activo = @activo'
 SET @paramDefinition = '@activo int'
 SET @paramvalue = @activo
 END 
 
 If @tipo_doc IS NOT NULL
 BEGIN
 SET @sql = @sql + ' and PROF.id_tipo_doc = @tipo_doc'
 SET @paramDefinition = '@tipo_doc int'
 SET @paramvalue = @tipo_doc
 END
 
 If @num_doc IS NOT NULL
 BEGIN
 SET @sql = @sql + ' and PROF.numero_doc = @num_doc'
 SET @paramDefinition = '@num_doc int'
 SET @paramvalue = @num_doc
 END 
 
 SET @sql = @sql + ' order by P.apellido ASC'
 
 IF @activo IS NULL AND @tipo_doc IS NULL AND @num_doc IS NULL
 BEGIN
 EXEC sp_executesql @sql
 END
 
 ELSE
 BEGIN
 EXEC sp_executesql @sql, @paramDefinition, @paramValue
 END
 END

GO
/****** Object:  StoredProcedure [dbo].[stpro_modificar_afiliado]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpro_modificar_afiliado]
(@numeroDocumentoA int, @tipoDocumentoA int, @Activo int, @tipoDocumento int, @numeroDocumento int,
@nombre varchar(50), @apellido varchar(50), @fechaNacimiento datetime, 
@calle varchar(50), @numero int, @barrio int,@tipo_afil int, @telefono bigint, @mail varchar(50), @empresa_convenio varchar(50)) as

begin transaction 
update Personas
Set id_tipo_doc = @tipoDocumento,
numero_doc = @numeroDocumento,
nombre = @nombre,
apellido = @apellido,
fecha_nacimiento = @fechaNacimiento,
telefono = @telefono,
mail = @mail
where numero_doc = @numeroDocumentoA
and id_tipo_doc = @tipoDocumentoA

Declare @codigoDomicilio int 
SELECT @codigoDomicilio = direccion FROM Personas
where numero_doc = @numeroDocumentoA
and id_tipo_doc = @tipoDocumentoA

update Domicilios
Set calle = @calle,
numero= @numero,
id_barrio = @barrio
where id_domicilio = @codigoDomicilio

update Afiliados
Set 
id_tipo_doc = @tipoDocumento,
numero_doc = @numeroDocumento,
activo = @Activo,
id_tipo_afil = @tipo_afil,
empresa_convenio = @empresa_convenio 
where numero_doc = @numeroDocumentoA
and id_tipo_doc = @tipoDocumentoA

if @@ERROR <> 0
begin 
print 'Error al modificar un Afiliado'
rollback transaction 
return 
end 
commit transaction

GO
/****** Object:  StoredProcedure [dbo].[stpro_modificar_CentroMedico]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stpro_modificar_CentroMedico]
(@id_CentroA int, @denominacion varchar(100), @calle varchar(100),@numero int, 
@cod_barrio int, @telefono bigint, @mail varchar(100), @es_propio bit, @activo bit) 
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION 

UPDATE CentrosMedicos 
Set denominacion = @denominacion,
telefono = @telefono,
mail  = @mail,
esPropio = @es_propio
where id_centro = @id_CentroA

Declare @codigoDomicilio int 
SELECT @codigoDomicilio = id_domicilio FROM CentrosMedicos 
where id_centro = @id_CentroA

UPDATE Domicilios
Set calle = @calle,
numero= @numero,
id_barrio = @cod_barrio
where id_domicilio = @codigoDomicilio

COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION 
END CATCH 
END

GO
/****** Object:  StoredProcedure [dbo].[stpro_modificar_profesional]    Script Date: 4/11/2016 3:30:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpro_modificar_profesional]
(@numeroDocumentoA int, @tipoDocumentoA int, @matricula int, @tipoDocumento int, @numeroDocumento int,
@nombre varchar(50), @apellido varchar(50), @fechaNacimiento datetime, 
@calle varchar(50), @numero int, @barrio int, @telefono bigint, @mail varchar(50)) as

begin transaction 
update Personas
Set id_tipo_doc = @tipoDocumento,
numero_doc = @numeroDocumento,
nombre = @nombre,
apellido = @apellido,
fecha_nacimiento = @fechaNacimiento,
telefono = @telefono,
mail = @mail
where numero_doc = @numeroDocumentoA
and id_tipo_doc = @tipoDocumentoA

Declare @codigoDomicilio int 
SELECT @codigoDomicilio = direccion FROM Personas
where numero_doc = @numeroDocumentoA
and id_tipo_doc = @tipoDocumentoA

update Domicilios
Set calle = @calle,
numero= @numero,
id_barrio = @barrio
where id_domicilio = @codigoDomicilio

update Profesionales 
Set matricula = @matricula,
id_tipo_doc = @tipoDocumento,
numero_doc = @numeroDocumento
where numero_doc = @numeroDocumentoA
and id_tipo_doc = @tipoDocumentoA

if @@ERROR <> 0
begin 
print 'Error al modificar un Profesional'
rollback transaction 
return 
end 
commit transaction

GO
USE [master]
GO
ALTER DATABASE [obrasocial2] SET  READ_WRITE 
GO
