using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace TaskTwoWpf.ViewModels;

public partial class StartUpViewModel : BaseViewModel
{
    [ObservableProperty]
    private string? _message;


    public StartUpViewModel()
    {
        Message = "SIMPLE WPF PROJECT";
    }


    [ICommand]
    private void HelloWorld()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ViewModelType>(ViewModelType.HelloWorld));
    }
}