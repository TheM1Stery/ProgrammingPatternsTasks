using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace MovieApiGui.ViewModels;

public partial class MovieListViewModel : BaseViewModel
{
    private readonly TMDbClient _client;

    [ObservableProperty] 
    private ObservableCollection<Movie>? _movieList;

    [ObservableProperty] 
    private Movie? _selectedMovie;

    public MovieListViewModel(TMDbClient client)
    {
        _client = client;
    }

    [ICommand]
    private void OpenMovieInfo()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.MovieInfo));
    }
}