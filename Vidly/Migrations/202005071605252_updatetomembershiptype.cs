namespace MVC5.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updatetomembershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("update [MemberShipTypes] set [MembershipType]='Pay as You Go' where discountRate=0");
            Sql("update [MemberShipTypes] set [MembershipType]='Monthly' where discountRate=10");
            Sql("update [MemberShipTypes] set [MembershipType]='For 3 Months' where discountRate=15");
            Sql("update [MemberShipTypes] set [MembershipType]='For 1 year' where discountRate=20");
        }

        public override void Down()
        {
        }
    }
}
