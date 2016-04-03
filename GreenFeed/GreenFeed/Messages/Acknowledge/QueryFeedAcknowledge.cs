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
        public bool IsSuccess { get; }
        public Status Status { get; }
        public SyndicationFeed FeedData{ get; }

        public QueryFeedAcknowledge(bool isSuccess = true, Status status = Status.Ok, SyndicationFeed feedData = null)
        {
            IsSuccess = isSuccess;
            Status = status;
            FeedData = feedData;
        }
    }
}
