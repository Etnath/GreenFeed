using GreenFeed.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.Model
{
    public class NotifiedSyndicationFeed : NotifyPropertyChangedBase
    {
        private ObservableCollection<NotifiedSyndicationItem> _items;
        public ObservableCollection<NotifiedSyndicationItem> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }

        public NotifiedSyndicationFeed()
        {
            _items = new ObservableCollection<NotifiedSyndicationItem>();
        }

        public NotifiedSyndicationFeed(SyndicationFeed feed)
        {
            _items = new ObservableCollection<NotifiedSyndicationItem>();
            feed.Items.ToList().ForEach(f => _items.Add(new NotifiedSyndicationItem(f)));
        }
    }
}
