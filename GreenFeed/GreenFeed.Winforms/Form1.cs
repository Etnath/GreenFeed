using System.Windows.Forms;
using GreenFeed.Winforms.RssFeedList;

namespace GreenFeed.Winforms
{
    public partial class Form1 : Form
    {
        private RssFeedListPresenter _rssFeedListPresenter;

        public Form1()
        {
            InitializeComponent();
            _rssFeedListPresenter = new RssFeedListPresenter();
            splitContainer1.Panel1.Controls.Add(_rssFeedListPresenter.View);
        }
    }
}
