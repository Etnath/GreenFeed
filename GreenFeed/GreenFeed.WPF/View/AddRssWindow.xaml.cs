using System.Windows;

namespace GreenFeed.WPF.View
{
    /// <summary>
    /// Interaction logic for RssSettingsEditor.xaml
    /// </summary>
    public partial class AddRssWindow : Window
    {
        public AddRssWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
