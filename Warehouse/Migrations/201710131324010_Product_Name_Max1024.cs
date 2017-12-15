namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product_Name_Max1024 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
