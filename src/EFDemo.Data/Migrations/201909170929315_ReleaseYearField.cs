namespace EFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReleaseYearField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "ReleaseYear", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "ReleaseYear");
        }
    }
}
