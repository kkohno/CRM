namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        CurrentSellingPrice = c.Double(nullable: false),
                        Comment = c.String(),
                        GoodType_Id = c.Long(),
                        Provider_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GoodTypes", t => t.GoodType_Id)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .Index(t => t.GoodType_Id)
                .Index(t => t.Provider_Id);
            
            CreateTable(
                "dbo.References",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ReferenceString = c.String(nullable: false),
                        Comment = c.String(),
                        Good_Id = c.Long(),
                        Provider_Id = c.Long(),
                        Good_Id1 = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Good_Id)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .ForeignKey("dbo.Goods", t => t.Good_Id1)
                .Index(t => t.Good_Id)
                .Index(t => t.Provider_Id)
                .Index(t => t.Good_Id1);
            
            CreateTable(
                "dbo.GoodTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false),
                        Comment = c.String(),
                        Provider_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .Index(t => t.Provider_Id);
            
            CreateTable(
                "dbo.GoodStorageItems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        ReceivingDate = c.DateTime(),
                        ShelfLife = c.DateTime(),
                        Good_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Good_Id, cascadeDelete: true)
                .Index(t => t.Good_Id);
            
            CreateTable(
                "dbo.LoginPasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Pass = c.String(nullable: false),
                        User_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Login, unique: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name1 = c.String(nullable: false),
                        Name2 = c.String(),
                        Name3 = c.String(),
                        Rights = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SellingPrice = c.Double(nullable: false),
                        Count = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Good_Id = c.Long(nullable: false),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Good_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Good_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Sales", "Good_Id", "dbo.Goods");
            DropForeignKey("dbo.LoginPasses", "User_Id", "dbo.Users");
            DropForeignKey("dbo.GoodStorageItems", "Good_Id", "dbo.Goods");
            DropForeignKey("dbo.References", "Good_Id1", "dbo.Goods");
            DropForeignKey("dbo.Goods", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.References", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.Phones", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.Goods", "GoodType_Id", "dbo.GoodTypes");
            DropForeignKey("dbo.References", "Good_Id", "dbo.Goods");
            DropIndex("dbo.Sales", new[] { "User_Id" });
            DropIndex("dbo.Sales", new[] { "Good_Id" });
            DropIndex("dbo.LoginPasses", new[] { "User_Id" });
            DropIndex("dbo.LoginPasses", new[] { "Login" });
            DropIndex("dbo.GoodStorageItems", new[] { "Good_Id" });
            DropIndex("dbo.Phones", new[] { "Provider_Id" });
            DropIndex("dbo.References", new[] { "Good_Id1" });
            DropIndex("dbo.References", new[] { "Provider_Id" });
            DropIndex("dbo.References", new[] { "Good_Id" });
            DropIndex("dbo.Goods", new[] { "Provider_Id" });
            DropIndex("dbo.Goods", new[] { "GoodType_Id" });
            DropTable("dbo.Sales");
            DropTable("dbo.Users");
            DropTable("dbo.LoginPasses");
            DropTable("dbo.GoodStorageItems");
            DropTable("dbo.Phones");
            DropTable("dbo.Providers");
            DropTable("dbo.GoodTypes");
            DropTable("dbo.References");
            DropTable("dbo.Goods");
        }
    }
}
