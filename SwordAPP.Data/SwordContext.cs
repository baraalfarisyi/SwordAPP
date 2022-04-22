using Microsoft.EntityFrameworkCore;
using SwordAPP.Domain1;

namespace SwordAPP.Data
{
    public class SwordContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Sword> Swords { get; set; }
        public DbSet<Elemen> Elemens { get; set; }
    }
}