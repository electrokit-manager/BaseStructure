using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Domain.Aggregate.Users
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public GenderType? Gender { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string NationalCode { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
