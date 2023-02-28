global using Microsoft.EntityFrameworkCore;

namespace SuperHerosApi.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.//SQLExpress;Database=suoerherobd;Trusted_Connection=true;TrustServicerCertificate=true;");
		}

		public DbSet<SuperHero> SuperHeroes { get; set; }

	}
}

