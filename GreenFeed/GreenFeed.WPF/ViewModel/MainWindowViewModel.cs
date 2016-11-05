using Akka.Actor;
using GreenFeed.Actors;
using GreenFeed.WPF.Model;
using GreenFeed.WPF.Repository;
using GreenFeed.WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.ViewModel
{
    public class MainWindowViewModel
    {
        private IActorRef _rssCoordinator;
        private IFeedRepository _repository;

        public ObservableCollection<RssFeedInfo> RssFeedInfo { get; set; }
        public RssFeedInfo SelectedRss { get; set; }

        public MainWindowViewModel()
        {
            var _sys = ActorSystem.Create("test");
            Props rssCoordinatorProps = Props.Create<RssCoordinator>();
            _rssCoordinator = _sys.ActorOf(rssCoordinatorProps);
        }

        public void AddFeed()
        {
            AddRssWindowViewModel addRssVm = new AddRssWindowViewModel(_repository);
            AddRssWindow window = new AddRssWindow();
            window.DataContext = addRssVm;
            if (window.ShowDialog().Value)
            {

            }

        }
    }
}
