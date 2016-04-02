using System;
using System.Xml;
using Akka.Actor;
using GreenFeed.Messages.Commands;
using System.ServiceModel.Syndication;
using GreenFeed.Messages.Acknowledge;
using Status = GreenFeed.Messages.Acknowledge.Status;

namespace GreenFeed.Actors
{
    public class RssGetter : ReceiveActor
    {
        private string _url;

        public RssGetter(string url)
        {
            _url = url;

            Receive<QueryRssFeedCommand>(f => Query(f, Sender));
        }

        private void Query(QueryRssFeedCommand queryRssFeed,IActorRef sender)
        {
            try
            {
                using (var reader = XmlReader.Create(_url))
                {
                    var data = SyndicationFeed.Load(reader);
                }
            }
            catch (Exception)
            {
                sender.Tell(new QueryRssFeedAcknowledge(false, Status.Failed), Self);
            }           
            sender.Tell(new QueryRssFeedAcknowledge(), Self);
        }
    }
}
