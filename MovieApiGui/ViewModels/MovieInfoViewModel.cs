using System;
using System.IO;
using System.Net;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;
using MovieApiGui.Models;
using Image = System.Windows.Controls.Image;

namespace MovieApiGui.ViewModels;

public partial class MovieInfoViewModel : BaseViewModel, IRecipient<ValueChangedMessage<MovieInfo?>>
{
    [ObservableProperty] 
    private MovieInfo? _movieInfo;

    public string? Plot => _movieInfo?.Plot?.Replace(".", ".\n");


    public string? Poster
    {
        get
        {
            var name = _movieInfo?.PosterPath?.Split('/')[^1];
            if (File.Exists(Path.GetTempPath() + $"\\{name}"))
            {
                return Path.GetTempPath() + $"\\{name}";
            }
            try
            {
                var webClient = new WebClient();
                
                if (_movieInfo?.PosterPath != null)
                    webClient.DownloadFile(_movieInfo.PosterPath, Path.GetTempPath() + $"\\{name}");
            }
            catch (Exception)
            {
                return null;
            }
            return Path.GetTempPath() + $"\\{name}";
        }
    }
    
    

    [ICommand]
    private void Return()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.MovieList));
    }
    
    
    public MovieInfoViewModel()
    {
        WeakReferenceMessenger.Default.Register(this);
    }

    public void Receive(ValueChangedMessage<MovieInfo?> message)
    {
        MovieInfo = message.Value;
    }
}