using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWebApp.Models;

namespace VidlyWebApp.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customers { get; set; }
    }
}