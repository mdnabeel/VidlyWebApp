using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWebApp.Models;

namespace VidlyWebApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customer { get; set; }
        
    }
}