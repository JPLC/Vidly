INSERT INTO [dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [BirthDate]) VALUES 
(N'John Smith',		0,	1,	N'1980-01-01 00:00:00'),
(N'Mary Williams',	1,	2,	NULL)

INSERT INTO [dbo].[Movies] ([Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES
(N'Pulp Fiction',		N'1994-11-25 00:00:00',	N'2015-01-30 00:00:00',	2,	1),
(N'Seven',				N'1995-02-02 00:00:00',	N'2014-03-18 00:00:00',	5,	2),
(N'Lion King',			N'1994-12-02 00:00:00',	N'2013-02-09 00:00:00',	8,	3),
(N'Titanic',			N'1997-01-16 00:00:00',	N'2010-07-03 00:00:00',	3,	4),
(N'Wedding Crashers',	N'2005-08-01 00:00:00',	N'2016-10-05 00:00:00',	10,	5)