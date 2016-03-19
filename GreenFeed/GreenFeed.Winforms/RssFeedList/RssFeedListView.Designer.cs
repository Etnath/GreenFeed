using System.ComponentModel;
using System.Windows.Forms;

namespace GreenFeed.Winforms.RssFeedList
{
    partial class RssFeedListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAddFeed = new System.Windows.Forms.Button();
            this.lbRssFeeds = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btAddFeed, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbRssFeeds, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.932203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.06779F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btAddFeed
            // 
            this.btAddFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddFeed.Location = new System.Drawing.Point(3, 3);
            this.btAddFeed.Name = "btAddFeed";
            this.btAddFeed.Size = new System.Drawing.Size(161, 21);
            this.btAddFeed.TabIndex = 0;
            this.btAddFeed.Text = "Add RSS Feed";
            this.btAddFeed.UseVisualStyleBackColor = true;
            // 
            // lbRssFeeds
            // 
            this.lbRssFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRssFeeds.FormattingEnabled = true;
            this.lbRssFeeds.Location = new System.Drawing.Point(3, 30);
            this.lbRssFeeds.Name = "lbRssFeeds";
            this.lbRssFeeds.Size = new System.Drawing.Size(161, 439);
            this.lbRssFeeds.TabIndex = 1;
            // 
            // RssFeedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RssFeedList";
            this.Size = new System.Drawing.Size(167, 472);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btAddFeed;
        private ListBox lbRssFeeds;
    }
}
