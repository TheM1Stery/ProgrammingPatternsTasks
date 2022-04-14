using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Models;

namespace MovieApiGui.ViewModels;

public partial class MovieInfoViewModel : BaseViewModel
{
    [ObservableProperty] 
    private MovieInfo? _movieInfo;
    
    public MovieInfoViewModel()
    {
        MovieInfo = WeakReferenceMessenger.Default.Send(new RequestMessage<MovieInfo>());
    }
}