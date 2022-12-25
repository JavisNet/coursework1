use _UMBD
/*
CREATE TABLE [dbo].[staff_tb](
[id_staff] [int] IDENTITY(1,1) NOT NULL primary key,
[surname] [varchar](30) NOT NULL,
[name] [varchar](30) NOT NULL,
[patronymic] [varchar](30) NOT NULL,
[Login] [varchar](16) NOT NULL,
[Password] [varchar](16) NOT NULL,
[del_staff] [int] check (del_staff>-1 and del_staff<2) NOT NULL Default '1')
*/
select * from staff_tb

/*
insert into staff_tb(staff_tb.surname, staff_tb.name, staff_tb.patronymic,staff_tb.Login,staff_tb.Password) values ('Губарев','Анатолий','Анатольевич','Admin','Admin')

*/
/*
drop table staff_tb
*/