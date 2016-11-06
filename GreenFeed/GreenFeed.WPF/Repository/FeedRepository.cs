using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFeed.WPF.Model;

namespace GreenFeed.WPF.Repository
{
    public class FeedRepository : IFeedRepository
    {
        public ObservableCollection<RssFeedInfo> RssFeeds { get; set; }

        public FeedRepository(IList<RssFeedInfo> rssFeeds)
        {
            RssFeeds = new ObservableCollection<RssFeedInfo>(rssFeeds);
        }
    }
}
