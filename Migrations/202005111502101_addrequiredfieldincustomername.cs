namespace VidlyWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequiredfieldincustomername : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(maxLength: 255));
        }
    }
}
