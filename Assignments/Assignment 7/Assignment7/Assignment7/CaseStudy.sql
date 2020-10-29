create database Casestudy
use Casestudy

create table StudentDetails (StudentID int, StudentName nvarchar(40), DOB date)
alter table StudentDetails alter column DOB nvarchar(20)
alter table StudentDetails alter column StudentID int not null
alter table StudentDetails add primary key (StudentId)
select * from StudentDetails
insert into StudentDetails values (101, 'Arul', '24/08/1997'),(102,'Selvan','19/06/1997'),(103,'Raju','15/04/2000'),(104, 'Prema','24/05/1994')

create table Course (CourseId int primary key, CourseName nvarchar(30), Duration int, Fees int)
insert into Course values (1001,'.Net',15,7500),(1002,'TSL',18,6500),(1003,'java',20,7000),(1004,'Agile',16,15000)
select * from Course

create table Enroll(StudentId int references StudentDetails(StudentId) on delete cascade on update cascade, CourseId int references
Course(CourseId) on delete cascade on update cascade, DateofEnroll date)

create procedure StuReg(@id int, @name nvarchar(20),@dob nvarchar(20))
as
begin
insert into StudentDetails values(@id,@name, @dob)
end
exec StuReg @id=101,@name='arul', @dob='24/08/1997'

create Procedure AddCourse(@id int, @name nvarchar(20), @duration int, @fees int)
as
begin
insert into Course values(@id,@name,@duration,@fees)
end

