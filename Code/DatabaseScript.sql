-- drop
use Master
go

if exists (select null from sys.databases where name = 'LiteracyPro')
	drop database LiteracyPro
go

-- create
if not exists (select null from sys.databases where name = 'LiteracyPro')
begin
	create database [LiteracyPro] containment = none
		on  primary 
		( name = 'LiteracyPro', filename = 'c:\program files\microsoft sql server\mssql14.mssqlserver\mssql\data\LiteracyPro.mdf' , size = 8192kb , maxsize = unlimited, filegrowth = 65536kb )
		log on 
		( name = 'LiteracyPro_log', filename = 'c:\program files\microsoft sql server\mssql14.mssqlserver\mssql\data\LiteracyPro_log.ldf' , size = 8192kb , maxsize = 2048gb , filegrowth = 65536kb )
end
go

use LiteracyPro
go

if not exists (select null from information_schema.tables where table_schema = 'dbo' and table_name = 'Categories') 
	create table dbo.Categories (
		[CategoryId] [int] identity(1,1) NOT NULL,
		[Name] [varchar](100) NOT NULL
	constraint [pk_Categories] primary key clustered 
		([CategoryId] asc)
	with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on) on [primary])

if not exists (select null from information_schema.tables where table_schema = 'dbo' and table_name = 'Transactions') 
	create table dbo.Transactions (
		[TransactionId] [int] identity(1,1) NOT NULL,
		[CategoryId] int constraint fk_Transactions_Categories foreign key references Categories(CategoryId),
		[PayeeName] [varchar](100) NOT NULL,
		[PurchaseAmount] decimal(9,2) not null,
		[PurchaseDate] datetime not null,
		[Memo] nvarchar(1000) null
	constraint [pk_Transactions] primary key clustered 
		([TransactionId] asc)
	with (pad_index = off, statistics_norecompute = off, ignore_dup_key = off, allow_row_locks = on, allow_page_locks = on) on [primary])
go

if not exists(select null from information_schema.table_constraints where constraint_name = 'ux_Categories_Name')
	alter table dbo.Categories add constraint ux_Categories_Name unique (Name)

set identity_insert dbo.Categories on
insert into dbo.Categories (CategoryId, Name) values (1, 'Business')
insert into dbo.Categories (CategoryId, Name) values (2, 'Entertainment')
insert into dbo.Categories (CategoryId, Name) values (3, 'Expenses')
set identity_insert dbo.Categories off

insert into dbo.Transactions (CategoryId, PayeeName, PurchaseAmount, PurchaseDate, Memo) values ((select CategoryId from dbo.Categories where Name = 'Business'), 'Spongebob Squarepants', 7.52, dateadd(day,-10, getdate()), 'More Krabby Patties')
insert into dbo.Transactions (CategoryId, PayeeName, PurchaseAmount, PurchaseDate, Memo) values ((select CategoryId from dbo.Categories where Name = 'Entertainment'), 'Patrick Star', 13.71, dateadd(day,-9, getdate()), null)
insert into dbo.Transactions (CategoryId, PayeeName, PurchaseAmount, PurchaseDate, Memo) values ((select CategoryId from dbo.Categories where Name = 'Expenses'), 'Squidward Tentacles', 24.95, dateadd(day,-5, getdate()), 'Leave me alone')

/*
select
	c.[Name] CategoryName,
	t.PayeeName,
	t.PurchaseAmount,
	t.PurchaseDate,
	t.Memo
from dbo.Transactions t
	join dbo.Categories c on t.CategoryId = c.Id
*/