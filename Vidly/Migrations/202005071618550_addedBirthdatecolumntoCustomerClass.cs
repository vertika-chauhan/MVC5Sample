namespace MVC5.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addedBirthdatecolumntoCustomerClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
