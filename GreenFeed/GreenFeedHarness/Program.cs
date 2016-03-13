using System;
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

            _rssCoordinator.Tell(new AddFeedCommand("piou", "uoip"));
            _rssCoordinator.Tell(new RemoveFeedCommand("piou"));

            Console.ReadLine();
        }
    }
}
