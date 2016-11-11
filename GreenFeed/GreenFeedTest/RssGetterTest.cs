using System;
using System.IO;
using Akka.Actor;
using Akka.TestKit.VsTest;
using GreenFeed.Actors;
using GreenFeed.Messages.Acknowledge;
using GreenFeed.Messages.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenFeedTest
{
    [TestClass]
    public class RssGetterTest : TestKit
    {
        private readonly string _url = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\test.rss"));
        private readonly string _url2 = @"https://github.com/Etnath.private.atom?token=AG9sFvTzr1vFhgLcdJLGSvI6cM8Lyq5kks62McmRwA==";
        private IActorRef _rssGetter;

        public RssGetterTest()
        {
            Props rssGetterProps = Props.Create<RssGetter>(_url2);
            _rssGetter = Sys.ActorOf(rssGetterProps);
        }

        [TestMethod]
        public void QueryRssUrlTest()
        {
           _rssGetter.Tell(new QueryFeedCommand());
            ExpectMsg<QueryFeedAcknowledge>(f => f.IsSuccess && f.FeedData != null);
        }
    }
}
