namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCustomerDateToDateOfBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
            DropColumn("dbo.Customers", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Date", c => c.DateTime());
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
