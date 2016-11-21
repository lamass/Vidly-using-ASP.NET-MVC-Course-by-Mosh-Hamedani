namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7432aaa0-7b5b-4e89-be9c-7dce579013b0', N'swmooneyham@gmail.com', 0, N'AFO0KDUhtfTrkZm9WVqqQfOVnN9OIVDCwrbUnll8V6Mv8I8oj8/p4xkC6qacHuJdRQ==', N'29a1f6b2-d590-4082-b88f-b1745c81a001', NULL, 0, 0, NULL, 1, 0, N'swmooneyham@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dee1dee1-818b-4742-a736-e348850fb906', N'admin@vidly.com', 0, N'AEkXUcvePgObsEFxS45J3hXo5RPlZhWgNwUTNQ4wxzDjGpqW6oDxdm4XzVzdmrtaiw==', N'0ccd246c-349a-4432-9477-2e963e471e4a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ce93161a-988b-462d-8834-dc137521fe5a', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dee1dee1-818b-4742-a736-e348850fb906', N'ce93161a-988b-462d-8834-dc137521fe5a')

");
        }
        
        public override void Down()
        {
        }
    }
}
