using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using TaskTwoWpf.Factories;

namespace TaskTwoWpf.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private readonly IViewModelFactory? _factory;

    [ObservableProperty]
    private BaseViewModel? _currentViewModel;

    public MainViewModel(IViewModelFactory? factory)
    {
        _factory = factory;
        WeakReferenceMessenger.Default.Register<ValueChangedMessage<ViewModelType>>(this, ChangeViewModel);
        _factory = factory;
        CurrentViewModel = _factory?.Create(ViewModelType.Startup);
    }

    private void ChangeViewModel(object recipient, ValueChangedMessage<ViewModelType> message)
    {
        CurrentViewModel = _factory?.Create(message.Value);
    }
}