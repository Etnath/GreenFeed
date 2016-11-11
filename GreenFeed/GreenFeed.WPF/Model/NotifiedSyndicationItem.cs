using GreenFeed.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.Model
{
    public class NotifiedSyndicationItem : NotifyPropertyChangedBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value;  OnPropertyChanged(); }
        }

        public NotifiedSyndicationItem()
        {
            _title = string.Empty;
        }

        public NotifiedSyndicationItem(SyndicationItem item)
        {
            Title = item.Title.Text;
        }
    }
}
