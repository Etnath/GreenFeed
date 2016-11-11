using System;
using System.Threading.Tasks;
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
            
            Props rssGetterProp = Props.Create<RssGetter>(new object[] { rssInfo.Url });
            _rssGetter = Context.System.ActorOf(rssGetterProp);

            Receive<UpdateFeedCommand>(f => Update(f, Sender));
            Receive<QueryFeedAcknowledge>(f => UpdateFeed(f, Sender));
            Receive<GetFeedInfoCommand>(f => GetFeedInfo(f, Sender));
            Receive<GetFeedContentCommand>(f => GetFeedContent(f, Sender));

            RssData = new RssFeedData(rssInfo);
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

        private void GetFeedInfo(GetFeedInfoCommand getFeedInfoCommand, IActorRef sender)
        {
            sender.Tell(new GetFeedInfoAcknowledge(RssData.RssInfo), Self);
        }

        private void GetFeedContent(GetFeedContentCommand f, IActorRef sender)
        {
            sender.Tell(new GetFeedContentAcknowledge(RssData.FeedData),Self);
        }
    }
}
