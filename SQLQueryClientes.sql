create table Users(
UserID int identity(1,1) primary key,
LoginName nvarchar (100) unique not null,
Password nvarchar (100) not null,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Position nvarchar (100) not null,
Email nvarchar(150)not null
) 
insert into Users values ('admin','admin','Jackson','Collins','Administrator','Support@SystemAll.biz')
insert into Users values ('Ben','abc123456','Benjamin','Thompson','Receptionist','BenThompson@MyCompany.com')                                                         
insert into Users values ('Kevin','abc123456','Kevin','Gaitano','Accounting','kevinjuliangaitano@gmail.com' )

create table Clientes
(
ID int identity (1,1) primary key,
Nombre varchar (100),
Apellido varchar (100),
Direccion varchar (100),
Telefono float,
Localidad varchar (100),
)
create proc MostrarClientes
as
select *from Clientes
go

create table Productos 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Costo float,
Precio float,
Stock int
)
insert into Productos 
values
('Gaseosa','3 litros','marcacola',0,7.5,24),
('Chocolate','Tableta 100 gramos','iberica',0,12.5,36)
---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarProductos
as
select *from Productos
go
--------------------------INSERTAR 
create proc InsetarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@costo float,
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@costo,@precio,@stock)
go
------------------------ELIMINAR
create proc EliminarProducto
@idpro int
as
delete from Productos where Id=@idpro
go
------------------EDITAR
create proc EditarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@costo float,
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca,Costo=@costo, Precio=@precio, Stock=@stock where Id=@id
go

create table Proveedor 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Razon_Social nvarchar (100),
Direccion nvarchar (100),
Telefono int,
Referencia nvarchar (100),
Email nvarchar (100)
)

create proc MostrarProveedor
as
select *from Proveedor
go

CREATE TABLE [dbo].[ventas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ventasitems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDVenta] [int] NOT NULL,
	[IDProducto] [int] NOT NULL,
	[PrecioUnitario] [float] NULL,
	[Cantidad] [float] NULL,
	[PrecioTotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

select LoginName,Position,Email from Users
where UserID=1

CREATE TABLE [dbo].[Compras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDProveedor] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[comprasitems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCompra] [int] NOT NULL,
	[IDProducto] [int] NOT NULL,
	[PrecioCompra] [float] NULL,
	[PrecioVenta] [float] NULL,
	[Cantidad] [float] NULL,
	[SubTotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

select Nombre,Marca,Descripcion,PrecioUnitario,Cantidad,SubTotal from ventasitems join productos on IDProducto=productos.ID where IDVenta=1



select *from ventasitems
join productos on IDProducto=productos.ID
join ventas on IDVenta = ventas.ID
join Clientes on IDCliente = Clientes.ID 
 where Producto='gaseosa' 

 select ve.ID,COUNT(*) as CantidadID,avg(ventasitems.SubTotal) as promedio from ventas ve
 join ventasitems on ve.ID=ventasitems.IDVenta
 join Clientes on ve.IDCliente=Clientes.ID
 where ventasitems.IDProducto=1 AND ventasitems.IDProducto=2
 group by ve.ID
 
 
 select* from ventas ve
 join ventasitems on ve.ID=ventasitems.IDVenta


 