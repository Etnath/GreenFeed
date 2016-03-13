using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.UI.RssSettingsEditor
{
    public class RssSettingsEditorModel
    {
        public string Name { get; }
        public string Url { get; }

        public RssSettingsEditorModel(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
