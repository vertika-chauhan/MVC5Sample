using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5.Dtos
{
    public class MemberShipTypeDto
    {
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public byte Id { get; set; }

        public string MembershipType { get; set; }
    }
}