using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Identity
{
    public class UserEntity:IdentityUser<Guid>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string NationalCode { get; set; }
    }
}
