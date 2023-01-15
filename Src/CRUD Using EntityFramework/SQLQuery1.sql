create database Teacher_Profile
use Teacher_Profile

Create table tbl_Teacher(
TeacherID int primary key identity(1,1),
Teacher_Name nvarchar(max),
Contact nvarchar(max),
Qualifcation nvarchar(max),
)

insert into tbl_Teacher values('Irfan Qundi','0238742364','Muree')


select*from tbl_Teacher