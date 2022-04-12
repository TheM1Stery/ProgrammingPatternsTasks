using CommunityToolkit.Mvvm.ComponentModel;

namespace MovieApiGui.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty] 
    private BaseViewModel? _currentViewModel;
}