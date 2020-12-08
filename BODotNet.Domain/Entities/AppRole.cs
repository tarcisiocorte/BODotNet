using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Tccp.Domain.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}