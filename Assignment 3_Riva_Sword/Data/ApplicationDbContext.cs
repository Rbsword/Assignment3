using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment_3_Riva_Sword.Models;

namespace Assignment_3_Riva_Sword.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment_3_Riva_Sword.Models.Actor> Actor { get; set; }
        public DbSet<Assignment_3_Riva_Sword.Models.Movie> Movie { get; set; }
        public DbSet<Assignment_3_Riva_Sword.Models.MovieActor> MovieActor { get; set; }
    }
}