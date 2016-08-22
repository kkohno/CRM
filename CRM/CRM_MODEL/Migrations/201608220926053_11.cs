namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisingTypes", "Reference", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdvertisingTypes", "Reference");
        }
    }
}
