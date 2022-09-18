using Microsoft.AspNetCore.Identity;

namespace Bed.Core.Models.UserRelated
{
    public class User : IdentityUser
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
