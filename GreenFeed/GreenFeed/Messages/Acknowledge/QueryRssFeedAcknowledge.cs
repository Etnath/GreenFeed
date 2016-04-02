using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public class QueryRssFeedAcknowledge : IAcknowledge
    {
        public bool IsSuccess { get; }
        public Status Status { get; }

        public QueryRssFeedAcknowledge(bool isSuccess = true, Status status = Status.Ok)
        {
            IsSuccess = isSuccess;
            Status = status;
        }
    }
}
