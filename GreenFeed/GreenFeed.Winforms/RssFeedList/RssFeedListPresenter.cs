using System.Collections.Generic;
using Akka.Actor;

namespace GreenFeed.Winforms.RssFeedList
{
    public class RssFeedListPresenter
    {
        private RssFeedListView _view;
        private RssFeedListModel _model;

        public RssFeedListView View
        {
            get { return _view; }
        }

        public RssFeedListPresenter(IEnumerable<string> rssFeedNames = null)
        {
            _view = new RssFeedListView(this);
            _model = new RssFeedListModel(rssFeedNames);
        }

        internal void BtAddFeed_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
