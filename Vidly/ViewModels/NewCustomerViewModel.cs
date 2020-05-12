using MVC5.Models;
using System.Collections.Generic;

namespace MVC5.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> MembershipTypes { get; set; }
        public Customer customer { get; set; }

    }
}