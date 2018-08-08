namespace MovieHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4fe303db-9950-4c97-9c88-fea0dc496fe2', N'admin@moviehunt.com', 0, N'AKw9Xu/ohfa4tcIRFSb12gx9AowbauRZRZjVPqISqj/UeCe0XYTPHZIRscir7eouyQ==', N'26c7f64f-bd73-45b2-8da1-68e7a410d2bc', NULL, 0, 0, NULL, 1, 0, N'admin@moviehunt.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8524f189-6290-4ffb-928e-78cdd3231512', N'user@moviehunt.com', 0, N'AInhcWQD++SnumPrQPaA9MkG34hTcPI+E1X3UgJGXlj7e4Jzoy7ev1MobeEWTUDwCg==', N'5ca2cd5d-9ea9-4fe6-8af5-a3fb8877f5e7', NULL, 0, 0, NULL, 1, 0, N'user@moviehunt.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'97a7d88f-19c0-4588-8b3f-c183cb51bbc1', N'CanManageMovie')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4fe303db-9950-4c97-9c88-fea0dc496fe2', N'97a7d88f-19c0-4588-8b3f-c183cb51bbc1')

");
        }
        
        public override void Down()
        {
        }
    }
}
