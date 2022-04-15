using System;
using System.Net;
using System.Text;
using MovieApiGui.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace MovieApiGui.Services;


public class TmdbService : IMovieService
{
    private readonly string? _apiKey;

    private const string Website = "https://api.themoviedb.org/3/search/movie";

    private readonly WebClient _client;
    
    public TmdbService(string? apiKey)
    {
        _apiKey = apiKey;
        _client = new WebClient();
        _client.Encoding = Encoding.UTF8;
    }


    public List<MovieInfo>? GetMovies(string searchString)
    {
        var json = _client.DownloadString(Website +
                               $"?api_key={_apiKey}&language=en-US&query={searchString}&page=1&include_adult=false");
        var list = JsonSerializer.Deserialize<TmdbMovieInfoSearchCollection>(json)?.Results;
        var movieInfos = list?.Select(x => new MovieInfo(x)).ToList();
        if (movieInfos?.Count == 0)
        {
            throw new ArgumentException("Movie not found");
        }
        return movieInfos;
    }
}