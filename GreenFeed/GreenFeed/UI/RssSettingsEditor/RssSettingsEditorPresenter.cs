using GreenFeed.DataModel;

namespace GreenFeed.UI.RssSettingsEditor
{
    public class RssSettingsEditorPresenter
    {
        private RssSettingsEditorView _view;
        private RssSettingsEditorModel _model;

        public RssSettingsEditorPresenter(RssInfo rssInfo)
        {
            _model = new RssSettingsEditorModel(rssInfo);
        }

    }
}
