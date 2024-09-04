using MvcLibrary.Models.Entity.Common;

namespace MvcLibrary.Models.Entity
{
    public class Member:BaseEntity
    {
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public string PhotoUrl { get; set; }
        public string  TelephoneNumber { get; set; }
    }
}
