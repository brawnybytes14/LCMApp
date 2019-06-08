namespace LCMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Histories", "Inputs", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Histories", "Inputs", c => c.String());
        }
    }
}
