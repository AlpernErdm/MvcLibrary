using MvcLibrary.Models.Entity.Common;

namespace MvcLibrary.Models.Entity
{
    public class Author:BaseEntity
    {
        public string Surname { get; set; }
        public string Details { get; set; }
    }
}
