using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.Actors
{
    public class RssFeed : ReceiveActor
    {
        public string Name;
        public string Url;

        public RssFeed(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
