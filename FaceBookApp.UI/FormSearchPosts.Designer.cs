namespace FaceBookApp.UI
{
    public partial class FormSearchPosts
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
            this.buttonSearchPost = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxPostsResults = new System.Windows.Forms.ListBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearchPost
            // 
            this.buttonSearchPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(171)))));
            this.buttonSearchPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchPost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearchPost.FlatAppearance.BorderSize = 0;
            this.buttonSearchPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(84)))), ((int)(((byte)(150)))));
            this.buttonSearchPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPost.ForeColor = System.Drawing.Color.White;
            this.buttonSearchPost.Location = new System.Drawing.Point(379, 37);
            this.buttonSearchPost.Name = "buttonSearchPost";
            this.buttonSearchPost.Size = new System.Drawing.Size(71, 27);
            this.buttonSearchPost.TabIndex = 2;
            this.buttonSearchPost.Text = "Search";
            this.buttonSearchPost.UseVisualStyleBackColor = false;
            this.buttonSearchPost.Click += new System.EventHandler(this.buttonSearchPost_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(34, 42);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(339, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // listBoxPostsResults
            // 
            this.listBoxPostsResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostsResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPostsResults.FormattingEnabled = true;
            this.listBoxPostsResults.ItemHeight = 19;
            this.listBoxPostsResults.Location = new System.Drawing.Point(34, 92);
            this.listBoxPostsResults.Name = "listBoxPostsResults";
            this.listBoxPostsResults.Size = new System.Drawing.Size(339, 213);
            this.listBoxPostsResults.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(34, 23);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(155, 13);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "Please type your text to search:";
            // 
            // FormSearchPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 489);
            this.ControlBox = false;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxPostsResults);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearchPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearchPosts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormSearchPosts";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchPost;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxPostsResults;
        private System.Windows.Forms.Label labelSearch;
    }
}