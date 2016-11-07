using System;
using System.Xml;
using Akka.Actor;
using GreenFeed.Messages.Commands;
using System.ServiceModel.Syndication;
using GreenFeed.Messages.Acknowledge;
using Status = GreenFeed.Messages.Status;

namespace GreenFeed.Actors
{
    public class RssGetter : ReceiveActor
    {
        private string _url;

        public RssGetter(string url)
        {
            _url = url;

            Receive<QueryFeedCommand>(f => Query(f, Sender));
        }

        private void Query(QueryFeedCommand queryRssFeed,IActorRef sender)
        {
            try
            {
                using (var reader = XmlReader.Create(_url))
                {
                    var data = SyndicationFeed.Load(reader);
                    sender.Tell(new QueryFeedAcknowledge(true, Status.Ok, data), Self);
                }
            }
            catch (Exception)
            {
                sender.Tell(new QueryFeedAcknowledge(false, Status.Failed), Self);
            }                      
        }
    }
}
