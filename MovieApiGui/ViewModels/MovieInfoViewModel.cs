using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;
using MovieApiGui.Models;
using Image = System.Windows.Controls.Image;

namespace MovieApiGui.ViewModels;

public partial class MovieInfoViewModel : BaseViewModel
{
    [ObservableProperty] 
    private MovieInfo? _movieInfo;


    public string Poster => Path.GetTempPath() + "\\image.png";

    [ICommand]
    private void Return()
    {
        File.Delete(Path.GetTempPath() + "\\image.png");
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.MovieList));
    }
    
    
    public MovieInfoViewModel()
    {
        MovieInfo = WeakReferenceMessenger.Default.Send(new RequestMessage<MovieInfo?>());
        if (MovieInfo?.PosterPath == null) 
            return;
        using var webClient = new WebClient();
        try
        {
            webClient.DownloadFile(MovieInfo.PosterPath, Path.GetTempPath() + "\\image.png");
        }
        catch (Exception)
        {
            MessageBox.Show("Error getting image");
        }
        
    }
}