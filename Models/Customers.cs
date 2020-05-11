using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyWebApp.Models
{
    public class Customers
    {
        public int ID { get; set; }

       [StringLength(255)]
        public String CustomerName { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display(Name ="Memebership Type")]
        [Required]
        public byte MembershipTypeId { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}