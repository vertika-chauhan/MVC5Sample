namespace MVC5.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addedtypetoMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "MembershipType", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "MembershipType");
        }
    }
}
