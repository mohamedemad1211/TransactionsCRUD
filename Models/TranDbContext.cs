using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class TranDbContext:DbContext
    {
        public TranDbContext(DbContextOptions<TranDbContext> options) : base(options)
        {
                
        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
