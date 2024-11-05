Create Database AB107
Create TABLE Students(
ID int primary key identity(1,1),
[Name] nvarchar(20),
Surname nvarchar(40),
Age int,
AvgPoint float
)
Insert into Students(Name,Surname,Age,AvgPoint)
values
('Ali','Guti',45,67),
('Ravan','Maharramli',19,78),
('Talib','Abilov',19,80),
('Juninho','Viera',26,85),
('David','Moreno',24,46),
('Gil','Brayan',21,66),
('Al-Wahda','Gutierrez',25,98),
('Muarram','Mubarak',27,88),
('Kanan','Eyvazov',19,74)

Select * from Students where AvgPoint>51;
Select * from Students where AvgPoint>51 AND AvgPoint<91;
Select * from Students where Name like 'A%i';
