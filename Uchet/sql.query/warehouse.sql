use _UMBD
CREATE TABLE [dbo].[warehouse_tb](
[id_warehouse] int IDENTITY(1,1) NOT NULL Primary Key,
[Warehouse] [int] check (Warehouse>0 and Warehouse<5) NOT NULL Default '2',
[NameWarehouse] varchar(250) NOT NULL Default 'Склад №2',
[del_warehouse] [int] check (del_warehouse>-1 and del_warehouse<2) NOT NULL Default '1')

/*
drop table warehouse_tb
*/
