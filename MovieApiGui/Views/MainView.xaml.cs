using MahApps.Metro.Controls;

namespace MovieApiGui.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView(object viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}