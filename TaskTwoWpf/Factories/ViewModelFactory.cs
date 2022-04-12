using System;
using TaskTwoWpf.ViewModels;

namespace TaskTwoWpf.Factories;

public class ViewModelFactory : IViewModelFactory
{
    public BaseViewModel Create(ViewModelType viewModel)
    {
        return viewModel switch
        {
            ViewModelType.Startup => new StartUpViewModel(),
            ViewModelType.HelloWorld => new HelloWorldViewModel(),
            _ => throw new InvalidOperationException("Invalid viewModel")
        };
    }
}