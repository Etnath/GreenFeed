using GreenFeed.DataModel;

namespace GreenFeed.Winforms.RssSettingsEditor
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
