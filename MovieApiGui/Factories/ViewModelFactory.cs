using System;
using MovieApiGui.Services;
using MovieApiGui.ViewModels;
using TMDbLib.Client;

namespace MovieApiGui.Factories;

public class ViewModelFactory : IViewModelFactory
{
    private readonly IMovieService _client;


    public ViewModelFactory(IMovieService client)
    {
        _client = client;
    }
    
    
    public BaseViewModel Create(ViewModelType viewModelType)
    {
        return viewModelType switch
        {
            ViewModelType.MovieInfo => new MovieInfoViewModel(),
            ViewModelType.MovieList => new MovieListViewModel(_client),
            _ => throw new ArgumentException("Invalid viewModel type")
        };
    }
}