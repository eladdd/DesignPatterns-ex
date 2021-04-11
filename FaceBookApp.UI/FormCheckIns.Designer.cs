namespace FaceBookApp.UI
{
    public partial class FormCheckIns
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
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.comboBoxCheckinFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxCheckIn = new System.Windows.Forms.PictureBox();
            this.webBrowserGoogleMaps = new System.Windows.Forms.WebBrowser();
            this.labelLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCheckins.DisplayMember = "name";
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(23, 68);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(331, 134);
            this.listBoxCheckins.TabIndex = 41;
            this.listBoxCheckins.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckins_SelectedIndexChanged);
            this.listBoxCheckins.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxCheckins_Format);
            // 
            // comboBoxCheckinFilter
            // 
            this.comboBoxCheckinFilter.Enabled = false;
            this.comboBoxCheckinFilter.FormattingEnabled = true;
            this.comboBoxCheckinFilter.Items.AddRange(new object[] {
            "All Time",
            "Today",
            "This Month",
            "This Year"});
            this.comboBoxCheckinFilter.Location = new System.Drawing.Point(223, 41);
            this.comboBoxCheckinFilter.Name = "comboBoxCheckinFilter";
            this.comboBoxCheckinFilter.Size = new System.Drawing.Size(131, 21);
            this.comboBoxCheckinFilter.TabIndex = 56;
            this.comboBoxCheckinFilter.Text = "This Month";
            this.comboBoxCheckinFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCheckinFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Filter By Date:";
            // 
            // pictureBoxCheckIn
            // 
            this.pictureBoxCheckIn.Location = new System.Drawing.Point(371, 68);
            this.pictureBoxCheckIn.Name = "pictureBoxCheckIn";
            this.pictureBoxCheckIn.Size = new System.Drawing.Size(122, 134);
            this.pictureBoxCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckIn.TabIndex = 57;
            this.pictureBoxCheckIn.TabStop = false;
            // 
            // webBrowserGoogleMaps
            // 
            this.webBrowserGoogleMaps.Location = new System.Drawing.Point(23, 235);
            this.webBrowserGoogleMaps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowserGoogleMaps.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowserGoogleMaps.Name = "webBrowserGoogleMaps";
            this.webBrowserGoogleMaps.Size = new System.Drawing.Size(470, 270);
            this.webBrowserGoogleMaps.TabIndex = 58;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(23, 216);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(169, 13);
            this.labelLocation.TabIndex = 59;
            this.labelLocation.Text = "Checkin location by Google Maps:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Sort By:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Enabled = false;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Date",
            "Name",
            "Likes"});
            this.comboBoxSort.Location = new System.Drawing.Point(223, 14);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(131, 21);
            this.comboBoxSort.TabIndex = 56;
            this.comboBoxSort.Text = "Date";
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // FormCheckIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 528);
            this.ControlBox = false;
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.webBrowserGoogleMaps);
            this.Controls.Add(this.pictureBoxCheckIn);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.comboBoxCheckinFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCheckins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCheckIns";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormCheckIns";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.ComboBox comboBoxCheckinFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxCheckIn;
        private System.Windows.Forms.WebBrowser webBrowserGoogleMaps;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSort;
    }
}