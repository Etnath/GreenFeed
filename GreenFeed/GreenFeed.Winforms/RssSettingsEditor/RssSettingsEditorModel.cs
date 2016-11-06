using GreenFeed.DataModel;

namespace GreenFeed.Winforms.RssSettingsEditor
{
    public class RssSettingsEditorModel
    {
        RssFeedData RssInfo { get; set; }

        public RssSettingsEditorModel(RssFeedData rssInfo)
        {
            RssInfo = rssInfo;
        }
    }
}
