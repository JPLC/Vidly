namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SolvingErrorMigration : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[Customers] ([Name], [IsSubscribedToNewsletter], [MembershipTypeId], [BirthDate]) VALUES
                (N'John Smith',         0,  1,  N'1980-01-01 00:00:00'),
                (N'Mary Williams',	    1,	2,	NULL),
                (N'Mosh Hamedani',	    0,	3,	NULL),
                (N'Joao Caetano',	    1,	4,	N'1989-03-27 00:00:00'),
                (N'Pedro Lourenco',	    0,	1,	N'1989-03-27 00:00:00'),
                (N'Manuel Caetano',	    1,	2,	N'1976-04-26 00:00:00'),
                (N'Maria Caetano',	    0,	3,	N'1959-10-31 00:00:00'),
                (N'Antonio Caetano',	1,	4,	N'1949-03-12 00:00:00'),
                (N'Rui Vitoria',	    0,	1,	NULL),
                (N'Lewis Caetano',	    1,	1,	N'2000-01-01 00:00:00'),
                (N'Bill Gates',	        0,	2,	NULL),
                (N'Mary Williams',	    1,	3,	NULL)");

            Sql(@"INSERT INTO[dbo].[Movies] ([Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId]) VALUES
                (N'Pulp Fiction',               N'1994-11-25 00:00:00', N'2015-01-30 00:00:00', 2,  1),
                (N'Seven',				        N'1995-02-02 00:00:00',	N'2014-03-18 00:00:00',	5,	2),
                (N'Lion King',			        N'1994-12-02 00:00:00',	N'2013-02-09 00:00:00',	8,	3),
                (N'Titanic',			        N'1997-01-16 00:00:00',	N'2010-07-03 00:00:00',	3,	4),
                (N'Wedding Crashers',	        N'2005-08-01 00:00:00',	N'2011-06-05 00:00:00',	12,	5),
                (N'The Godfather Part 1',	    N'1972-08-01 00:00:00',	N'2012-12-22 00:00:00',	10,	1),
                (N'The Godfather Part 1',	    N'1976-08-01 00:00:00',	N'2015-11-19 00:00:00',	17,	1),
                (N'Goodfellas',	                N'1990-08-01 00:00:00',	N'2016-10-13 00:00:00',	1,	1),
                (N'The Wolf of Wall Street',	N'2013-08-01 00:00:00',	N'2014-09-30 00:00:00',	20,	4),
                (N'Fight Club',     	        N'1999-08-01 00:00:00',	N'2012-04-05 00:00:00',	19,	5),
                (N'Matrix',	                    N'1999-06-25 00:00:00',	N'2013-05-03 00:00:00',	13,	1),
                (N'Scarface',	                N'1983-04-12 00:00:00',	N'2016-08-25 00:00:00',	13,	2)");
        }

        public override void Down()
        {

        }
    }
}
