using CommunityToolkit.Mvvm.ComponentModel;
using MovieApiGui.Factories;

namespace MovieApiGui.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private readonly IViewModelFactory _viewModelFactory;

    [ObservableProperty] 
    private BaseViewModel? _currentViewModel;


    public MainViewModel(IViewModelFactory viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    }
}