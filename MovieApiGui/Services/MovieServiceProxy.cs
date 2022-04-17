using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MovieApiGui.Models;

namespace MovieApiGui.Services;

public class MovieServiceProxy : IMovieService
{
    private readonly OmdbService? _omdbService;
    private readonly TmdbService? _tmdbService;
    
    private Dictionary<string, MovieInfo?> _movieInfos; // cache movie results
    private Dictionary<string, List<SearchInfo>?> _searchMovie; // cache search results
    
    public MovieServiceProxy(TmdbService tmdbService, OmdbService omdbService)
    {
        _tmdbService = tmdbService;
        
        _omdbService = omdbService;

        _movieInfos = new Dictionary<string, MovieInfo?>();

        _searchMovie = new Dictionary<string, List<SearchInfo>?>();
    }

    public List<SearchInfo>? GetMovies(string searchString)
    {
        if (_searchMovie.ContainsKey(searchString))
        {
            return _searchMovie[searchString];
        }
        List<SearchInfo>? list;
        try
        {
            list = _tmdbService?.GetMovies(searchString);
            _searchMovie.Add(searchString, list); // cache the fetched data
            return list;
        }
        catch (Exception)
        {
            try
            {
                list = _omdbService?.GetMovies(searchString);
                _searchMovie.Add(searchString, list); // cache the fetched data
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
    
    public MovieInfo? GetMovieByTitle(string title)
    {
        if (_movieInfos.ContainsKey(title))
        {
            return _movieInfos[title];
        }
        MovieInfo? movieInfo;
        try
        {
            movieInfo = _tmdbService?.GetMovieByTitle(title);
            _movieInfos.Add(title, movieInfo);
            return movieInfo;
        }
        catch (Exception)
        {
            try
            {
                movieInfo = _omdbService?.GetMovieByTitle(title);
                _movieInfos.Add(title, movieInfo);
                return movieInfo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}