using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public interface IAcknowledge
    {
        bool IsSuccess { get; }
        Status Status { get; }
    }
}
