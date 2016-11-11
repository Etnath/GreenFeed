using Akka.Actor;
using GreenFeed.Actors;
using GreenFeed.DataModel;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;
using GreenFeed.Utilities;
using GreenFeed.WPF.Model;
using GreenFeed.WPF.Repository;
using GreenFeed.WPF.View;
using System.Collections.ObjectModel;
using System.ServiceModel.Syndication;

namespace GreenFeed.WPF.ViewModel
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        private IActorRef _rssCoordinator;
        private IFeedRepository _repository;

        private ObservableCollection<RssInfo> _rssFeedinfo;
        public ObservableCollection<RssInfo> RssFeedInfo
        {
            get { return _rssFeedinfo; }
            set { _rssFeedinfo = value; OnPropertyChanged(); }
        }

        private RssInfo _selectedRss;
        public RssInfo SelectedRss
        {
            get { return _selectedRss; }
            set
            {
                if (value != null
                    && _selectedRss != value)
                {
                    _selectedRss = value;
                    UpdateCurrentFeed();
                    OnPropertyChanged();
                }
            }
        }

        private NotifiedSyndicationFeed _selectedFeed;

        public NotifiedSyndicationFeed SelectedFeed
        {
            get { return _selectedFeed; }
            set { _selectedFeed = value; OnPropertyChanged(); }
        }

        public MainWindowViewModel()
        {
            var _sys = ActorSystem.Create("test");
            Props rssCoordinatorProps = Props.Create<RssCoordinator>();
            _rssCoordinator = _sys.ActorOf(rssCoordinatorProps);
            _repository = new FeedRepository(_rssCoordinator.Ask<GetFeedListAcknowledge>(new GetFeedListCommand()).Result.RssFeeds);
            RssFeedInfo = new ObservableCollection<RssInfo>();
        }

        public void AddFeed()
        {
            AddRssWindowViewModel addRssVm = new AddRssWindowViewModel(_repository);
            AddRssWindow window = new AddRssWindow();
            window.DataContext = addRssVm;
            if (window.ShowDialog().Value)
            {
                _rssCoordinator.Ask<AddFeedAcknowledge>(new AddFeedCommand(addRssVm.RssName, addRssVm.RssUrl.Replace(@"\\",@"\")));
                RssFeedInfo = new ObservableCollection<RssInfo>(_rssCoordinator.Ask<GetFeedListAcknowledge>(new GetFeedListCommand()).Result.RssFeeds);
            }
        }

        public void UpdateCurrentFeed()
        {
            var taskResult = _rssCoordinator.Ask<GetFeedContentAcknowledge>(new GetFeedContentCommand(SelectedRss.Name)).Result;
            if (taskResult.FeedData != null)
            {
                SelectedFeed = new NotifiedSyndicationFeed(taskResult.FeedData);
            }
            
        }
    }
}
