INSERT INTO [dbo].[Students] ( [Name], [Address]) VALUES ( N'Allan ', N'no gade ')
INSERT INTO [dbo].[Students] ([Name], [Address]) VALUES ( N'Magda ', N'Smedegade ')
INSERT INTO [dbo].[Students] ([Name], [Address]) VALUES ( N'Test ', N'mørregade ')


INSERT INTO [dbo].[Courses] ([CourseName], [Credits]) VALUES ( N'SWD ',  7)
INSERT INTO [dbo].[Courses] ([CourseName], [Credits]) VALUES ( N'SWC ',  5)


INSERT INTO [dbo].[Enrollments] ([StudentId], [CourseId], [Grade]) VALUES (1, 1,  4)
INSERT INTO [dbo].[Enrollments] ([StudentId], [CourseId], [Grade]) VALUES (1, 2,  7)
INSERT INTO [dbo].[Enrollments] ([StudentId], [CourseId], [Grade]) VALUES (2, 2,  10)