USE [master]
GO
/****** Object:  Database [Peluqueria]    Script Date: 12/9/2022 17:52:01 ******/
CREATE DATABASE [Peluqueria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Peluqueria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Peluqueria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Peluqueria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Peluqueria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Peluqueria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Peluqueria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Peluqueria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Peluqueria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Peluqueria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Peluqueria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Peluqueria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Peluqueria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Peluqueria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Peluqueria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Peluqueria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Peluqueria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Peluqueria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Peluqueria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Peluqueria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Peluqueria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Peluqueria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Peluqueria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Peluqueria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Peluqueria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Peluqueria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Peluqueria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Peluqueria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Peluqueria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Peluqueria] SET RECOVERY FULL 
GO
ALTER DATABASE [Peluqueria] SET  MULTI_USER 
GO
ALTER DATABASE [Peluqueria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Peluqueria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Peluqueria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Peluqueria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Peluqueria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Peluqueria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Peluqueria', N'ON'
GO
ALTER DATABASE [Peluqueria] SET QUERY_STORE = OFF
GO
USE [Peluqueria]
GO
/****** Object:  Table [dbo].[TurnosLaborales]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurnosLaborales](
	[Id_TurnoLaboral] [int] IDENTITY(1,1) NOT NULL,
	[Dias] [varchar](20) NULL,
	[HoraInicial] [time](7) NULL,
	[HoraFinal] [time](7) NULL,
	[FechaAlta] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_TurnoLaboral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposdePago]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposdePago](
	[Id_TipoDePago] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Interes] [decimal](15, 2) NULL,
	[Descuento] [decimal](15, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_TipoDePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Stock] [int] NULL,
	[FechaAlta] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechaNac] [datetime] NULL,
	[FechaAlta] [datetime] NULL,
 CONSTRAINT [PK__Clientes__3DD0A8CB31A98917] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Id_TurnoLaboral] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [int] NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [int] NULL,
	[FechaNac] [datetime] NULL,
	[HorasAsignadas] [int] NULL,
	[EsAdmin] [bit] NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
 CONSTRAINT [PK__Empleado__74056223DF3CE4DF] PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Id_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Id_Empleado] [int] NULL,
	[Id_TipoDePago] [int] NULL,
	[FechaAlta] [datetime] NULL,
	[Total] [decimal](12, 2) NULL,
 CONSTRAINT [PK__Ventas__B3C9EABDF452890C] PRIMARY KEY CLUSTERED 
(
	[Id_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[Id_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [varchar](50) NULL,
	[FechaAlta] [datetime] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[Id_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentasDetalles]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentasDetalles](
	[Id_VentaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Id_Servicio] [int] NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](12, 2) NULL,
	[FechaBaja] [datetime] NULL,
 CONSTRAINT [PK__VentaDet__B183C28802BE889F] PRIMARY KEY CLUSTERED 
(
	[Id_VentaDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaCompleta]    Script Date: 12/9/2022 17:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaCompleta]
AS
SELECT        dbo.Productos.Id_Producto AS Id_Producto_Productos, dbo.Productos.Nombre AS Nombre_Productos, dbo.Productos.Stock AS Stock_Productos, dbo.Productos.FechaAlta AS FechaAlta_Productos, 
                         dbo.Servicios.Id_Servicio AS Id_Servicio_Servicios, dbo.Servicios.Nombre AS Nombre_Servicios, dbo.Servicios.Precio AS Precio_Servicios, dbo.Servicios.FechaAlta AS FechaAlta_Servicios, 
                         dbo.Clientes.Id_Cliente AS Id_Cliente_Clientes, dbo.Clientes.Nombre AS Nombre_Clientes, dbo.Clientes.Apellido AS Apellido_Clientes, dbo.Clientes.FechaNac AS FechaNac_Clientes, 
                         dbo.Clientes.FechaAlta AS FechaAlta_Clientes, dbo.Ventas.Id_Venta AS Id_Venta_Ventas, dbo.Ventas.Id_Cliente AS Id_Cliente_Ventas, dbo.Ventas.Id_Empleado AS Id_Empleado_Ventas, 
                         dbo.Ventas.Id_TipoDePago AS Id_TipoDePago_Ventas, dbo.Ventas.FechaAlta AS FechaAlta_Ventas, dbo.Ventas.Total AS Total_Ventas, dbo.TiposdePago.Id_TipoDePago AS Id_TipoDePago_TiposDePago, 
                         dbo.TiposdePago.Nombre AS Nombre_TiposDePago, dbo.TiposdePago.Interes AS Interes_TiposDePago, dbo.TiposdePago.Descuento AS Descuentos_TiposDePago, dbo.Empleados.Id_Empleado AS Id_Empleado_Empleados, 
                         dbo.Empleados.Id_TurnoLaboral AS Id_TurnoLaboral_Empleados, dbo.Empleados.Nombre AS Nombre_Empleados, dbo.Empleados.Apellido AS Apellido_Empleados, dbo.Empleados.DNI AS DNI_Empleados, 
                         dbo.Empleados.Direccion AS Direccion_Empleados, dbo.Empleados.Telefono AS Telefono_Empleados, dbo.Empleados.FechaNac AS FechaNac_Empleados, dbo.Empleados.HorasAsignadas AS HorasAsignadas_Empleados, 
                         dbo.VentasDetalles.Id_VentaDetalle AS Id_VentaDetalle_VentasDetalles, dbo.VentasDetalles.Id_Producto AS Id_Producto_VentasDetalles, dbo.VentasDetalles.Id_Servicio AS Id_Servicio_VentasDetalles, 
                         dbo.VentasDetalles.Id_Venta AS Id_Venta_VentasDetalles, dbo.VentasDetalles.Cantidad AS Cantidad_VentasDetalles, dbo.VentasDetalles.Precio AS Precio_VentasDetalles, 
                         dbo.VentasDetalles.FechaBaja AS FechaBaja_VentasDetalles, dbo.TurnosLaborales.Id_TurnoLaboral AS Id_TurnoLaboral_TurnosLaborales, dbo.TurnosLaborales.Dias AS Dias_TurnosLaborales, 
                         dbo.TurnosLaborales.HoraInicial AS HoraInicial_TurnosLaborales, dbo.TurnosLaborales.HoraFinal AS HoraFinal_TurnosLaborales, dbo.TurnosLaborales.FechaAlta AS FechaAlta_TurnosLaborales, 
                         dbo.Administrador.Id_Administrador AS Id_Administrador_Administrador, dbo.Administrador.Nombre AS Nombre_Administrador, dbo.Administrador.Apellido AS Apellido_Administrador, 
                         dbo.Administrador.FechaDeNacimiento AS FechaDeNacimiento_Administrador, dbo.Administrador.DNI AS DNI_Administrador, dbo.Administrador.Usuario AS Usuario_Administrador, 
                         dbo.Administrador.Contraseña AS Contraseña_Administrador
FROM            dbo.Administrador CROSS JOIN
                         dbo.TurnosLaborales INNER JOIN
                         dbo.Empleados ON dbo.TurnosLaborales.Id_TurnoLaboral = dbo.Empleados.Id_TurnoLaboral INNER JOIN
                         dbo.Ventas ON dbo.Empleados.Id_Empleado = dbo.Ventas.Id_Empleado INNER JOIN
                         dbo.TiposdePago ON dbo.Ventas.Id_TipoDePago = dbo.TiposdePago.Id_TipoDePago INNER JOIN
                         dbo.Clientes ON dbo.Ventas.Id_Cliente = dbo.Clientes.Id_Cliente INNER JOIN
                         dbo.VentasDetalles ON dbo.Ventas.Id_Venta = dbo.VentasDetalles.Id_Venta INNER JOIN
                         dbo.Servicios ON dbo.VentasDetalles.Id_Servicio = dbo.Servicios.Id_Servicio INNER JOIN
                         dbo.Productos ON dbo.VentasDetalles.Id_Producto = dbo.Productos.Id_Producto
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([Id_Empleado], [Id_TurnoLaboral], [Nombre], [Apellido], [DNI], [Direccion], [Telefono], [FechaNac], [HorasAsignadas], [EsAdmin], [Usuario], [Contraseña]) VALUES (1, 1, N'jose', N'martines', 43674865, N'sarmiento 980', 354983, CAST(N'2000-09-27T00:00:00.000' AS DateTime), 7, 0, N'admin', N'admin')
INSERT [dbo].[Empleados] ([Id_Empleado], [Id_TurnoLaboral], [Nombre], [Apellido], [DNI], [Direccion], [Telefono], [FechaNac], [HorasAsignadas], [EsAdmin], [Usuario], [Contraseña]) VALUES (2, 1, N'juan', N'moreno', 43657556, N'sarmiento 890', 352452, CAST(N'2000-08-27T00:00:00.000' AS DateTime), 7, 1, N'juancho', N'chojuan')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Servicios] ON 

INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (1, N'Corte clásico máquina', N'500', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (2, N'Corte clásico tijera', N'600', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (3, N'Corte americano', N'700', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (4, N'Corte fade o degrade', N'700', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (5, N'Corte fade navaja', N'800', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (6, N'Lineas', N'100', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (7, N'Ceja', N'100', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (8, N'Frente', N'100', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (9, N'Dibujo simple', N'200', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (10, N'Dibujo doble', N'400', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (11, N'Corte barba con máquina', N'200', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (12, N'Corte barba con navaja', N'400', NULL)
INSERT [dbo].[Servicios] ([Id_Servicio], [Nombre], [Precio], [FechaAlta]) VALUES (13, N'Lavado', N'100', NULL)
SET IDENTITY_INSERT [dbo].[Servicios] OFF
GO
SET IDENTITY_INSERT [dbo].[TurnosLaborales] ON 

INSERT [dbo].[TurnosLaborales] ([Id_TurnoLaboral], [Dias], [HoraInicial], [HoraFinal], [FechaAlta]) VALUES (1, N'5', CAST(N'07:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL)
SET IDENTITY_INSERT [dbo].[TurnosLaborales] OFF
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_TurnosLaborales] FOREIGN KEY([Id_TurnoLaboral])
REFERENCES [dbo].[TurnosLaborales] ([Id_TurnoLaboral])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_TurnosLaborales]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleados] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleados] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleados]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_TiposdePago] FOREIGN KEY([Id_TipoDePago])
REFERENCES [dbo].[TiposdePago] ([Id_TipoDePago])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_TiposdePago]
GO
ALTER TABLE [dbo].[VentasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalles_Productos] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Productos] ([Id_Producto])
GO
ALTER TABLE [dbo].[VentasDetalles] CHECK CONSTRAINT [FK_VentasDetalles_Productos]
GO
ALTER TABLE [dbo].[VentasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalles_Servicios] FOREIGN KEY([Id_Servicio])
REFERENCES [dbo].[Servicios] ([Id_Servicio])
GO
ALTER TABLE [dbo].[VentasDetalles] CHECK CONSTRAINT [FK_VentasDetalles_Servicios]
GO
ALTER TABLE [dbo].[VentasDetalles]  WITH CHECK ADD  CONSTRAINT [FK_VentasDetalles_Ventas] FOREIGN KEY([Id_Venta])
REFERENCES [dbo].[Ventas] ([Id_Venta])
GO
ALTER TABLE [dbo].[VentasDetalles] CHECK CONSTRAINT [FK_VentasDetalles_Ventas]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[47] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Administrador"
            Begin Extent = 
               Top = 249
               Left = 738
               Bottom = 379
               Right = 934
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TurnosLaborales"
            Begin Extent = 
               Top = 24
               Left = 609
               Bottom = 154
               Right = 783
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Empleados"
            Begin Extent = 
               Top = 317
               Left = 422
               Bottom = 447
               Right = 596
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ventas"
            Begin Extent = 
               Top = 344
               Left = 24
               Bottom = 470
               Right = 194
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TiposdePago"
            Begin Extent = 
               Top = 452
               Left = 479
               Bottom = 582
               Right = 649
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 210
               Left = 232
               Bottom = 340
               Right = 402
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "VentasDetalles"
            Begin Extent = 
               Top = 93
               Left = 2
               Bottom = 223
               Right = 172
            End
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaCompleta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'         DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Servicios"
            Begin Extent = 
               Top = 130
               Left = 417
               Bottom = 260
               Right = 587
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Productos"
            Begin Extent = 
               Top = 1
               Left = 250
               Bottom = 120
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 3000
         Table = 2805
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaCompleta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaCompleta'
GO
USE [master]
GO
ALTER DATABASE [Peluqueria] SET  READ_WRITE 
GO
