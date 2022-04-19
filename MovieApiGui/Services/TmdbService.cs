using System;
using System.Net;
using System.Text;
using MovieApiGui.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using MovieApiGui.Models.Tmdb;

namespace MovieApiGui.Services;



public class TmdbService : IMovieService
{
    private readonly string? _apiKey;

    private const string Website = "https://api.themoviedb.org/3";

    private readonly WebClient _client;
    
    public TmdbService(string? apiKey)
    {
        _apiKey = apiKey;
        _client = new WebClient();
        _client.Encoding = Encoding.UTF8;
    }


    public List<SearchInfo> GetMovies(string searchString)
    {
        var json = _client.DownloadString(Website +
                               $"/search/movie?api_key={_apiKey}&language=en-US&query={searchString}&page=1&include_adult=false");
        var list = JsonSerializer.Deserialize<TmdbMovieInfoSearchCollection>(json)?.Results;
        var movieInfos = list?.Select(x =>  new SearchInfo{Name = x.Title, Id = x.Id.ToString()}).ToList();
        if (movieInfos?.Count == 0 || movieInfos is null)
        {
            throw new ArgumentException("Movie not found");
        }
        return movieInfos;
    }

    private MovieInfo GetMovieById(string? id)
    {
        var json = _client.DownloadString(Website +
                                          $"/movie/{id}?api_key={_apiKey}&language=en-US");
        var movieInfo = JsonSerializer.Deserialize<TmdbMovieInfo?>(json);
        return new MovieInfo()
        {
            PosterPath = "https://image.tmdb.org/t/p/w300" + movieInfo?.PosterPath,
            Plot = movieInfo?.Overview,
            Title = movieInfo?.Title,
            Year = movieInfo?.ReleaseDate?.Split('-')[0]
        };
    }
    
    public MovieInfo GetMovieByTitle(string title)
    {
        var list = GetMovies(title);
        return GetMovieById(list[0]?.Id);
    }
}