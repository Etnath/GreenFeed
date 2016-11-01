using GreenFeed.WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.ViewModel
{
    public class RssFeedListViewModel
    {
        public ObservableCollection<RssFeedInfo> RssFeedInfo { get; set; }
        public RssFeedInfo SelectedRss { get; set; }

        public RssFeedListViewModel()
        {
            RssFeedInfo = new ObservableCollection<Model.RssFeedInfo>();
            RssFeedInfo.Add(new RssFeedInfo() { Name ="Test" });
        }
    }
}