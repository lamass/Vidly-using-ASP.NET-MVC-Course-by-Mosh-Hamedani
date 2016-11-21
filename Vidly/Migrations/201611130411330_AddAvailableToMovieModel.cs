namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Available", c => c.Byte(nullable: false));
            Sql("UPDATE Movies SET Available = InStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Available");
        }
    }
}
