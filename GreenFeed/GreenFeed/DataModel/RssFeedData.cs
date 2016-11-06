using System.ServiceModel.Syndication;

namespace GreenFeed.DataModel
{
    public class RssFeedData
    {
        public RssInfo RssInfo { get; set; }
        public SyndicationFeed FeedData { get; set; }

        public RssFeedData(RssInfo info = null)
        {
            RssInfo = info;
            FeedData = null;
        }
        public RssFeedData(RssFeedData feedData)
        {
            RssInfo = feedData.RssInfo;
            FeedData = null;
        }

        
    }
}
