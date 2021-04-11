namespace FaceBookApp.UI
{
    public partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAbout = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.menuItemPanel = new FaceBookApp.UI.MenuItemPanel();
            this.labelActions = new System.Windows.Forms.Label();
            this.labelPersonalInfo = new System.Windows.Forms.Label();
            this.circularPictureBoxProfile = new FaceBookApp.UI.CircularPictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.labelPanelTitle = new System.Windows.Forms.Label();
            this.labelActiveFriend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSelectedFriend = new System.Windows.Forms.Panel();
            this.labelLastPostDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBoxProfile)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.panelSelectedFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Image = global::FaceBookApp.UI.Properties.Resources.loginFB;
            this.buttonLogin.Location = new System.Drawing.Point(17, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(178, 44);
            this.buttonLogin.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonLogin, "Login");
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(201, 27);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 1;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.MouseHover += new System.EventHandler(this.checkBoxRememberMe_MouseHover);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(778, 547);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(90, 67);
            this.buttonAbout.TabIndex = 11;
            this.toolTip.SetToolTip(this.buttonAbout, "About");
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(147, 107);
            this.pictureBoxFriend.TabIndex = 12;
            this.pictureBoxFriend.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxFriend, "select friend picture");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Active Friend:";
            this.toolTip.SetToolTip(this.label1, "check if friend has active post i nthe last month");
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(24, 164);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 15);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "First Name: N/A";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(24, 186);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(92, 15);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name: N/A";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(24, 208);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(73, 15);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender: N/A";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDay.Location = new System.Drawing.Point(24, 230);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(78, 15);
            this.labelBirthDay.TabIndex = 5;
            this.labelBirthDay.Text = "BirthDay: N/A";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(24, 274);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 15);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email: N/A";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(24, 252);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(51, 15);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City: N/A";
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panelToolBar.Controls.Add(this.labelActions);
            this.panelToolBar.Controls.Add(this.labelPersonalInfo);
            this.panelToolBar.Controls.Add(this.labelFirstName);
            this.panelToolBar.Controls.Add(this.labelEmail);
            this.panelToolBar.Controls.Add(this.circularPictureBoxProfile);
            this.panelToolBar.Controls.Add(this.labelCity);
            this.panelToolBar.Controls.Add(this.labelBirthDay);
            this.panelToolBar.Controls.Add(this.labelLastName);
            this.panelToolBar.Controls.Add(this.labelGender);
            this.panelToolBar.Location = new System.Drawing.Point(17, 86);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(180, 335);
            this.panelToolBar.TabIndex = 7;
            // 
            // menuItemPanel
            // 
            this.menuItemPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuItemPanel.Location = new System.Drawing.Point(18, 422);
            this.menuItemPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuItemPanel.Name = "menuItemPanel";
            this.menuItemPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.menuItemPanel.PaddingBetweenItems = 5;
            this.menuItemPanel.Size = new System.Drawing.Size(180, 191);
            this.menuItemPanel.TabIndex = 1;
            // 
            // labelActions
            // 
            this.labelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActions.ForeColor = System.Drawing.Color.White;
            this.labelActions.Location = new System.Drawing.Point(0, 302);
            this.labelActions.Name = "labelActions";
            this.labelActions.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.labelActions.Size = new System.Drawing.Size(180, 33);
            this.labelActions.TabIndex = 6;
            this.labelActions.Text = "Actions";
            this.labelActions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.labelPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new System.Drawing.Size(180, 30);
            this.labelPersonalInfo.TabIndex = 6;
            this.labelPersonalInfo.Text = "Personal Info";
            this.labelPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularPictureBoxProfile
            // 
            this.circularPictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBoxProfile.Image = global::FaceBookApp.UI.Properties.Resources.Facebook_no_profile_picture;
            this.circularPictureBoxProfile.Location = new System.Drawing.Point(38, 50);
            this.circularPictureBoxProfile.Name = "circularPictureBoxProfile";
            this.circularPictureBoxProfile.Size = new System.Drawing.Size(105, 105);
            this.circularPictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBoxProfile.TabIndex = 4;
            this.circularPictureBoxProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(750, 112);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(147, 238);
            this.listBoxFriends.TabIndex = 8;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelFriends
            // 
            this.labelFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(750, 82);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(147, 30);
            this.labelFriends.TabIndex = 6;
            this.labelFriends.Text = "Friends";
            this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.pictureBoxAbout);
            this.panelForm.Location = new System.Drawing.Point(227, 86);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(505, 528);
            this.panelForm.TabIndex = 9;
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxAbout.Image = global::FaceBookApp.UI.Properties.Resources.AppAbout;
            this.pictureBoxAbout.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(505, 528);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbout.TabIndex = 0;
            this.pictureBoxAbout.TabStop = false;
            // 
            // labelPanelTitle
            // 
            this.labelPanelTitle.AutoSize = true;
            this.labelPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.labelPanelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelTitle.ForeColor = System.Drawing.Color.White;
            this.labelPanelTitle.Location = new System.Drawing.Point(254, 71);
            this.labelPanelTitle.Name = "labelPanelTitle";
            this.labelPanelTitle.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.labelPanelTitle.Size = new System.Drawing.Size(92, 30);
            this.labelPanelTitle.TabIndex = 6;
            this.labelPanelTitle.Text = "About";
            // 
            // labelActiveFriend
            // 
            this.labelActiveFriend.AutoSize = true;
            this.labelActiveFriend.Location = new System.Drawing.Point(70, 138);
            this.labelActiveFriend.Name = "labelActiveFriend";
            this.labelActiveFriend.Size = new System.Drawing.Size(49, 13);
            this.labelActiveFriend.TabIndex = 14;
            this.labelActiveFriend.Text = "YES/NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selected Friend Info:";
            // 
            // panelSelectedFriend
            // 
            this.panelSelectedFriend.Controls.Add(this.labelLastPostDate);
            this.panelSelectedFriend.Controls.Add(this.label3);
            this.panelSelectedFriend.Controls.Add(this.label2);
            this.panelSelectedFriend.Controls.Add(this.labelActiveFriend);
            this.panelSelectedFriend.Controls.Add(this.pictureBoxFriend);
            this.panelSelectedFriend.Controls.Add(this.label1);
            this.panelSelectedFriend.Location = new System.Drawing.Point(750, 356);
            this.panelSelectedFriend.Name = "panelSelectedFriend";
            this.panelSelectedFriend.Size = new System.Drawing.Size(147, 185);
            this.panelSelectedFriend.TabIndex = 16;
            this.panelSelectedFriend.Visible = false;
            // 
            // labelLastPostDate
            // 
            this.labelLastPostDate.AutoSize = true;
            this.labelLastPostDate.Location = new System.Drawing.Point(80, 155);
            this.labelLastPostDate.Name = "labelLastPostDate";
            this.labelLastPostDate.Size = new System.Drawing.Size(54, 13);
            this.labelLastPostDate.TabIndex = 17;
            this.labelLastPostDate.Text = "Post Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Post Date:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Image = global::FaceBookApp.UI.Properties.Resources.LogoutFB;
            this.buttonLogout.Location = new System.Drawing.Point(14, 20);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(181, 29);
            this.buttonLogout.TabIndex = 17;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(920, 626);
            this.Controls.Add(this.menuItemPanel);
            this.Controls.Add(this.panelSelectedFriend);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.labelPanelTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FaceBook Win App - C# .Net";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBoxProfile)).EndInit();
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.panelSelectedFriend.ResumeLayout(false);
            this.panelSelectedFriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ToolTip toolTip;
        private CircularPictureBox circularPictureBoxProfile;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Label labelActions;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelPanelTitle;
        private System.Windows.Forms.Label labelPersonalInfo;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelActiveFriend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSelectedFriend;
        private System.Windows.Forms.Label labelLastPostDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogout;
        private MenuItemPanel menuItemPanel;
    }
}