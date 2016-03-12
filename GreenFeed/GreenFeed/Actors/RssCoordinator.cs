using Akka.Actor;
using GreenFeed.Messages;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Actors
{
    public class RssCoordinator : ReceiveActor
    {
        HashSet<IActorRef> _feeds;

        public RssCoordinator()
        {
            _feeds = new HashSet<IActorRef>();
            Receive<AddFeedCommand>(f => AddFeed(f, Sender));
            Receive<RemoveFeedCommand>(f => RemoveFeed(f, Sender));
        }

        public void AddFeed(AddFeedCommand addFeedMessage, IActorRef sender)
        {
            var feed = Context.ActorOf(Props.Create<RssFeed>(new object[] { addFeedMessage.Name, addFeedMessage.Url }));
            _feeds.Add(feed);
            sender.Tell(new AddFeedAcknowledge(_feeds.Count), Self);

        }

        public void RemoveFeed(RemoveFeedCommand removeFeedMessage, IActorRef sender)
        {
            _feeds.RemoveWhere(f => ((RssFeed)f).Name == removeFeedMessage.Name);
            sender.Tell(new RemoveFeedAcknowledge(_feeds.Count), Self);
        }
    }
}
