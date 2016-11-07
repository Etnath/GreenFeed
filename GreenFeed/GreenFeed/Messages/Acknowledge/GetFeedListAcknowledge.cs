using GreenFeed.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public class GetFeedListAcknowledge
    {
        public IList<RssInfo> RssFeeds { get; private set; }

        public GetFeedListAcknowledge(IList<RssInfo> rssFeeds = null)
        {
            RssFeeds = rssFeeds;
        }
    }
}
