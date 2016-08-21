namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "PurchasePrice", c => c.Double());
            AlterColumn("dbo.GoodStorageItems", "Count", c => c.Int());
            AlterColumn("dbo.Sales", "SellingPrice", c => c.Double());
            AlterColumn("dbo.Sales", "Count", c => c.Int());
            AlterColumn("dbo.Sales", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sales", "Count", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "SellingPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.GoodStorageItems", "Count", c => c.Int(nullable: false));
            DropColumn("dbo.Sales", "PurchasePrice");
        }
    }
}
