using System.Windows.Forms;

namespace GreenFeed.Winforms.RssSettingsEditor
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
