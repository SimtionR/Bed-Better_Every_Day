using System.Security.AccessControl;

namespace Bed.Core.Models.UserRelated
{
    public class Profile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        

    }
}
