using System;
using System.IO;
using Akka.Actor;
using GreenFeed.Actors;
using GreenFeed.Messages.Commands;

namespace GreenFeedHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var _sys = ActorSystem.Create("test");
            Props rssCoordinatorProps = Props.Create<RssCoordinator>();
            IActorRef _rssCoordinator = _sys.ActorOf(rssCoordinatorProps);

            
            var path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\GreenFeedTest\Resources\test.rss"));
            Props rssGetterProps = Props.Create<RssGetter>(path);
            IActorRef _rssGetter = _sys.ActorOf(rssGetterProps);

            _rssCoordinator.Tell(new AddFeedCommand("piou", "uoip"));
            _rssCoordinator.Tell(new RemoveFeedCommand("piou"));
            _rssGetter.Tell(new QueryFeedCommand());
            
            Console.ReadLine();
        }
    }
}
