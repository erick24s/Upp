USE [BasePurificadora]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[idAlmacen] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[idDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NULL,
	[idProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[Total] [decimal](5, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Precio] [decimal](5, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Cuenta] [nvarchar](50) NULL,
	[Contraseña] [nvarchar](50) NULL,
	[EstatusAdmin] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVentas] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[fecha] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[stpCreaAlmacen]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpCreaAlmacen](@Nombre nvarchar (50), @Descripcion nvarchar (50), @Cantidad int)
as begin
	insert into Almacen values (@Nombre,@Descripcion, @Cantidad)
end
GO
/****** Object:  StoredProcedure [dbo].[stpCreaCliente]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpCreaCliente](@Nombre nvarchar(100),@Direccion nvarchar(100) , @Telefono nvarchar(100))
as begin
	insert into Cliente values (@Nombre,@Direccion,@Telefono)
end
GO
/****** Object:  StoredProcedure [dbo].[stpCreaDetalleVentas]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[stpCreaDetalleVentas](@idVenta int,@idProducto int , @Cantidad decimal (5,2), @Total decimal (5,2))
as begin
	insert into DetalleVentas values (@idVenta,@idProducto,@Cantidad, @Total)
end
GO
/****** Object:  StoredProcedure [dbo].[stpCreaEmpleado]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpCreaEmpleado](@Nombre nvarchar(50),@Direccion nvarchar(50) , @Telefono nvarchar(50) )
as begin
	insert into Empleado values (@Nombre,@Direccion,@Telefono)
end
GO
/****** Object:  StoredProcedure [dbo].[stpCreaProducto]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpCreaProducto](@Nombre nvarchar(100),@Descripcion nvarchar(100) , @Precio Decimal(5,2))
as begin
	insert into Producto values (@Nombre,@Descripcion,@Precio)
end
GO
/****** Object:  StoredProcedure [dbo].[stpCreaUsuario]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpCreaUsuario](@Nombre nvarchar(50),@Cuenta nvarchar(50) , @Contraseña nvarchar(50),@EstatusAdmin nvarchar(50) )
as begin
	insert into Usuario values (@Nombre,@Cuenta,@Contraseña,@EstatusAdmin)
end
GO
/****** Object:  StoredProcedure [dbo].[stpCreaVentas]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpCreaVentas](@idCliente int, @Fecha date)
as begin
	insert into Ventas values (@idCliente,@Fecha)
end
GO
/****** Object:  StoredProcedure [dbo].[stpEditaAlmacen]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEditaAlmacen] (@idAlmacen int, @Nombre nvarchar (50), @Descripcion nvarchar (50), @Cantidad int)
as begin 
	update Almacen set Almacen.Nombre=@Nombre, Almacen.Descripcion=@Descripcion, Almacen.Cantidad=@Cantidad
	where Almacen.idAlmacen=@idAlmacen
end
GO
/****** Object:  StoredProcedure [dbo].[stpEditaCliente]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEditaCliente] (@idCliente int, @Nombre nvarchar (100), @Direccion nvarchar (100), @Telefono nvarchar(10))
as begin 
	update Cliente set cliente.Nombre=@Nombre, cliente.Direccion=@Direccion, cliente.Telefono=@Telefono
	where Cliente.idCliente=@idcliente
end
GO
/****** Object:  StoredProcedure [dbo].[stpEditaEmpleado]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEditaEmpleado] (@idEmpleado int, @Nombre nvarchar (50), @Direccion nvarchar (50), @Telefono nvarchar(50))
as begin 
	update Empleado set Empleado.Nombre=@Nombre, Empleado.Direccion=@Direccion, Empleado.Telefono=@Telefono
	where Empleado.idEmpleado=@idEmpleado
end
GO
/****** Object:  StoredProcedure [dbo].[stpEditaProducto]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEditaProducto] (@idProducto int, @Nombre nvarchar (50), @Descripcion nvarchar (50), @Precio Decimal(5,2))
as begin 
	update Producto set Producto.Nombre=@Nombre, Producto.Descripcion=@Descripcion, Producto.Precio=@Precio
	where Producto.idProducto=@idProducto
end
GO
/****** Object:  StoredProcedure [dbo].[stpEditaUsuario]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEditaUsuario] (@idUsuario int, @Nombre nvarchar (50), @Cuenta nvarchar (50), @Contraseña nvarchar(50),@idArea int, @idEmpleado int, @EstatusAdmin int)
as begin 
	update Usuario set Usuario.Nombre=@Nombre, Usuario.Cuenta=@Cuenta,Usuario.Contraseña=@Contraseña, Usuario.idArea=@idArea,Usuario.idEmpleado=@idEmpleado,Usuario.EstatusAdmin=@EstatusAdmin
	where Usuario.idUsuario=@idUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[stpEliminarAlmacen]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEliminarAlmacen] (@idAlmacen int)
as begin
delete from Almacen where idAlmacen=@idAlmacen
end
GO
/****** Object:  StoredProcedure [dbo].[stpEliminarProducto]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEliminarProducto] (@idProducto int)
as begin 
delete from Producto where idProducto=@idProducto
end
GO
/****** Object:  StoredProcedure [dbo].[stpEliminarUsuario]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stpEliminarUsuario] (@idUsuario int)
as begin 
delete from Usuario where idUsuario=@idUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[stpLogueo]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stpLogueo](@Cuenta nvarchar(50),@Contraseña nvarchar (50))
as begin
	select Nombre, Cuenta, Contraseña,EstatusAdmin from   Usuario
	where Cuenta=@Cuenta and Contraseña=@Contraseña
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraAlmacen]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraAlmacen]
as begin
	select*from Almacen
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraCliente]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraCliente]
as begin
	select*from Cliente
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraDetalleVentas]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraDetalleVentas]
as begin
	select*from DetalleVentas
	
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraEmpleado]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraEmpleado]
as begin
	select*from Empleado
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraProducto]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraProducto]
as begin
	select*from Producto
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraUsuario]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraUsuario]
as begin
	select*from Usuario
	
end
GO
/****** Object:  StoredProcedure [dbo].[stpMuestraVentas]    Script Date: 04/12/2021 23:12:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[stpMuestraVentas]
as begin
	select*from Ventas
	
end
GO
