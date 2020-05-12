namespace MVC5.Models
{
    public class MemberShipType
    {
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public byte Id { get; set; }

        public string MembershipType { get; set; }

    }
}