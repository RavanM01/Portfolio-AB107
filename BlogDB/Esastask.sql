Create Database BlogsDB

Create Table Categories(
Id int identity primary key,
[Name] nvarchar(50) not null unique
)
Create Table Tags(
Id int identity primary key,
[Name] nvarchar(50) not null unique
)
Create Table Users(
Id int identity primary key,
UserName nvarchar(50) not null unique,
FullName nvarchar(80) not null,
Age int CHECK (Age BETWEEN 0 AND 150)
)
CREATE TABLE Blogs (
    Id INT PRIMARY KEY identity,
    Title VARCHAR(50) NOT NULL,
    Description TEXT NOT NULL,
    UserId INT,
    CategoryId INT,
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id) 
)
CREATE TABLE Comments (
    Id INT IDENTITY PRIMARY KEY,
    Content NVARCHAR(250) NOT NULL CHECK (LEN(Content) <= 250 and LEN(Content) > 0),
    UserId INT,
    BlogId INT,
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (BlogId) REFERENCES Blogs(Id)
);

CREATE TABLE Blogs_Tags (
    BlogId INT,
    TagId INT,
    PRIMARY KEY (BlogId, TagId),
    FOREIGN KEY (BlogId) REFERENCES Blogs(Id),
    FOREIGN KEY (TagId) REFERENCES Tags(Id)
)


INSERT INTO Categories([Name]) VALUES
('Technology'),
('Health'),
('Travel'),
('Education'),
('Food');

INSERT INTO Tags (Name) VALUES
('AI'),
('Nutrition'),
('Adventure'),
('Science'),
('Recipe');

INSERT INTO Users (UserName, FullName, Age) VALUES
('tech_guru', 'Ali Mammadov', 30),
('health_enthusiast', 'Leyla Aliyeva', 27),
('world_traveler', 'Kamran Rustamov', 35),
('edu_expert', 'Gulnar Huseynova', 40),
('food_lover', 'Nigar Safarova', 29);

INSERT INTO Blogs (Title, Description, UserId, CategoryId) VALUES
('AI Revolution', 'Exploring the impact of AI on various industries.', 1, 1),
('Healthy Living', 'Tips for a balanced diet and active lifestyle.', 2, 2),
('Top 10 Destinations', 'A guide to the best places to travel this year.', 3, 3),
('Learning in the Digital Age', 'How technology is transforming education.', 4, 4),
('Delicious Desserts', 'Recipes for mouth-watering desserts.', 5, 5);

INSERT INTO Comments (Content, UserId, BlogId) VALUES
('Gozal malumat!',2, 1),
('Very helpful tips, thanks!', 3, 2),
('Adding these places to my travel list!', 1, 3),
('Informative read on digital learning.', 5, 4),
('Can’t wait to try these recipes!', 4, 5);


CREATE VIEW BlogUserView AS
SELECT 
    Blogs.Title,
    Users.UserName,
    Users.FullName
FROM 
    Blogs
JOIN 
    Users ON Blogs.UserId = Users.Id;

Select * from BlogUserView

Create View BlogTitleView AS
Select
	Blogs.Title,
	Categories.[Name]
From 
	Blogs
Join Categories on Blogs.CategoryId=Categories.Id

Select * from BlogTitleView

CREATE PROCEDURE usp_GetUserComments
    @userId INT
AS

    SELECT 
        Comments.Id,
        Comments.Content,
        Comments.BlogId,
        Comments.UserId
    FROM 
        Comments
    WHERE 
        Comments.UserId = @userId;

EXEC usp_GetUserComments @userId=4


CREATE PROCEDURE usp_GetUserBlogs
    @userId INT
AS

    SELECT 
        Blogs.Id,
        Blogs.Title,
        Blogs.Description,
        Blogs.UserId,
        Blogs.CategoryId
    FROM 
        Blogs
    WHERE 
        Blogs.UserId = @userId;

Exec usp_GetUserBlogs 5


Create Function GetBlogCountbyCategoryId (@categoryId int) RETURNS INT
as
begin
DECLARE @BlogCount INT;

    SELECT 
        @BlogCount = COUNT(*)
    FROM 
        Blogs
    WHERE 
        CategoryId = @categoryId;

    RETURN @BlogCount;
end

Select dbo.GetBlogCountbyCategoryId('1')


Create Function GetBlogCountbyUserId (@userId int) RETURNS INT
as
begin
DECLARE @BlogCount INT;

    SELECT 
        @BlogCount = COUNT(*)
    FROM 
        Blogs
    WHERE 
        UserId = @userId;

    RETURN @BlogCount;
end

select dbo.GetBlogCountbyUserId('2')

