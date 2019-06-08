namespace LCMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAlgorithmType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlgorithmTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Histories", "AlgorithmTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Histories", "AlgorithmTypeId");
            AddForeignKey("dbo.Histories", "AlgorithmTypeId", "dbo.AlgorithmTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Histories", "AlgorithmChosen");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Histories", "AlgorithmChosen", c => c.String());
            DropForeignKey("dbo.Histories", "AlgorithmTypeId", "dbo.AlgorithmTypes");
            DropIndex("dbo.Histories", new[] { "AlgorithmTypeId" });
            DropColumn("dbo.Histories", "AlgorithmTypeId");
            DropTable("dbo.AlgorithmTypes");
        }
    }
}
