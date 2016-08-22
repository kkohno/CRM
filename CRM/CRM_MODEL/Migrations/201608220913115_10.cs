namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Summ = c.Double(),
                        Start = c.DateTime(),
                        End = c.DateTime(),
                        AdvertisingType_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdvertisingTypes", t => t.AdvertisingType_Id)
                .Index(t => t.AdvertisingType_Id);
            
            CreateTable(
                "dbo.AdvertisingTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Advertisings", "AdvertisingType_Id", "dbo.AdvertisingTypes");
            DropIndex("dbo.Advertisings", new[] { "AdvertisingType_Id" });
            DropTable("dbo.AdvertisingTypes");
            DropTable("dbo.Advertisings");
        }
    }
}
