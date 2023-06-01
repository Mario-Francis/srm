using Microsoft.EntityFrameworkCore;

namespace MartyWally.SRM.Models
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{
		}

		public DbSet<Supplier> Suppliers { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Supplier>(s =>
			{
				s.HasKey(s => s.Id);
				s.HasMany(s => s.Products).WithOne(p => p.Supplier).HasForeignKey(p => p.SupplierId);
				s.HasIndex(s => s.Name).IsUnique();
			});

			modelBuilder.Entity<Product>(p =>
			{
				p.HasKey(p => p.Id);
				p.HasIndex(p => new { p.Name, p.SupplierId }).IsUnique();
			});
        }
    }
}

