namespace MovieApiGui.Services;

public class MovieServiceProxy : IMovieService
{
    private readonly OmdbService? _omdbService;
    private readonly TmdbService? _tmdbService;

    public MovieServiceProxy(TmdbService tmdbService, OmdbService omdbService)
    {
        _tmdbService = tmdbService;
        _omdbService = omdbService;
    }
}