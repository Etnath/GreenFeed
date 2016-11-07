using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public class QueryFeedAcknowledge : IAcknowledge
    {
        public bool IsSuccess { get; private set; }
        public Status Status { get; private set; }
        public SyndicationFeed FeedData{ get; private set; }

        public QueryFeedAcknowledge(bool isSuccess = true, Status status = Status.Ok, SyndicationFeed feedData = null)
        {
            IsSuccess = isSuccess;
            Status = status;
            FeedData = feedData;
        }
    }
}
