using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MovieApiGui.Factories;

namespace MovieApiGui.ViewModels;

public partial class MainViewModel : BaseViewModel, IRecipient<ValueChangedMessage<ViewModelType>>
{
    private readonly IViewModelFactory _viewModelFactory;

    [ObservableProperty] 
    private BaseViewModel? _currentViewModel;


    public MainViewModel(IViewModelFactory viewModelFactory)
    {
        WeakReferenceMessenger.Default.Register(this);
        _viewModelFactory = viewModelFactory;
        CurrentViewModel = _viewModelFactory.Create(ViewModelType.MovieList);
    }
    

    public void Receive(ValueChangedMessage<ViewModelType> message)
    {
        CurrentViewModel = _viewModelFactory.Create(message.Value);
    }
}