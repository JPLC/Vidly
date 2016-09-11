namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'07f41ee8-1dc9-46cc-9230-3c190e87206d', N'guess@vidly.com', 0, N'AN85+5Vln5r3xRI8PrOLrlzCAH7hpEvas9bR2nMkDobIrU2Z4C8CKIqJlIC/6cQBjw==', N'25ab5794-cccf-41f7-b817-50df6436629a', NULL, 0, 0, NULL, 1, 0, N'guess@vidly.com')
                  INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'4ea9b10e-6fef-4ce6-9c4f-8ca957c0ee52', N'admin@vidly.com', 0, N'AIryFEohDNWYxZlNVKFMWZFJHXBMtYb3vpfFxai5RonZfmfRroED5GJRrLGJbEMuvA==', N'9caf4508-418f-49df-9aa1-33e936376a85', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')"
            );
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9fedb9bf-0ffc-4d2e-b198-5ed98f619129', N'CanManageMovies')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4ea9b10e-6fef-4ce6-9c4f-8ca957c0ee52', N'9fedb9bf-0ffc-4d2e-b198-5ed98f619129')");
        }

        public override void Down()
        {
        }
    }
}
