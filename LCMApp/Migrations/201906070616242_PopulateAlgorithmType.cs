namespace LCMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAlgorithmType : DbMigration
    {
        public override void Up()
        {
            

            Sql("SET IDENTITY_INSERT AlgorithmTypes ON");
            Sql("INSERT INTO AlgorithmTypes (Id, Name) VALUES (1, 'Best time complexity')");
            Sql("INSERT INTO AlgorithmTypes (Id, Name) VALUES (2, 'Best space complexity')");
            Sql("INSERT INTO AlgorithmTypes (Id, Name) VALUES (3, 'Optimal time and space complexity')");
        }
        
        public override void Down()
        {
        }
    }
}
