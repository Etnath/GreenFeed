using GreenFeed.DataModel;
using System.Collections.ObjectModel;

namespace GreenFeed.WPF.Repository
{
    public interface IFeedRepository
    {
        ObservableCollection<RssInfo> RssFeeds { get; set; }
    }
}
