using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;
using MovieApiGui.Models;
using MovieApiGui.Services;

namespace MovieApiGui.ViewModels;

public partial class MovieListViewModel : BaseViewModel
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
        _movieService = movieService;
    }

    [ICommand]
    private void OpenMovieInfo()
    {
        if (_selectedMovie?.Name == null) 
            return;
        var movieInfo = _movieService.GetMovieByTitle(_selectedMovie.Name);
        if (movieInfo == null)
        {
            MessageBox.Show("Couldn't get movie information. Please check your internet connection", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        using var webClient = new WebClient();
        
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.MovieInfo));
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<MovieInfo?>(movieInfo));
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
        MovieList = new ObservableCollection<SearchInfo>(list);
    }

}