using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;
using MovieApiGui.Models;
using MovieApiGui.Services;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace MovieApiGui.ViewModels;

public partial class MovieListViewModel : BaseViewModel, IRecipient<RequestMessage<MovieInfo?>>
{
    private readonly IMovieService _movieService;

    [ObservableProperty] 
    private ObservableCollection<MovieInfo>? _movieList;

    [ObservableProperty] 
    private MovieInfo? _selectedMovie;

    public MovieListViewModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [ICommand]
    private void OpenMovieInfo()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.MovieInfo));
    }

    [ICommand]
    private void Search()
    {
        
    }
    
    public void Receive(RequestMessage<MovieInfo?> message)
    {
        message.Reply(_selectedMovie);
    }
}