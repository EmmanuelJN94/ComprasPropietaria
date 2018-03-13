create database Purchase
go
use Purchase
go

create table Measurement_units(
unit_id numeric(10) primary key identity(1,1),
unit_name nvarchar(50),
unit_status bit);

create table Departments(
dept_id numeric(10) primary key identity(1,1),
dept_name nvarchar(50),
dept_status bit);

create table Items(
item_id numeric(10) primary key identity(1,1),
item_desc nvarchar(50),
brand nvarchar(50),
unit_id numeric(10) references Measurement_units(unit_id),
item_amount numeric(10),
price numeric(10,2),
item_status bit);

create table Suppliers(
supplier_id numeric(10) primary key identity(1,1),
cedula numeric(11),
supplier_name nvarchar(50),
supplier_status bit);

create table Orders(
order_id numeric(10) primary key identity(1,1),
order_date date,
order_status bit,
item_id numeric(10) references items(item_id),
order_amount numeric(10),
supplier_id numeric(10) references suppliers(supplier_id),
dept_id numeric(10) references departments(dept_id));

create table Accounting_entries (
	[AsientoContableId] [int] IDENTITY(1,1) NOT NULL,
	[AuxiliarId] [int] NOT NULL,
	[AsientoContableFecha] [datetime] NOT NULL,
	[AsientoContableDescripcion] [varchar](200) NULL,
	[AsientoContableCuentaDebito] [int] NOT NULL,
	[AsientoContableCuentaCredito] [int] NOT NULL,
	[AsientoContableMonto] [numeric](8, 2) NULL,
	[AsientoContableEstado] [int] NULL

	primary key(AsientoContableId)
);