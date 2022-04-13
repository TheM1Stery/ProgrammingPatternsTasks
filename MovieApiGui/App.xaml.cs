using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MovieApiGui.Factories;
using MovieApiGui.ViewModels;
using MovieApiGui.Views;
using SimpleInjector;

namespace MovieApiGui
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
            
            var window = container.GetInstance<MainView>();
            window.Show();
            
            base.OnStartup(e);
        }
    }
}