using GreenFeed.WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.ViewModel
{
    public class RssPageViewModel
    {
        public RssFeedInfo RssInfo { get; set; }

        public RssPageViewModel()
        {
            RssInfo = new RssFeedInfo() { Name = "Test" };
        }
    }
}
