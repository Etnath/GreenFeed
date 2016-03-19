using System.ComponentModel;
using System.Windows.Forms;

namespace GreenFeed.Winforms.RssSettingsEditor
{
    partial class RssSettingsEditorView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbRssName = new System.Windows.Forms.Label();
            this.lbRssUrl = new System.Windows.Forms.Label();
            this.tbRssName = new System.Windows.Forms.TextBox();
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 88);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btOK);
            this.flowLayoutPanel1.Controls.Add(this.btCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(272, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(191, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.42857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.57143F));
            this.tableLayoutPanel2.Controls.Add(this.lbRssName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbRssUrl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbRssName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbRssUrl, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbRssName
            // 
            this.lbRssName.AutoSize = true;
            this.lbRssName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbRssName.Location = new System.Drawing.Point(82, 0);
            this.lbRssName.Name = "lbRssName";
            this.lbRssName.Size = new System.Drawing.Size(38, 25);
            this.lbRssName.TabIndex = 0;
            this.lbRssName.Text = "Name:";
            this.lbRssName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRssUrl
            // 
            this.lbRssUrl.AutoSize = true;
            this.lbRssUrl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbRssUrl.Location = new System.Drawing.Point(97, 25);
            this.lbRssUrl.Name = "lbRssUrl";
            this.lbRssUrl.Size = new System.Drawing.Size(23, 25);
            this.lbRssUrl.TabIndex = 1;
            this.lbRssUrl.Text = "Url:";
            this.lbRssUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRssName
            // 
            this.tbRssName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRssName.Location = new System.Drawing.Point(126, 3);
            this.tbRssName.Name = "tbRssName";
            this.tbRssName.Size = new System.Drawing.Size(221, 20);
            this.tbRssName.TabIndex = 2;
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRssUrl.Location = new System.Drawing.Point(126, 28);
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(221, 20);
            this.tbRssUrl.TabIndex = 3;
            // 
            // RssSettingsEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 88);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RssSettingsEditorView";
            this.Text = "Rss Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btOK;
        private Button btCancel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbRssName;
        private Label lbRssUrl;
        private TextBox tbRssName;
        private TextBox tbRssUrl;
    }
}