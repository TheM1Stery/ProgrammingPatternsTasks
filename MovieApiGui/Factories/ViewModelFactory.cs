using System;
using MovieApiGui.ViewModels;

namespace MovieApiGui.Factories;

public class ViewModelFactory : IViewModelFactory
{

    public ViewModelFactory()
    {
        
    }
    
    
    public BaseViewModel Create(ViewModelType viewModelType)
    {
        return viewModelType switch
        {
            ViewModelType.MovieInfo => new MovieInfoViewModel(),
            ViewModelType.MovieList => new MovieListViewModel(),
            _ => throw new ArgumentException("Invalid viewModel type")
        };
    }
}