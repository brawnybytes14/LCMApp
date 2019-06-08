namespace LCMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Histories", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Histories", "UserId");
            AddForeignKey("dbo.Histories", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Histories", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Histories", new[] { "UserId" });
            DropColumn("dbo.Histories", "UserId");
        }
    }
}
