using System.Windows.Forms;

namespace GreenFeed.Winforms.RssFeedList
{
    public partial class RssFeedListView : UserControl
    {
        private RssFeedListPresenter _presenter;

        public RssFeedListView(RssFeedListPresenter presenter)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _presenter = presenter;
        }

        private void SubscribePresentertoEvents()
        {
            btAddFeed.Click += _presenter.BtAddFeed_Click;
        }

        private void UnsubscribePresentertoEvents()
        {
            btAddFeed.Click -= _presenter.BtAddFeed_Click;
        }
    }
}
