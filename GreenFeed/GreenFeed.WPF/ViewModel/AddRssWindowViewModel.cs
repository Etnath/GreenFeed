using GreenFeed.DataModel;
using GreenFeed.Utilities;
using GreenFeed.WPF.Repository;

namespace GreenFeed.WPF.ViewModel
{
    public class AddRssWindowViewModel : NotifyPropertyChangedBase
    {
        private string _rssName;
        public string RssName
        {
            get { return _rssName; }
            set { _rssName = value; OnPropertyChanged(); }
        }

        private string _rssUrl;
        public string RssUrl
        {
            get { return _rssUrl; }
            set { _rssUrl = value; OnPropertyChanged(); }
        }

        public AddRssWindowViewModel()
        {
            RssName = string.Empty;
            RssUrl = string.Empty;
        }
    }
}
