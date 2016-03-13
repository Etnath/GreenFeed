using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.DataModel
{
    public class RssInfo
    {
        public string Name { get; }
        public string Url { get; }

        public RssInfo(string name = "", string url = "")
        {
            Name = name;
            Url = url;
        }

        public RssInfo(RssInfo rssInfo)
        {
            Name = rssInfo.Name;
            Url = rssInfo.Url;
        }
    }
}
