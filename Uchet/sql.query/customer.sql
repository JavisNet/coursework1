use _UMBD
CREATE TABLE [dbo].[customer_tb](
	[id_c] int IDENTITY(1,1) NOT NULL Primary Key,
	[customerInt] int,
	[customer_name] [varchar](20) NOT NULL Default 'ннн юой',
	[del_customer] [int] check (del_customer>-1 and del_customer<2) NOT NULL Default '1')

/*
drop table customer_tb
*/