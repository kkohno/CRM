namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        MailString = c.String(nullable: false),
                        Comment = c.String(),
                        Provider_Id = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .Index(t => t.Provider_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mails", "Provider_Id", "dbo.Providers");
            DropIndex("dbo.Mails", new[] { "Provider_Id" });
            DropTable("dbo.Mails");
        }
    }
}
