using System.Collections.ObjectModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;
using MovieApiGui.Models;
using MovieApiGui.Services;

namespace MovieApiGui.ViewModels;

public partial class MovieListViewModel : BaseViewModel, IRecipient<RequestMessage<MovieInfo?>>
{
    private readonly IMovieService _movieService;

    [ObservableProperty] 
    private ObservableCollection<SearchInfo>? _movieList;

    [ObservableProperty] 
    private SearchInfo? _selectedMovie;

    [ObservableProperty] 
    private string? _searchString;

    public MovieListViewModel(IMovieService movieService)
    {
        WeakReferenceMessenger.Default.Register(this);
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
        if (SearchString == null)
            return;
        var list = _movieService.GetMovies(SearchString);
        if (list == null)
        {
            MessageBox.Show("Couldn't find anything based on the search or there was an error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        MovieList = new ObservableCollection<SearchInfo>(list!);
    }
    
    public void Receive(RequestMessage<MovieInfo?> message)
    {
        if (_selectedMovie?.Name != null)
            message.Reply(_movieService.GetMovieByTitle(_selectedMovie.Name));
    }
}