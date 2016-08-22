namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreNameToTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (8, 'SciFi/Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
