using Microsoft.EntityFrameworkCore;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = null!;
}
// Compare this snippet from Movies/Models/MovieContext.cs:
// using Microsoft.EntityFrameworkCore;