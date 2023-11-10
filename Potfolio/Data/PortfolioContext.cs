namespace Potfolio.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class PortfolioContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Profile>()
                .HasOne(e => e.User)
                .WithOne(e => e.Profile)
                .IsRequired()
                .HasForeignKey<Profile>(e => e.Id);

            base.OnModelCreating(builder);
        }

        public DbSet<User> Users {  get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}
