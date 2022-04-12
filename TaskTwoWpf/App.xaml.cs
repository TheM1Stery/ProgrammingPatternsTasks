using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SimpleInjector;
using TaskTwoWpf.Factories;
using TaskTwoWpf.ViewModels;
using TaskTwoWpf.Views;

namespace TaskTwoWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = new Container();
            container.Register<IViewModelFactory, ViewModelFactory>(Lifestyle.Singleton);
            container.Register<MainViewModel>(Lifestyle.Singleton);
            container.RegisterSingleton(() => new MainView(container.GetInstance<MainViewModel>()));
            container.Verify();
            var mainView = container.GetInstance<MainView>();
            mainView.Show();
            base.OnStartup(e);
        }
    }
}