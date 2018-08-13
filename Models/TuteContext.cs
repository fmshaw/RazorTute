using Microsoft.EntityFrameworkCore;

namespace RazorTute.Models
{
    public class TuteContext : DbContext
    {
        public TuteContext(DbContextOptions<TuteContext> options)
	        : base(options)
	{
	}

	public DbSet<Location> Location { get; set; }
    }
}
