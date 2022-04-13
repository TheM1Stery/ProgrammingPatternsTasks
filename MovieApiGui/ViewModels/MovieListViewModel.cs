using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MovieApiGui.ViewModels;

public partial class MovieListViewModel : BaseViewModel
{
    [ObservableProperty] 
    private ObservableCollection<object>? _movieInfos; // should be changed to ObservableCollection<MovieInfo>!!!
}