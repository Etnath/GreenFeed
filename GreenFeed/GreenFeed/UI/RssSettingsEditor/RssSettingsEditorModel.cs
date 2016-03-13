using GreenFeed.DataModel;

namespace GreenFeed.UI.RssSettingsEditor
{
    public class RssSettingsEditorModel
    {
        RssInfo RssInfo { get; set; }

        public RssSettingsEditorModel(RssInfo rssInfo)
        {
            RssInfo = rssInfo;
        }
    }
}
