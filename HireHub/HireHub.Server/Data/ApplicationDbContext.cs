using Microsoft.EntityFrameworkCore;
using HireHub.Server.Module;

namespace HireHub.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<JobOpening> jobOpenings { get; set; }

    }
}
