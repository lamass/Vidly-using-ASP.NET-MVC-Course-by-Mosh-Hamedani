namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreClass : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (3, 'Action/Adventure')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (4, 'Horror')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (5, 'Documentary')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (6, 'Childrens')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (7, 'Animation/Anime')");
        }
        
        public override void Down()
        {
        }
    }
}
