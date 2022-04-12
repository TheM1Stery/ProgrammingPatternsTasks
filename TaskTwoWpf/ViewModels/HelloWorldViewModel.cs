using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace TaskTwoWpf.ViewModels;

public partial class HelloWorldViewModel : BaseViewModel
{
    [ObservableProperty] private string? _message;

    public HelloWorldViewModel()
    {
        Message = "Hello world!";
    }

    [ICommand]
    private void Return()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.Startup));
    }
}