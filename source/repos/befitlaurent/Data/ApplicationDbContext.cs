using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using befitlaurent.Models;

namespace befitlaurent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<befitlaurent.Models.ExerciseType> ExerciseType { get; set; } = default!;
        public DbSet<befitlaurent.Models.Session> Session { get; set; } = default!;
        public DbSet<befitlaurent.Models.Exercise> Exercise { get; set; } = default!;
    }
}
