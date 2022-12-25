use _UMBD
CREATE TABLE [dbo].[order_tb](
	[id_order] int IDENTITY(1,1) NOT NULL Primary Key,
	[warehouseInt] int,
	[productname] [varchar](20) NOT NULL,
	[departure_time] [date] NOT NULL,
	[customer] [varchar](20) NOT NULL,
	[Value] [int] NOT NULL,
	[Cost] [int] NOT NULL,
	[del_order] [int] check (del_order=0 or del_order=1) NOT NULL Default '1')
/*
drop table order_tb
alter table order_tb
drop constraint orderForeign
drop constraint staffForeign
*/
update order_tb set warehouseInt = 2, productname ='Еда', departure_time ='2022-12-23', customer ='Чувак', Value =11, Cost =11000 where id_order like 5 and del_order like 1;
select * from order_tb