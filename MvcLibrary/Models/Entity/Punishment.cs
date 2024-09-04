namespace MvcLibrary.Models.Entity
{
    public class Punishment
    {
        public int  Id { get; set; }
        public Member Member { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public int Amount { get; set; }
       public Action Action { get; set; }
    }
}
