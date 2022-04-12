using TaskTwoWpf.ViewModels;

namespace TaskTwoWpf.Factories;

public interface IViewModelFactory
{
    public BaseViewModel Create(ViewModelType viewModel);
}