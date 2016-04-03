using System.ServiceModel.Syndication;

namespace GreenFeed.DataModel
{
    public class RssInfo
    {
        public string Name { get; }
        public string Url { get; }
        public SyndicationFeed FeedData { get; set; }

        public RssInfo(string name = "", string url = "")
        {
            Name = name;
            Url = url;
            FeedData = null;
        }

        public RssInfo(RssInfo rssInfo)
        {
            Name = rssInfo.Name;
            Url = rssInfo.Url;
        }
    }
}
