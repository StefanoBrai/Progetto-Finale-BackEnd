using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace ProgettoFinaleBack
{
    public class ProgettoFinaleContext : DbContext
    {
        public DbSet<Mail> Mails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pippo;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        
    }
}