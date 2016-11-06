using GreenFeed.DataModel;

namespace GreenFeed.Winforms.RssSettingsEditor
{
    public class RssSettingsEditorPresenter
    {
        private RssSettingsEditorView _view;
        private RssSettingsEditorModel _model;

        public RssSettingsEditorPresenter(RssFeedData rssInfo)
        {
            _model = new RssSettingsEditorModel(rssInfo);
        }

    }
}
