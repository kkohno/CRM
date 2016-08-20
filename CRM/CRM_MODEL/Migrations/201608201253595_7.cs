namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GoodStorageItems", "PurchasePrice", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GoodStorageItems", "PurchasePrice", c => c.Double(nullable: false));
        }
    }
}
