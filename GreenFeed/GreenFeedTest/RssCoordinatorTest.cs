﻿using Akka.Actor;
using Akka.TestKit.VsTest;
using GreenFeed.Actors;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenFeedTest
{
    [TestClass]
    public class RssCoordinatorTest : TestKit
    {
        private IActorRef _rssCoordinator;

        public RssCoordinatorTest()
        {
            Props rssCoordinatorProps = Props.Create<RssCoordinator>();
            _rssCoordinator = Sys.ActorOf(rssCoordinatorProps);
        }

        [TestMethod]
        public void AddFeedTest()
        {
            _rssCoordinator.Tell(new AddFeedCommand("piou", "uoip"));

            ExpectMsg<AddFeedAcknowledge>(f => f.FeedCount == 1);
        }

        [TestMethod]
        public void RemoveFeedTest()
        {
            _rssCoordinator.Tell(new AddFeedCommand("piou", "uoip"));
            _rssCoordinator.Tell(new RemoveFeedCommand("piou"));

            ExpectMsg<AddFeedAcknowledge>();
            ExpectMsg<RemoveFeedAcknowledge>(f => f.FeedCount == 0);
        }
    }
}
