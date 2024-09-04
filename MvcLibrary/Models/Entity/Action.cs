namespace MvcLibrary.Models.Entity
{
    public class Action
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public Personel Personel { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateTime DateOfRefund { get; set; }

    }
}
