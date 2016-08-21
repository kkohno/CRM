namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sales", "User_Id", "dbo.Users");
            DropIndex("dbo.Sales", new[] { "User_Id" });
            AddColumn("dbo.Sales", "Person_Id", c => c.Long());
            CreateIndex("dbo.Sales", "Person_Id");
            AddForeignKey("dbo.Sales", "Person_Id", "dbo.People", "Id");
            DropColumn("dbo.Sales", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "User_Id", c => c.Long());
            DropForeignKey("dbo.Sales", "Person_Id", "dbo.People");
            DropIndex("dbo.Sales", new[] { "Person_Id" });
            DropColumn("dbo.Sales", "Person_Id");
            CreateIndex("dbo.Sales", "User_Id");
            AddForeignKey("dbo.Sales", "User_Id", "dbo.Users", "Id");
        }
    }
}
