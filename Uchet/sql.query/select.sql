--create database _UMBD
use _UMBD
select delivery_tb.id_d as '�����', delivery_tb.Date_Delivery as '���� ��������',supplier_tb.Postav as '���������',customer_tb.Sakaschikc as '��������', delivery_tb.Sakas as '�����',customer_tb.Counte as '���-��',supplier_tb.Stoim as '����', delivery_tb.Warehouse as '����� ������' from delivery_tb,customer_tb,supplier_tb
where delivery_tb.id_d = customer_tb.id_c and delivery_tb.id_d = supplier_tb.id_s
   insert into delivery_tb(delivery_tb.Date_Delivery, delivery_tb.Sakas, delivery_tb.Warehouse) values ('14-11-2022','������',2)
   insert into supplier_tb(supplier_tb.Postav, supplier_tb.Stoim) values ('��� ����',4000)
   insert into customer_tb(customer_tb.Sakaschikc, customer_tb.Counte) values ('��� ���',11)

   insert into delivery_tb(delivery_tb.Date_Delivery, delivery_tb.Sakas, delivery_tb.Warehouse) values ('30-11-2022','�����',1)
   insert into supplier_tb(supplier_tb.Postav, supplier_tb.Stoim) values ('��� ���',52000)
   insert into customer_tb(customer_tb.Sakaschikc, customer_tb.Counte) values ('��� ���',20)

--drop table  customer_tb, supplier_tb,delivery_tb