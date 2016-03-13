using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenFeed.UI.RssFeedList;

namespace GreenFeed
{
    public partial class Form1 : Form
    {
        private RssFeedListPresenter _rssFeedListPresenter;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
