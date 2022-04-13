using MovieApiGui.ViewModels;

namespace MovieApiGui.Factories;

public interface IViewModelFactory
{
    public BaseViewModel Create(ViewModelType viewModelType);
}