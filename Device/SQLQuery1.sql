use SheBeiGL
select * from Shebei where   
Typeid=1 and name=''
select * from SheBeiType

update  SheBeiType set TypeName='{0}'where TypeId=121

insert into Serice values(1,'����','�人','��·','2015-01-05','�Ӽ�','/Images','2.5','200.5')

insert into Serice values(2,'����','����','��','2015-07-05','�Ӽ�','/Images','2','253')
insert into Serice values(3,'��¶','����','��·','2012-09-03','�Ӽ�','/Images','1','234')
insert into Serice values(1,'����','����','�Ѻ�','2016-07-09','�Ӽ�','/Images','5','123')
select * from Serice ,SheBeiType where Serice.DeviceType=SheBeiType.TypeId -- and  DeviceType=2 
select * from SheBeiType
select * from Shebei where typeid=1
insert into Serice (DeviceType,Weixiuer,Area,Guzhang,WeixiuData,Beizu)values(1,'{1}','{2}','{3}','{4}','{5}')
insert into Serice values(1,'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')
 
 insert into Serice values(1,'gfjhf','fdh','gfjhg','2016-08-02','jhg',null,null,null)

 insert into Reject values(1,3,'100','2016-12-05','��')
 insert into Reject values(2,1,'300','2015-10-05','��')

 

 select * from Reject,SheBeiType
 select * from Shebei
 select * from SheBeiType
 select Shebei.Name,SheBeiType.TypeName,Area,Weixiuer,WeixiuData,Guzhang from Shebei,SheBeiType,Serice where Shebei.Typeid=SheBeiType.TypeId and Serice.shibeiID=Shebei.ID
 
 select Shebei.Name,SheBeiType.TypeName,Area,Weixiuer,WeixiuData,Guzhang from Shebei,SheBeiType,Serice where
   Shebei.Typeid=SheBeiType.TypeId and Shebei.ID=Serice.shibeiID

 select * from Serice  
select * from Shebei 
select* from Borrow
select * from  Reject
select * from  Returns
select * from  Reject


 insert into Serice values(1,'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')
 
 insert into Serice values(3,'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')
 select * from Reject,SheBeiType,Shebei where
Reject.ShebeiID=Shebei.ID and Reject.Type=Shebei.Typeid

select * from Borrow

insert into Borrow values(1,1,'����','����','2015-12-10',2)
select * from Returns

insert into Returns values(1,2,'����','����',2,'2015-10-12','2016-10-07')

select * from Reject,SheBeiType,Shebei where Reject.ShebeiID=Shebei.ID and Reject.Type=Shebei.Typeid and name='����'and TypeName='������'
select Name ,TypeName,BorrowDepartment,Borrower,BorrowData,BorrowTime from Shebei,SheBeiType,Borrow where Shebei.Typeid=SheBeiType.TypeId and Borrow.SheBeiID=Shebei.ID and Name='����' and TypeName='������'
select * from admin where Name='����'
select * from Shebei where typeid=3
insert into admin values('lc','asd',22,'��')

select * from Reject,SheBeiType,Shebei where Reject.ShebeiID=Shebei.ID and SheBeiType.TypeId=Shebei.Typeid 

select * from Shebei,SheBeiType where Shebei.typeid=SheBeiType.TypeId and Shopdata > '2015-01-01'




