namespace CRM_MODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisingTypes", "Rating", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdvertisingTypes", "Rating");
        }
    }
}
