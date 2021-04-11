namespace FaceBookApp.UI
{
    public partial class FormMusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.pictureBoxMusicPage = new System.Windows.Forms.PictureBox();
            this.listBoxMusicPages = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.buttonSearchYT = new System.Windows.Forms.Button();
            this.labelSerachYT = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMusicPage
            // 
            this.pictureBoxMusicPage.Location = new System.Drawing.Point(517, 26);
            this.pictureBoxMusicPage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMusicPage.Name = "pictureBoxMusicPage";
            this.pictureBoxMusicPage.Size = new System.Drawing.Size(137, 165);
            this.pictureBoxMusicPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMusicPage.TabIndex = 44;
            this.pictureBoxMusicPage.TabStop = false;
            // 
            // listBoxMusicPages
            // 
            this.listBoxMusicPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMusicPages.DisplayMember = "name";
            this.listBoxMusicPages.FormattingEnabled = true;
            this.listBoxMusicPages.ItemHeight = 16;
            this.listBoxMusicPages.Location = new System.Drawing.Point(28, 26);
            this.listBoxMusicPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMusicPages.Name = "listBoxMusicPages";
            this.listBoxMusicPages.Size = new System.Drawing.Size(468, 164);
            this.listBoxMusicPages.TabIndex = 43;
            this.listBoxMusicPages.SelectedIndexChanged += new System.EventHandler(this.listBoxMusicPages_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(28, 260);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(627, 313);
            this.webBrowser.TabIndex = 45;
            this.webBrowser.Visible = false;
            // 
            // buttonSearchYT
            // 
            this.buttonSearchYT.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchYT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchYT.FlatAppearance.BorderSize = 0;
            this.buttonSearchYT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.buttonSearchYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchYT.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchYT.Image")));
            this.buttonSearchYT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchYT.Location = new System.Drawing.Point(339, 207);
            this.buttonSearchYT.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchYT.Name = "buttonSearchYT";
            this.buttonSearchYT.Size = new System.Drawing.Size(132, 31);
            this.buttonSearchYT.TabIndex = 46;
            this.buttonSearchYT.Text = "Search";
            this.buttonSearchYT.UseVisualStyleBackColor = false;
            this.buttonSearchYT.Click += new System.EventHandler(this.buttonSearchYT_Click);
            // 
            // labelSerachYT
            // 
            this.labelSerachYT.AutoSize = true;
            this.labelSerachYT.Location = new System.Drawing.Point(24, 214);
            this.labelSerachYT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerachYT.Name = "labelSerachYT";
            this.labelSerachYT.Size = new System.Drawing.Size(307, 17);
            this.labelSerachYT.TabIndex = 47;
            this.labelSerachYT.Text = "Select your music and try search it on YouTube";
            this.labelSerachYT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(517, 207);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(137, 31);
            this.buttonLoad.TabIndex = 48;
            this.buttonLoad.Text = "Load More Pages";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 650);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelSerachYT);
            this.Controls.Add(this.buttonSearchYT);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.pictureBoxMusicPage);
            this.Controls.Add(this.listBoxMusicPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMusic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormMusic";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMusicPage;
        private System.Windows.Forms.ListBox listBoxMusicPages;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonSearchYT;
        private System.Windows.Forms.Label labelSerachYT;
        private System.Windows.Forms.Button buttonLoad;
    }
}