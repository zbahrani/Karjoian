using Microsoft.AspNetCore.Identity;


namespace Domain.Entities.Identity
{
    public class UserEntity:IdentityUser<Guid>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string NationalCode { get; set; }
    }
}
