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

        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; OnPropertyChanged(); }
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; OnPropertyChanged(); }
        }


        public NotifiedSyndicationItem()
        {
            _title = string.Empty;
            _content = string.Empty;
        }

        public NotifiedSyndicationItem(SyndicationItem item)
        {
            Title = item.Title.Text;
            Url = item.Id;
            if (item.Content != null
                && item.Content.Type.Equals("html", StringComparison.InvariantCultureIgnoreCase))
            {
                _content = ((TextSyndicationContent)item.Content)?.Text;
            }
        }
    }
}
