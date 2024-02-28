using Microsoft.EntityFrameworkCore;
using SoalA.Models;

namespace SoalA.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var conn = string.Format(@"Data Source=DESKTOP-0RKH9KJ;Initial Catalog=DocumentDB;Persist Security Info=True;User ID=sa;Password=141186;Encrypt=False;");
            options.UseSqlServer(conn);
        }
        public DbSet<Produk> Produks { get; set; }
    }
}
