﻿namespace EFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Rating");
        }
    }
}
