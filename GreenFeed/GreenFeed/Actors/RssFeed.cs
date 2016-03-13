using Akka.Actor;
using GreenFeed.DataModel;

namespace GreenFeed.Actors
{
    public class RssFeed : ReceiveActor
    {
        public RssInfo RssInfo { get; set; }

        public RssFeed(RssInfo rssInfo)
        {
            RssInfo = rssInfo;
        }
    }
}
