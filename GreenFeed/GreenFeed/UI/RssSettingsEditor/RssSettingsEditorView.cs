using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenFeed.UI.RssSettingsEditor
{
    public partial class RssSettingsEditorView : Form
    {
        public RssSettingsEditorView()
        {
            InitializeComponent();
        }

        public void BindModelToView(RssSettingsEditorModel model)
        {
            tbRssName.DataBindings.Add(new Binding("Text", model, "Name"));
            tbRssUrl.DataBindings.Add(new Binding("Text", model, "Url"));
        }
    }
}
