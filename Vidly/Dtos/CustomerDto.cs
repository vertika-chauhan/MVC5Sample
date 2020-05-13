using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5.Dtos
{
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MemberShipTypeDto MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}