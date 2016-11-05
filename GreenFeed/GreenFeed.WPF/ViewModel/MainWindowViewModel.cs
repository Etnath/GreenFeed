using Akka.Actor;
using GreenFeed.Actors;
using GreenFeed.WPF.Model;
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

        public ObservableCollection<RssFeedInfo> RssFeedInfo { get; set; }
        public RssFeedInfo SelectedRss { get; set; }

        public MainWindowViewModel()
        {
            var _sys = ActorSystem.Create("test");
            Props rssCoordinatorProps = Props.Create<RssCoordinator>();
            _rssCoordinator = _sys.ActorOf(rssCoordinatorProps);
        }
    }
}
