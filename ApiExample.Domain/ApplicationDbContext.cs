using ApiExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Domain
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalItem> GoalItems { get; set; }
    }
}
