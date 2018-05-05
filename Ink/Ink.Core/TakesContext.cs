using Ink.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ink.Core
{
    public class TakesContext : IdentityDbContext <ApplicationUser> 
    {
        public TakesContext(DbContextOptions/*<TakesContext>*/ options) : base(options)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Taking> Takings { get; set; }
        public DbSet<TakeDetail> TakeDetails { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CourseConfiguration());
            /*modelBuilder.HasDefaultSchema("Production");
   modelBuilder.ApplyConfiguration(new ProductConfiguration());*/

            modelBuilder.Entity<CompanyUser>()
            .HasKey(t => new { t.UserId, t.CompanyId });
            /*modelBuilder.Entity<Center>().HasOptional(b => b.ParentCenter)
                                  .WithMany(b => b.Children)
                                  .HasForeignKey(b => b.ParentCenterId);*/

            //builder.HasOne(e => e.Details).WithOne( o=> o.Product).HasForeignKey<ProductDetail>(e => e.ProductID);
            modelBuilder.Entity<Taking>().HasOne<Center>(c => c.Center).WithMany(t => t.Takings).HasForeignKey(c => c.CenterId);
            modelBuilder.Entity<Item>().HasOne<Company>(c => c.Company).WithMany(i => i.Items).HasForeignKey(c => c.CompanyId);
            modelBuilder.Entity<Center>().HasOne<Company>(c => c.Company).WithMany(ct => ct.Centers).HasForeignKey(c => c.CompanyId);

            base.OnModelCreating(modelBuilder);

        }

    }
}
