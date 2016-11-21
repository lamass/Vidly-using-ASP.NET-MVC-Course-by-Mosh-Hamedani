namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatementToMovie : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Available = InStock");
        }
        
        public override void Down()
        {
        }
    }
}
