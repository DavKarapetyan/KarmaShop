using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Karma.Models.Entities;
namespace Karma.Models
{
    public class KarmaDbContext : IdentityDbContext<User>
    {
        public KarmaDbContext(DbContextOptions<KarmaDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Sneakers> Sneakers { get; set; }
        public DbSet<SneakersColor> SneakersColors { get; set; }
        public DbSet<SneakersImage> SneakersImages { get; set; }
        public DbSet<SneakersSize> SneakersSizes { get; set; }
    }
}
