using Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Domain.Aggregate.Users
{
    public class Role : IdentityRole<int>, IEntity
    {
        public string Description { get; set; }
    }
}
