using System.IO;
using System.Windows;
using System.Windows.Media;
using MovieApiGui.Factories;
using MovieApiGui.Services;
using MovieApiGui.Utilities;
using MovieApiGui.ViewModels;
using MovieApiGui.Views;
using SimpleInjector;
using TMDbLib.Client;

namespace MovieApiGui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string?[] GetApiKeys(string path)
        {
            var apiKeys = new string?[2];

            using var reader = new StreamReader(path);

            string? key;
            var i = 0;
            while ((key = reader.ReadLine()) != null)
            {
                apiKeys[i++] = EncryptionHelper.Decrypt(key, "the strokes is the best band in the world");
            }

            return apiKeys;
        }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = new Container();

            var apiKeys = GetApiKeys("..\\..\\..\\Assets\\apikeys.txt");
            
            container.RegisterSingleton(() => new TMDbClient(apiKeys[0]));
            container.Register<TmdbService>(Lifestyle.Singleton);
            container.Register<OmdbService>(Lifestyle.Singleton);
            container.Register<IMovieService, MovieServiceProxy>(Lifestyle.Singleton);
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