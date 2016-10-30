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
    }
}