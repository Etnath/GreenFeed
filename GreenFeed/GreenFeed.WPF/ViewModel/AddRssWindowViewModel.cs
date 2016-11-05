using GreenFeed.Utilities;
using GreenFeed.WPF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.ViewModel
{
    public class AddRssWindowViewModel : NotifyPropertyChangedBase
    {
        private IFeedRepository _repository;

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

        public AddRssWindowViewModel(IFeedRepository repository)
        {
            _repository = repository;
        }

        public AddRssWindowViewModel()
        {

        }

        public void Cancel()
        {

        }

        public void Ok()
        {
            _repository?.RssFeeds.Add(new Model.RssFeedInfo() { Name = RssName, Url = RssUrl });
        }
    }
}
