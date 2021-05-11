using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace PortCartier.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual List<Loan> Loans { get; set; }

        public virtual List<Request> Requests { get; set; }
    }
}