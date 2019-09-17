namespace EFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LengthField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Length", c => c.Int(nullable: false, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Length");
        }
    }
}
