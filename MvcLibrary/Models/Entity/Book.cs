using MvcLibrary.Models.Entity.Common;

namespace MvcLibrary.Models.Entity
{
    public class Book:BaseEntity
    {
        public Category Category { get; set; }
        public Author Author { get; set; }
        public string YearOfPublication { get; set; }
        public string Publisher { get; set; }
        public int Page { get; set; }
        public Boolean State { get; set; }
    }
}
