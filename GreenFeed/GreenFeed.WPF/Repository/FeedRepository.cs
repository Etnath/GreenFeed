using System.Collections.Generic;
using System.Collections.ObjectModel;
using GreenFeed.DataModel;

namespace GreenFeed.WPF.Repository
{
    public class FeedRepository : IFeedRepository
    {
        public ObservableCollection<RssInfo> RssFeeds { get; set; }

        public FeedRepository(IList<RssInfo> rssInfo)
        {
            RssFeeds = new ObservableCollection<RssInfo>(rssInfo);
        }
    }
}
