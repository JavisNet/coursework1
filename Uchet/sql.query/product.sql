use _UMBD
CREATE TABLE [dbo].[product_tb](
	[id_product] int IDENTITY(1,1) NOT NULL Primary Key,
	[productname] [varchar](30) NOT NULL,
	[Value] [int] NOT NULL,
	[Cost] [int] NOT NULL,
	[del_product] [int] check (del_product=0 or del_product=1) NOT NULL Default '1')
	select * from product_tb
	drop table product_tb
	update product_tb set productname = '" + nameofproduct.Text + "', Value = '" + valueofproduct.Text + "', Cost = '" + countofproduct + "' where id_product like '"Product_Id"';
	update product_tb set productname = 'ѕшеница', Value = 40, Cost = 12000 where id_product like 1 and del_product like 1;
	update product_tb set del_product = 0 where id_product like 3;