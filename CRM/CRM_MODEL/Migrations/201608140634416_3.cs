namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Summ = c.Double(),
                        Comment = c.String(),
                        PaymentType_Id = c.Long(nullable: false),
                        Person_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .Index(t => t.PaymentType_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Payments", "PaymentType_Id", "dbo.PaymentTypes");
            DropIndex("dbo.Payments", new[] { "Person_Id" });
            DropIndex("dbo.Payments", new[] { "PaymentType_Id" });
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Payments");
        }
    }
}
