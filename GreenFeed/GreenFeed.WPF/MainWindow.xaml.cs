using Akka.Actor;
using GreenFeed.WPF.ViewModel;
using System.Windows;

namespace GreenFeed.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IActorRef _rssCoordinator;

        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}
