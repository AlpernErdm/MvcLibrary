using Microsoft.EntityFrameworkCore;
using MvcLibrary.Models.Entity;
using Action = MvcLibrary.Models.Entity.Action;

namespace MvcLibrary.Models.Base
{
    public class ModelContext:DbContext
    {
        public ModelContext(DbContextOptions<ModelContext>options):base(options)
        { }
        DbSet<Author> Authories { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Member> Members { get; set; }
        DbSet<MoneyBox> MoneyBoxes { get; set; }
        DbSet<Personel> Personels { get; set; }
        DbSet<Punishment> Punishments { get; set; }
        DbSet<Action> Actions { get; set; }
    }
}
