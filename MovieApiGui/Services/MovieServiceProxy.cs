using System;
using System.Collections.Generic;
using MovieApiGui.Models;

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

    public List<MovieInfo>? GetMovies(string searchString)
    {
        List<MovieInfo>? list = null;
        try
        {
            list = _tmdbService?.GetMovies(searchString);
            return list;
        }
        catch (Exception)
        {
            try
            {
                list = _omdbService?.GetMovies(searchString);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}