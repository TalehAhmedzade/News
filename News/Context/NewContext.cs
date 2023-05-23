using Microsoft.EntityFrameworkCore;
using News.Entities;

namespace News.Context
{
	public class NewContext : DbContext
	{
		public NewContext(DbContextOptions<NewContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<New> News { get; set; }

	}
}
