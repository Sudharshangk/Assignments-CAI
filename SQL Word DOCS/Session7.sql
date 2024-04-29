--Manage transactions
--Trancount

update [dbo].[tblEmployee] set EmployeeNumber = 538 where EmployeeNumber = 530


select * from [dbo].[tblEmployee]

select @@TRANCOUNT --0
begin tran
	select @@TRANCOUNT --1
	begin tran
		update [dbo].[tblEmployee] set EmployeeNumber = 122 where EmployeeNumber = 123
		select @@TRANCOUNT --2
	commit tran
	select @@TRANCOUNT --1
if @@TRANCOUNT > 0 --Yes
commit tran
select @@TRANCOUNT --0


select * from [dbo].[tblEmployee]

--isolation levels; 

--Transaction 1
begin transaction 

update [dbo].[tblEmployee] set EmployeeNumber = 122 where EmployeeNumber = 123

commit tran

update [dbo].[tblEmployee] set EmployeeNumber = 123 where EmployeeNumber = 122

insert into [dbo].[tblEmployee]([EmployeeNumber]
      ,[EmployeeFirstName]
      ,[EmployeeMiddleName]
      ,[EmployeeLastName]
      ,[EmployeeGovernmentID]
      ,[DateOfBirth]
      ,[Department])
values (122,'H','I','T','H','2010-01-01','H')

delete from [dbo].[tblEmployee]
where EmployeeNumber = 122
--Transaction 2
--set transaction isolation level read committed

begin tran
select * from [dbo].[tblEmployee]
waitfor delay '00:00:20'
select * from [dbo].[tblEmployee]
commit tran

--Clustered Index
create clustered index idx_tblEmployee on [dbo].[tblEmployee]([EmployeeNumber])

drop index idx_tblEmployee on [dbo].[tblEmployee]

select * from [dbo].[tblEmployee2] where [EmployeeNumber] = 127
select * from [dbo].[tblEmployee2]

select *
into [dbo].[tblEmployee2]
from [dbo].[tblEmployee]
where EmployeeNumber <> 131

--seek = few number of rows based on the index
--scan = going through the entire table

alter table [dbo].[tblEmployee2]
add constraint pk_tblEmployee2 PRIMARY KEY(EmployeeNumber)

create table myTable (Field1 int primary key)
--Non-clustered Index
create nonclustered index idx_tblEmployee_DateOfBirth on [dbo].[tblEmployee]([DateOfBirth])
create nonclustered index idx_tblEmployee_DateOfBirth_Department on [dbo].[tblEmployee]([DateOfBirth],Department)

drop index idx_tblEmployee on [dbo].[tblEmployee]

select * from [dbo].[tblEmployee2] where [EmployeeNumber] = 127
select * from [dbo].[tblEmployee2]

select DateOfBirth, Department
from [dbo].[tblEmployee]
where DateOfBirth>='1992-01-01' and DateOfBirth<'1993-01-01'

--seek = few number of rows based on the index
--scan = going through the entire table

alter table [dbo].[tblDepartment]
add constraint unq_tblDepartment UNIQUE(Department)
Filtered indices


CREATE NONCLUSTERED INDEX idx_tblEmployee_Employee  
    ON dbo.tblEmployee(EmployeeNumber) where EmployeeNumber<139;
--INCLUDE
CREATE NONCLUSTERED INDEX idx_tblEmployee_Employee  
    ON dbo.tblEmployee(EmployeeNumber) include (EmployeeFirstName);

DROP INDEX idx_tblEmployee_Employee ON dbo.tblEmployee
--Include Client Statistics
select *
from [dbo].[tblEmployee] as E
--Table Scan
select *
from [dbo].[tblEmployee] as E
where E.EmployeeNumber = 134 
--Still a Table Scan
--Hash match:
select * 
from [dbo].[tblDepartment] as D
left join [dbo].[tblEmployee] as E
on D.Department = E.Department

select D.Department, D.DepartmentHead, E.EmployeeNumber, E.EmployeeFirstName, E.EmployeeLastName 
from [dbo].[tblDepartment] as D
left join [dbo].[tblEmployee] as E
on D.Department = E.Department
--Nested Loop


select D.Department, D.DepartmentHead, E.EmployeeNumber, E.EmployeeFirstName, E.EmployeeLastName 
from [dbo].[tblDepartment] as D
left join [dbo].[tblEmployee] as E
on D.Department = E.Department
where D.Department = 'HR'

select *
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber

select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber
--Merge Joins
CREATE UNIQUE CLUSTERED INDEX [idx_tblEmployee] ON [dbo].[tblEmployee]
([EmployeeNumber])

GO

CREATE UNIQUE CLUSTERED INDEX [idx_tblTransaction] ON [dbo].[tblTransaction]
([EmployeeNumber],[TransactionDate],[Amount])

GO
select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber

select *
into dbo.tblEmployeeNoIndex
from dbo.tblEmployee

select *
into dbo.tblTransactionNoIndex
from dbo.tblTransaction

select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber

select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployeeNoIndex] as E
left join [dbo].[tblTransactionNoIndex] as T
on E.EmployeeNumber = T.EmployeeNumber
--Even bigger savings of time when using a SARG
select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber
where E.EmployeeNumber = 134

select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployeeNoIndex] as E
left join [dbo].[tblTransactionNoIndex] as T
on E.EmployeeNumber = T.EmployeeNumber
where E.EmployeeNumber = 134
select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber
where E.EmployeeNumber / 10 = 34 --Not SARG

select E.EmployeeNumber, T.Amount
from [dbo].[tblEmployee] as E
left join [dbo].[tblTransaction] as T
on E.EmployeeNumber = T.EmployeeNumber
where E.EmployeeNumber between 340 and 349 --SARG
GO


