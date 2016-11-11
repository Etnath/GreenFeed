using GreenFeed.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.DataModel
{
    public class RssInfo : NotifyPropertyChangedBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; OnPropertyChanged(); }
        }

        public RssInfo(RssInfo rssInfo = null)
        {
            if (rssInfo == null)
            {
                Name = string.Empty;
                Url = string.Empty;
            }
            else
            {
                Name = rssInfo.Name;
                Url = rssInfo.Url;
            }
            
        }

        public RssInfo(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
