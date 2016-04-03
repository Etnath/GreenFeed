using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public abstract class Acknowledge : IAcknowledge
    {
        public bool IsSuccess { get; }
        public Status Status { get; }

        public Acknowledge(bool isSuccess = true, Status status = Status.Ok)
        {
            IsSuccess = isSuccess;
            Status = status;
        }
    }
}
