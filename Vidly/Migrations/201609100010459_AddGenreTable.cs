namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 255),
                    GenreId = c.Byte(nullable: false),
                    ReleaseDate = c.DateTime(nullable: false),
                    DateAdded = c.DateTime(nullable: false),
                    NumberInStock = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);

            CreateTable(
                "dbo.Genres",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 255),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}