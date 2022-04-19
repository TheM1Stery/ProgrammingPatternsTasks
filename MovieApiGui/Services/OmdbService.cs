using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using MovieApiGui.Models;
using MovieApiGui.Models.Omdb;


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

    public List<SearchInfo> GetMovies(string searchString)
    {
        var json = _client.DownloadString(Website + $"?apikey={_apiKey}&type=movie&page=1&s={searchString}");
        var list = JsonSerializer.Deserialize<OmdbMovieInfoSearchCollection>(json)?.Search;
        var movieInfos = list?.Select(x => new SearchInfo{Name = x.Title, Id = x.ImdbId}).ToList();
        if (movieInfos is null)
        {
            throw new ArgumentException("Movie not found");
        }
        return movieInfos;
    }

    // public MovieInfo GetMovieById(string? id)
    // {
    //     var json = _client.DownloadString($"http://www.omdbapi.com/?apikey={_apiKey}&i={id}");
    //     var movieInfo = JsonSerializer.Deserialize<OmdbMovieInfo?>(json);
    //     return new MovieInfo
    //     {
    //         Poster = MovieInfo.GetImageFromUrl(movieInfo?.Poster)
    //     };
    // }

    public MovieInfo GetMovieByTitle(string title)
    {
        var json = _client.DownloadString($"http://www.omdbapi.com/?apikey={_apiKey}&t={title}");
        var movieInfo = JsonSerializer.Deserialize<OmdbMovieInfo?>(json);
        return new MovieInfo
        {
            PosterPath = movieInfo?.Poster,
            Title = title,
            Plot = movieInfo?.Plot,
            Year = movieInfo?.Year
        };
    }
    
   
}