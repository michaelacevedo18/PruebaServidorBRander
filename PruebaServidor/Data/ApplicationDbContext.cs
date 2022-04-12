using Microsoft.EntityFrameworkCore;
using PruebaServidor.Models;

namespace PruebaServidor.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<InterestedData> InteresteDatas { get; set; }
    }
}
