namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Goods", "PurchasePrice", c => c.Double());
            AlterColumn("dbo.Goods", "CurrentSellingPrice", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Goods", "CurrentSellingPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Goods", "PurchasePrice", c => c.Double(nullable: false));
        }
    }
}
