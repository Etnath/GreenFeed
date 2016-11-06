using Akka.Actor;
using GreenFeed.Actors;
using GreenFeed.DataModel;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;
using GreenFeed.WPF.Repository;
using GreenFeed.WPF.View;
using System.Collections.ObjectModel;

namespace GreenFeed.WPF.ViewModel
{
    public class MainWindowViewModel
    {
        private IActorRef _rssCoordinator;
        private IFeedRepository _repository;

        public ObservableCollection<RssInfo> RssFeedInfo { get; set; }
        public RssInfo SelectedRss { get; set; }

        public MainWindowViewModel()
        {
            var _sys = ActorSystem.Create("test");
            Props rssCoordinatorProps = Props.Create<RssCoordinator>();
            _rssCoordinator = _sys.ActorOf(rssCoordinatorProps);
            _repository = new FeedRepository(_rssCoordinator.Ask<GetFeedInfoAcknowledge>(new GetFeedInfoCommand()).Result.RssFeed);
            
        }

        public void AddFeed()
        {
            AddRssWindowViewModel addRssVm = new AddRssWindowViewModel(_repository);
            AddRssWindow window = new AddRssWindow();
            window.DataContext = addRssVm;
            if (window.ShowDialog().Value)
            {
                _rssCoordinator.Ask<AddFeedCommand>(new AddFeedCommand(addRssVm.RssName, addRssVm.RssUrl));
                _repository = new FeedRepository(_rssCoordinator.Ask<GetFeedInfoAcknowledge>(new GetFeedInfoCommand()).Result.RssFeed);
            }

        }
    }
}
