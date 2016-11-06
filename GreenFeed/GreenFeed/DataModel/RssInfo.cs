using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.DataModel
{
    public class RssInfo
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public RssInfo(RssInfo rssInfo = null)
        {
            if (rssInfo == null)
            {
                Name = string.Empty;
                Url = string.Empty;
            }
            else
            {
                Name = rssInfo.Name;
                Url = rssInfo.Url;
            }
            
        }

        public RssInfo(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
