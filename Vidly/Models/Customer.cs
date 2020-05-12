using System;
using System.ComponentModel.DataAnnotations;

namespace MVC5.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MemberShipType MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}