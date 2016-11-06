using Akka.Actor;
using GreenFeed.DataModel;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;

namespace GreenFeed.Actors
{
    public class RssFeed : ReceiveActor
    {
        private IActorRef _rssGetter;
        public RssFeedData RssData { get; set; }

        public RssFeed(RssInfo rssInfo)
        {
            RssFeedData RssData = new RssFeedData(rssInfo);
            Props rssGetterProp = Props.Create<RssGetter>(new object[] { rssInfo.Url });
            _rssGetter = Context.System.ActorOf(rssGetterProp);

            Receive<UpdateFeedCommand>(f => Update(f, Sender));
            Receive<QueryFeedAcknowledge>(f => UpdateFeed(f, Sender));
        }

        private void Update(UpdateFeedCommand updateRssFeed, IActorRef sender)
        {
            _rssGetter.Tell(new QueryFeedCommand());
        }

        private void UpdateFeed(QueryFeedAcknowledge updateRssFeed, IActorRef sender)
        {
            if (updateRssFeed.IsSuccess)
            {
                if (updateRssFeed.FeedData != null)
                {
                    RssData.FeedData = updateRssFeed.FeedData;
                }
                else
                {
                    //TODO log
                }
            }
            else
            {
                //TODO log
            }
        }
    }
}
