using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
     public class GetFeedContentAcknowledge : Acknowledge
    {
        public SyndicationFeed FeedData { get; private set; }

        public GetFeedContentAcknowledge(SyndicationFeed feedData) : base()
        {
            FeedData = feedData;
        }
    }
}
