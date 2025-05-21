using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{

    private readonly ILogger<MoviesController> _logger;

    public MoviesController(ILogger<MoviesController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetMovies")]
    public IActionResult GetMovies()
    {
        _logger.LogInformation("Fetching movies from the database.");
        var movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16) },
            new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18) }
        };

        return Ok(movies);
    }
    [HttpGet("GetMovie/{id}")]
    public IActionResult GetMovie(int id)
    {
        _logger.LogInformation($"Fetching movie with ID: {id}");
        var movie = new Movie { Id = id, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16) };

        if (movie == null)
        {
            return NotFound();
        }

        return Ok(movie);
    }
    [HttpGet("env")]
    public IActionResult GetEnv()
    {
        var value = Environment.GetEnvironmentVariable("MySettingKey");
        return Ok($"Env value: {value}");
    }
}


