﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public class RemoveFeedAcknowledge : IAcknowledge
    {
        public RemoveFeedAcknowledge(int feedCount, bool isSuccess = true, Status status = Status.Ok)
        {
            IsSuccess = IsSuccess;
            FeedCount = feedCount;
            Status = status;
        }

        public bool IsSuccess { get; }

        public Status Status { get; }
        public int FeedCount { get; }
    }
}
