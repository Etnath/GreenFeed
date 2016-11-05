using GreenFeed.WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.Repository
{
    public interface IFeedRepository
    {
        ObservableCollection<RssFeedInfo> RssFeeds { get; set; }
    }
}
