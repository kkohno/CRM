namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name1 = c.String(nullable: false),
                        Name2 = c.String(),
                        Name3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Person_Id", c => c.Long());
            CreateIndex("dbo.Users", "Person_Id");
            AddForeignKey("dbo.Users", "Person_Id", "dbo.People", "Id");
            DropColumn("dbo.Users", "Name1");
            DropColumn("dbo.Users", "Name2");
            DropColumn("dbo.Users", "Name3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Name3", c => c.String());
            AddColumn("dbo.Users", "Name2", c => c.String());
            AddColumn("dbo.Users", "Name1", c => c.String(nullable: false));
            DropForeignKey("dbo.Users", "Person_Id", "dbo.People");
            DropIndex("dbo.Users", new[] { "Person_Id" });
            DropColumn("dbo.Users", "Person_Id");
            DropTable("dbo.People");
        }
    }
}
