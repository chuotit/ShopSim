namespace ShopSim.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FirstNumbers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NetworkID = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SimNetworks", t => t.NetworkID, cascadeDelete: true)
                .Index(t => t.NetworkID);
            
            CreateTable(
                "dbo.SimNetworks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Alias = c.String(nullable: false, maxLength: 255, unicode: false),
                        Image = c.String(),
                        Description = c.String(),
                        MetaDescription = c.String(),
                        MetaKeywork = c.String(),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FirstNumbers", "NetworkID", "dbo.SimNetworks");
            DropIndex("dbo.FirstNumbers", new[] { "NetworkID" });
            DropTable("dbo.SimNetworks");
            DropTable("dbo.FirstNumbers");
        }
    }
}
