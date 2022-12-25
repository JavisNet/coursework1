--create database _UMBD
use _UMBD
select delivery_tb.id_d as 'Номер', delivery_tb.Date_Delivery as 'Дата Доставки',supplier_tb.Postav as 'Поставщик',customer_tb.Sakaschikc as 'Заказчик', delivery_tb.Sakas as 'Заказ',customer_tb.Counte as 'Кол-во',supplier_tb.Stoim as 'Цена', delivery_tb.Warehouse as 'Номер Склада' from delivery_tb,customer_tb,supplier_tb
where delivery_tb.id_d = customer_tb.id_c and delivery_tb.id_d = supplier_tb.id_s
   insert into delivery_tb(delivery_tb.Date_Delivery, delivery_tb.Sakas, delivery_tb.Warehouse) values ('14-11-2022','Металл',2)
   insert into supplier_tb(supplier_tb.Postav, supplier_tb.Stoim) values ('ООО Мета',4000)
   insert into customer_tb(customer_tb.Sakaschikc, customer_tb.Counte) values ('ООО АПК',11)

   insert into delivery_tb(delivery_tb.Date_Delivery, delivery_tb.Sakas, delivery_tb.Warehouse) values ('30-11-2022','Трубы',1)
   insert into supplier_tb(supplier_tb.Postav, supplier_tb.Stoim) values ('ООО ЗАО',52000)
   insert into customer_tb(customer_tb.Sakaschikc, customer_tb.Counte) values ('ООО АПК',20)

--drop table  customer_tb, supplier_tb,delivery_tb