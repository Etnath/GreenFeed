using GreenFeed.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.WPF.Model
{
    public class RssFeedInfo : NotifyPropertyChangedBase
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
            set { _url = value; }
        }

    }
}
