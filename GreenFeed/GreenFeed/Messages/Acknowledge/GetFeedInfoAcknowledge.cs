using GreenFeed.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Messages.Acknowledge
{
    public class GetFeedInfoAcknowledge
    {
        public IList<RssInfo> RssFeed {get; set;}

        public GetFeedInfoAcknowledge(IList<RssInfo> rssFeed = null)
        {
            RssFeed = rssFeed;
        }
    }
}
