namespace FaceBookApp.UI
{
    public partial class FormPosts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label messageLabel;
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPostsFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelPostLikes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMostPopularPost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.buttonEditPost = new System.Windows.Forms.Button();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(35, 200);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(97, 13);
            messageLabel.TabIndex = 63;
            messageLabel.Text = "Edit Selected Post:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(35, 30);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(339, 31);
            this.textBoxStatus.TabIndex = 0;
            this.textBoxStatus.Text = "Post Something New...";
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(171)))));
            this.buttonSetStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSetStatus.FlatAppearance.BorderSize = 0;
            this.buttonSetStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.buttonSetStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStatus.ForeColor = System.Drawing.Color.White;
            this.buttonSetStatus.Location = new System.Drawing.Point(380, 30);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(71, 30);
            this.buttonSetStatus.TabIndex = 1;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = false;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 19;
            this.listBoxPostComments.Location = new System.Drawing.Point(35, 296);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(339, 99);
            this.listBoxPostComments.TabIndex = 3;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(35, 94);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(339, 99);
            this.listBoxPosts.TabIndex = 4;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            this.listBoxPosts.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxPosts_Format);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // comboBoxPostsFilter
            // 
            this.comboBoxPostsFilter.FormattingEnabled = true;
            this.comboBoxPostsFilter.Items.AddRange(new object[] {
            "All Time",
            "Today",
            "This Month",
            "This Year"});
            this.comboBoxPostsFilter.Location = new System.Drawing.Point(263, 67);
            this.comboBoxPostsFilter.Name = "comboBoxPostsFilter";
            this.comboBoxPostsFilter.Size = new System.Drawing.Size(111, 21);
            this.comboBoxPostsFilter.TabIndex = 55;
            this.comboBoxPostsFilter.Text = "This Month";
            this.comboBoxPostsFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostsFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Filter By Date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelComments);
            this.panel1.Controls.Add(this.labelPostLikes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(380, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 97);
            this.panel1.TabIndex = 59;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelComments.Location = new System.Drawing.Point(3, 50);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(68, 13);
            this.labelComments.TabIndex = 0;
            this.labelComments.Text = "Comments: 0";
            // 
            // labelPostLikes
            // 
            this.labelPostLikes.AutoSize = true;
            this.labelPostLikes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPostLikes.Location = new System.Drawing.Point(3, 27);
            this.labelPostLikes.Name = "labelPostLikes";
            this.labelPostLikes.Size = new System.Drawing.Size(44, 13);
            this.labelPostLikes.TabIndex = 0;
            this.labelPostLikes.Text = "Likes: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(2, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selected Post Stats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Most Popular Post:";
            // 
            // textBoxMostPopularPost
            // 
            this.textBoxMostPopularPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMostPopularPost.Location = new System.Drawing.Point(38, 454);
            this.textBoxMostPopularPost.Multiline = true;
            this.textBoxMostPopularPost.Name = "textBoxMostPopularPost";
            this.textBoxMostPopularPost.ReadOnly = true;
            this.textBoxMostPopularPost.Size = new System.Drawing.Size(336, 46);
            this.textBoxMostPopularPost.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(32, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Comments for selected post:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(65, 216);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(192, 41);
            this.messageTextBox.TabIndex = 64;
            // 
            // buttonEditPost
            // 
            this.buttonEditPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(171)))));
            this.buttonEditPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditPost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditPost.FlatAppearance.BorderSize = 0;
            this.buttonEditPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.buttonEditPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPost.ForeColor = System.Drawing.Color.White;
            this.buttonEditPost.Location = new System.Drawing.Point(272, 223);
            this.buttonEditPost.Name = "buttonEditPost";
            this.buttonEditPost.Size = new System.Drawing.Size(71, 30);
            this.buttonEditPost.TabIndex = 1;
            this.buttonEditPost.Text = "Edit";
            this.buttonEditPost.UseVisualStyleBackColor = false;
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 528);
            this.ControlBox = false;
            this.Controls.Add(messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMostPopularPost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPostsFilter);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.buttonEditPost);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPosts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormPosts";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ComboBox comboBoxPostsFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelPostLikes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMostPopularPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button buttonEditPost;
    }
}