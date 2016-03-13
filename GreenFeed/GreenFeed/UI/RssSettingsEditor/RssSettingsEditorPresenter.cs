using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFeed.UI.RssSettingsEditor
{
    public class RssSettingsEditorPresenter
    {
        private RssSettingsEditorView _view;
        private RssSettingsEditorModel _model;

        public RssSettingsEditorPresenter(string name = "", string url = "")
        {
            _model = new RssSettingsEditorModel(name, url);

        }

    }
}
