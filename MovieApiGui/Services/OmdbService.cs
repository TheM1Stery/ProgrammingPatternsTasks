using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using MovieApiGui.Models;

namespace MovieApiGui.Services;

public class OmdbService : IMovieService
{
    private readonly string? _apiKey;

    private const string Website = $"http://www.omdbapi.com/"; 

    private readonly WebClient _client;

    public OmdbService(string? apiKey)
    {
        _apiKey = apiKey;
        _client = new WebClient();
        _client.Encoding = Encoding.UTF8;
    }

    public List<MovieInfo>? GetMovies(string searchString)
    {
        var json = _client.DownloadString(Website + $"?apikey={_apiKey}&type=movie&page=1&s={searchString}");
        var list = JsonSerializer.Deserialize<OmdbMovieInfoSearchCollection>(json)?.Search;
        var movieInfos = list?.Select(x => new MovieInfo(x)).ToList();
        if (movieInfos is null)
        {
            throw new ArgumentException("Movie not found");
        }
        return movieInfos;
    }
}