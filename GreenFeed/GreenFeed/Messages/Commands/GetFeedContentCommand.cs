using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Commands
{
    public class GetFeedContentCommand
    {
        public string FeedName { get; private set; }

        public GetFeedContentCommand(string feedName = null)
        {
            FeedName = feedName;
        }
    }
}
