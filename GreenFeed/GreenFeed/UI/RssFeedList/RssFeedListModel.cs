using System.Collections.Generic;
using System.ComponentModel;

namespace GreenFeed.UI.RssFeedList
{
    public class RssFeedListModel
    {
        public BindingList<string> RssFeedNames { get; }

        public RssFeedListModel(IEnumerable<string> rssFeedNames)
        {
            if (rssFeedNames != null)
            {
                RssFeedNames = new BindingList<string>(RssFeedNames);
            }
            else
            {
                RssFeedNames = new BindingList<string>();
            }
        }
    }
}
