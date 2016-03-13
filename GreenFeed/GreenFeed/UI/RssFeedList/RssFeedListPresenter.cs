using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.UI.RssFeedList
{
    public class RssFeedListPresenter : ReceiveActor
    {
        private RssFeedListView _view;
        private RssFeedListModel _model;

        public RssFeedListPresenter(IEnumerable<string> rssFeedNames = null)
        {
            _view = new RssFeedListView();
            _model = new RssFeedListModel(rssFeedNames);
        }
    }
}
