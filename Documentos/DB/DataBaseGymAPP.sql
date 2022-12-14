USE [GimnasioTP]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[NumDoc] [bigint] NOT NULL,
	[TipoDoc] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DiaNacimiento] [int] NULL,
	[MesNacimiento] [int] NULL,
	[AnioNacimiento] [int] NULL,
	[Telefono] [bigint] NULL,
	[Email] [varchar](50) NULL,
	[TelefonoEmergencia] [bigint] NULL,
	[Numero] [int] NULL,
	[Calle] [varchar](50) NULL,
	[IdBarrio] [int] NULL,
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [AlumnoPK] PRIMARY KEY CLUSTERED 
(
	[NumDoc] ASC,
	[TipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[IdBarrio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[IdLocalidad] [int] NULL,
 CONSTRAINT [BarrioPK] PRIMARY KEY CLUSTERED 
(
	[IdBarrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePlan]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePlan](
	[IdPlan] [int] NOT NULL,
	[IdEjercicio] [int] NOT NULL,
	[Repeticiones] [int] NOT NULL,
	[Series] [int] NOT NULL,
 CONSTRAINT [DetallePlanPK] PRIMARY KEY CLUSTERED 
(
	[IdPlan] ASC,
	[IdEjercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejercicio]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio](
	[IdEJ] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[IdGM] [int] NULL,
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [EjercicioIDPK] PRIMARY KEY CLUSTERED 
(
	[IdEJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[IdEstado] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoMuscular]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoMuscular](
	[IdGM] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [GrupoMuscularID] PRIMARY KEY CLUSTERED 
(
	[IdGM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [LocalidadPK] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanGim]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanGim](
	[IdPlan] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL,
	[NumDocAl] [bigint] NULL,
	[TipoDocAl] [int] NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [EjercicioPlanPK] PRIMARY KEY CLUSTERED 
(
	[IdPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[IdTipoDoc] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [TipoDocPK] PRIMARY KEY CLUSTERED 
(
	[IdTipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[IdTipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [TipoUsuarioPK] PRIMARY KEY CLUSTERED 
(
	[IdTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/11/2022 17:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Clave] [varchar](8) NOT NULL,
	[IdTipoUsuario] [int] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [UsuarioPK] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (14921325, 1, N'Liliana', N'Menendez', 10, 12, 1954, 3516679201, N'lilimail', 3515302996, 21312, N'calle', 2, 1)
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (20072900, 1, N'Mario', N'Menendez', 17, 1, 1960, 3519880231, N'mariomail.com', 3517820081, 2312, N'Lacalle', 2, 0)
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (41264570, 1, N'Ignacio', N'Pedrosa', 29, 6, 1998, 3517078248, N'nacho@gmail.com', 3514789621, 231, N'calle', 2, 1)
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (43693189, 1, N'Consuelo', N'Cordoba', 4, 1, 2002, 21563735187, N'consu@mail.com', 21631987361, 2131, N'publcia', 1004, 1)
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (43693988, 1, N'Francisco', N'Menendez', 29, 11, 2001, 3515403599, N'franm2910@mail.com', 351298311, 541, N'Almirante Brown', 2, 1)
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (44652988, 1, N'Paula', N'Arrascaeta', 20, 6, 2002, 35138898822, N'pau@mail.com', 35150214988, 2211, N'Isaac', 2, 1)
INSERT [dbo].[Alumno] ([NumDoc], [TipoDoc], [Nombre], [Apellido], [DiaNacimiento], [MesNacimiento], [AnioNacimiento], [Telefono], [Email], [TelefonoEmergencia], [Numero], [Calle], [IdBarrio], [IdEstado]) VALUES (45596497, 1, N'Ignacio', N'Maldonado', 30, 5, 2004, 3518764999, N'nachitomail.com', 35182474999, 45873, N'Caile', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Barrio] ON 

INSERT [dbo].[Barrio] ([IdBarrio], [Nombre], [IdLocalidad]) VALUES (2, N'AltoAlberdi', 1)
INSERT [dbo].[Barrio] ([IdBarrio], [Nombre], [IdLocalidad]) VALUES (1001, N'Nueva Cordoba', 1)
INSERT [dbo].[Barrio] ([IdBarrio], [Nombre], [IdLocalidad]) VALUES (1002, N'BrioCalera', 1001)
INSERT [dbo].[Barrio] ([IdBarrio], [Nombre], [IdLocalidad]) VALUES (1003, N'LaCostanera', 1002)
INSERT [dbo].[Barrio] ([IdBarrio], [Nombre], [IdLocalidad]) VALUES (1004, N'Villa Warcalde', 1)
SET IDENTITY_INSERT [dbo].[Barrio] OFF
GO
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (6, 4, 2, 1)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (6, 1002, 5, 3)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (7, 4, 5, 3)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (7, 1004, 10, 3)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (7, 1005, 6, 2)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (9, 1002, 4, 2)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (9, 1003, 3, 2)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (9, 1005, 12, 4)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (11, 1002, 5, 3)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (11, 1005, 4, 2)
INSERT [dbo].[DetallePlan] ([IdPlan], [IdEjercicio], [Repeticiones], [Series]) VALUES (12, 1002, 5, 3)
GO
SET IDENTITY_INSERT [dbo].[Ejercicio] ON 

INSERT [dbo].[Ejercicio] ([IdEJ], [Nombre], [Descripcion], [IdGM], [IdEstado]) VALUES (4, N'Abdominal bolita', N'Acostado boca arriba. Presionas el tronco con la rodilla', 1, 1)
INSERT [dbo].[Ejercicio] ([IdEJ], [Nombre], [Descripcion], [IdGM], [IdEstado]) VALUES (1002, N'Flexiones de Brazo', N'Movimiento recto arriba y hacia abajo', 2, 1)
INSERT [dbo].[Ejercicio] ([IdEJ], [Nombre], [Descripcion], [IdGM], [IdEstado]) VALUES (1003, N'Plancha', N'Acostarse, levantarse levemente con una postura firme', 1, 1)
INSERT [dbo].[Ejercicio] ([IdEJ], [Nombre], [Descripcion], [IdGM], [IdEstado]) VALUES (1004, N'Camilla de isquios', N'Utilizar la maquina correspondiente.', 6, 1)
INSERT [dbo].[Ejercicio] ([IdEJ], [Nombre], [Descripcion], [IdGM], [IdEstado]) VALUES (1005, N'Sentadilla', N'hacer con barra o peso libre', 7, 1)
SET IDENTITY_INSERT [dbo].[Ejercicio] OFF
GO
INSERT [dbo].[Estado] ([IdEstado], [Nombre]) VALUES (0, N'Inactivo')
INSERT [dbo].[Estado] ([IdEstado], [Nombre]) VALUES (1, N'Activo')
GO
SET IDENTITY_INSERT [dbo].[GrupoMuscular] ON 

INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (1, N'Abdomen', N'Zona Media del torso', 1)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (2, N'Pecho', N'Tren Superior', 1)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (3, N'Brazos', N'Biceps y Triceps y antebrazos', 0)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (4, N'Brazos', N'Zona de brazos', 1)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (5, N'Piernas', N'Zona Inferior y gluteos', 0)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (6, N'Piernas', N'Zona inferior del cuerpo. No incluye gluteos', 1)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (7, N'Gluteos', N'Zona inferior del cuerpo. Centrada en la parte de gluteos', 1)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (8, N'Hombros', N'Zona superior del cuerpo', 1)
INSERT [dbo].[GrupoMuscular] ([IdGM], [Nombre], [Descripcion], [IdEstado]) VALUES (9, N'Hombros', N'Zona superior', 1)
SET IDENTITY_INSERT [dbo].[GrupoMuscular] OFF
GO
SET IDENTITY_INSERT [dbo].[Localidad] ON 

INSERT [dbo].[Localidad] ([IdLocalidad], [Nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[Localidad] ([IdLocalidad], [Nombre]) VALUES (1001, N'Villa Maria')
INSERT [dbo].[Localidad] ([IdLocalidad], [Nombre]) VALUES (1002, N'Carlos Paz')
SET IDENTITY_INSERT [dbo].[Localidad] OFF
GO
SET IDENTITY_INSERT [dbo].[PlanGim] ON 

INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (1, N'Plan Mes Agosto', N'Plan de adaptación', CAST(N'2022-10-11' AS Date), CAST(N'2022-10-27' AS Date), 43693988, 1, 0)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (4, N'primer ', N'er', CAST(N'2022-10-11' AS Date), CAST(N'2022-10-18' AS Date), 41264570, 1, 1)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (6, N'Plan de inicio', N'Plan liviano', CAST(N'2022-10-11' AS Date), CAST(N'2022-11-11' AS Date), 14921325, 1, 0)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (7, N'Plan de inicio', N'Plan para comenzar y adaptarse. La alumna indica que quiere fortalezer zona inferior', CAST(N'2022-10-19' AS Date), CAST(N'2022-11-19' AS Date), 43693189, 1, 1)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (9, N'Plan inicio agosto', N'plan de adaptacion', CAST(N'2022-10-19' AS Date), CAST(N'2022-11-19' AS Date), 43693988, 1, 1)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (11, N'Plan Noviembre', N'', CAST(N'2022-10-11' AS Date), CAST(N'2022-11-11' AS Date), 43693988, 1, 1)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (12, N'plan prueba', N'', CAST(N'2022-10-23' AS Date), CAST(N'2022-11-23' AS Date), 43693988, 1, 1)
INSERT [dbo].[PlanGim] ([IdPlan], [Nombre], [Descripcion], [FechaDesde], [FechaHasta], [NumDocAl], [TipoDocAl], [Estado]) VALUES (13, N'', N'', CAST(N'2022-10-11' AS Date), CAST(N'2022-11-15' AS Date), 43693189, 1, 1)
SET IDENTITY_INSERT [dbo].[PlanGim] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDocumento] ON 

INSERT [dbo].[TipoDocumento] ([IdTipoDoc], [Nombre]) VALUES (1, N'DNI')
SET IDENTITY_INSERT [dbo].[TipoDocumento] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([IdTipoUsuario], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[TipoUsuario] ([IdTipoUsuario], [Descripcion]) VALUES (2, N'Profesor')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [NombreUsuario], [Clave], [IdTipoUsuario], [Estado]) VALUES (1, N'Fran', N'123', 1, 1)
INSERT [dbo].[Usuario] ([IdUsuario], [NombreUsuario], [Clave], [IdTipoUsuario], [Estado]) VALUES (2, N'Ignacio', N'123', 2, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [Barrio_fk_IdBarrio] FOREIGN KEY([IdBarrio])
REFERENCES [dbo].[Barrio] ([IdBarrio])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [Barrio_fk_IdBarrio]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [TipoDoc_fk_Doc] FOREIGN KEY([TipoDoc])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDoc])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [TipoDoc_fk_Doc]
GO
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [IdLocalidad_FK_Localidad] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidad] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [IdLocalidad_FK_Localidad]
GO
ALTER TABLE [dbo].[DetallePlan]  WITH CHECK ADD  CONSTRAINT [DetallePlan_fk_Plan] FOREIGN KEY([IdPlan])
REFERENCES [dbo].[PlanGim] ([IdPlan])
GO
ALTER TABLE [dbo].[DetallePlan] CHECK CONSTRAINT [DetallePlan_fk_Plan]
GO
ALTER TABLE [dbo].[Ejercicio]  WITH CHECK ADD  CONSTRAINT [Ejercicio_fk_GrupoMuscular] FOREIGN KEY([IdGM])
REFERENCES [dbo].[GrupoMuscular] ([IdGM])
GO
ALTER TABLE [dbo].[Ejercicio] CHECK CONSTRAINT [Ejercicio_fk_GrupoMuscular]
GO
ALTER TABLE [dbo].[Ejercicio]  WITH CHECK ADD  CONSTRAINT [EjEstadoFK] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[Ejercicio] CHECK CONSTRAINT [EjEstadoFK]
GO
ALTER TABLE [dbo].[GrupoMuscular]  WITH CHECK ADD  CONSTRAINT [GMEstadoFK] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[GrupoMuscular] CHECK CONSTRAINT [GMEstadoFK]
GO
ALTER TABLE [dbo].[PlanGim]  WITH CHECK ADD  CONSTRAINT [Plan_fk_Alumno] FOREIGN KEY([NumDocAl], [TipoDocAl])
REFERENCES [dbo].[Alumno] ([NumDoc], [TipoDoc])
GO
ALTER TABLE [dbo].[PlanGim] CHECK CONSTRAINT [Plan_fk_Alumno]
GO
ALTER TABLE [dbo].[PlanGim]  WITH CHECK ADD  CONSTRAINT [Plan_fk_Estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[PlanGim] CHECK CONSTRAINT [Plan_fk_Estado]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [EstadoFK] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [EstadoFK]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [IdTipoUsuario_fk_TipoUsuario] FOREIGN KEY([IdTipoUsuario])
REFERENCES [dbo].[TipoUsuario] ([IdTipoUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [IdTipoUsuario_fk_TipoUsuario]
GO
