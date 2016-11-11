using System;
using System.Collections.Generic;
using System.Linq;
using Akka.Actor;
using Akka.Util.Internal;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;
using GreenFeed.DataModel;

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
            Receive<GetFeedListCommand>(f => GetFeedList(Sender));
            Receive<GetFeedContentCommand>(f => GetFeedContent(f, Sender));
            Receive<Failure>(f => LogFailure(f, Sender));
            
            SubscribeFeedsToUpdate();   
        }

        public void AddFeed(AddFeedCommand addFeedMessage, IActorRef sender)
        {
            Props props = Props.Create<RssFeed>(new object[] { new RssInfo(addFeedMessage.Name, addFeedMessage.Url) });
            var feed = Context.ActorOf(props , addFeedMessage.Name);
            SubscribeFeedToUpdate(feed);
            _feeds.Add(feed);
            sender.Tell(new AddFeedAcknowledge(_feeds.Count), Self);
        }

        public void RemoveFeed(RemoveFeedCommand removeFeedMessage, IActorRef sender)
        {
            _feeds.RemoveWhere(f => f.Path.Name == removeFeedMessage.Name);
            sender.Tell(new RemoveFeedAcknowledge(_feeds.Count), Self);
        }

        public void GetFeedList(IActorRef sender)
        {
            IList<RssInfo> rssInfos = new List<RssInfo>();
            _feeds.ForEach(f => rssInfos.Add(f.Ask<GetFeedInfoAcknowledge>(new GetFeedInfoCommand()).Result.RssFeed));
            Sender.Tell(new GetFeedListAcknowledge(rssInfos), Self);
        }

        public RssFeedData GetFeed()
        {
            throw new NotImplementedException();
        }

        private void SubscribeFeedsToUpdate()
        {
            foreach (var actor in _feeds)
            {
                SubscribeFeedToUpdate(actor);
            }
        }

        private void SubscribeFeedToUpdate(IActorRef actor)
        {
            Context.System.Scheduler.ScheduleTellRepeatedly(TimeSpan.FromSeconds(1),
                                                            TimeSpan.FromMinutes(1),
                                                            actor,
                                                            new UpdateFeedCommand(),
                                                            Self);
        }

        private void GetFeedContent(GetFeedContentCommand f, IActorRef sender)
        {
            if (f.FeedName != null)
            {
                var actor = _feeds.First(g => g.Path.Name == f.FeedName);
                if (actor != null)
                {
                    actor.Tell(new UpdateFeedCommand(), Self);
                    var taskResult = actor.Ask<GetFeedContentAcknowledge>(f).Result;
                    if (taskResult != null)
                    {
                        Sender.Tell(taskResult, Self);
                    }
                    else
                    {
                        //TODO : log
                    }
                }
            }
            else
            {
                //TODO : log
            }
        }

        private void LogFailure(Failure failure, IActorRef Sender)
        {
            Console.WriteLine(Sender.Path + " failed: " + failure.Exception.ToString());
        }       
    }
}
