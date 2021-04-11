using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using FaceBookApp.Logic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.UI
{
    public partial class FormMain : Form
    {
        private readonly AppSettings r_AppSettings; // its assigned in line 27

        private FormMusic FormMusic { get; set; }

        private FormPosts FormPosts { get; set; }

        private FormCheckIns FormCheckIns { get; set; }

        private FormSearchPosts FormSearchPosts { get; set; }

        private LoginManager LoginManager { get; set; }

        private FacadeFbData DataManager { get; set; }

        public FormMain()
        {
            InitializeComponent();
            r_AppSettings = AppSettings.LoadFromFile();
            this.Location = r_AppSettings.LastWindowsLocation;
            this.checkBoxRememberMe.Checked = r_AppSettings.RememberUser;
            this.menuItemPanel.AddItems(new List<ICommand>
            {
                new CommandButton("Posts", Properties.Resources.posts.ToBitmap(), "ButtonFormPosts").SetEvent(this.buttonPostsPanelExecute),
                new CommandButton("Check-ins", Properties.Resources.checkin_icon.ToBitmap(), "ButtonFormCheckins").SetEvent(this.buttonCheckinPanelExecute), 
                new CommandButton("Music", Properties.Resources.musicIcon.ToBitmap(), "ButtonFormMusic").SetEvent(this.buttonMusicPanelExecute), 
                new CommandButton("Friends Posts Search", Properties.Resources.searchFriendPosts, "ButtonFormSearch").SetEvent(this.buttonSearchPostsPanelExecute), 
            });
        }

        protected override void OnFormClosing(FormClosingEventArgs i_E)
        {
            base.OnFormClosing(i_E);
            r_AppSettings.LastWindowsLocation = this.Location;
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            if (r_AppSettings.RememberUser)
            {
                r_AppSettings.LastAccessToken = LoginManager.LoggedInResult.AccessToken;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveToFile();
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);

            // upload all the info of user after windows show 
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                LoginManager = LoginManager.Instance;
                LoginManager.ExistConnection(r_AppSettings.LastAccessToken);
                new Thread(fetchUserInfo).Start();
            }
        }

        #region Events (buttons click, selected friend list)
        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            LoginManager = LoginManager.Instance;
            LoginManager.LoginAndInit();

            if (LoginManager.IsAccessTokenExist())
            {
                new Thread(fetchUserInfo).Start();
            }
            else
            {
                MessageBox.Show(LoginManager.LoggedInResult.ErrorMessage);
            }
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            try
            {
                LoginManager.LogOutFB();
                restartApp();
            }
            catch
            { 
                MessageBox.Show("Error, unable to logout try re open app.");
            }
        }

        private void buttonPostsPanelExecute(object i_Sender, EventArgs i_E)
        {
            if (isUserLogged())
            {
                handleControlsPanelSwitch();
                if (FormPosts == null)
                {
                    FormPosts = new FormPosts(DataManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                }

                this.panelForm.Controls.Add(FormPosts);
                FormPosts.Show();
                this.labelPanelTitle.Text = ((Button)i_Sender).Text;
            }
        }

        private void buttonCheckinPanelExecute(object i_Sender, EventArgs i_E)
        {
            if (isUserLogged())
            {
                handleControlsPanelSwitch();
                if (FormCheckIns == null)
                {
                    FormCheckIns = new FormCheckIns(DataManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                }

                this.panelForm.Controls.Add(FormCheckIns);
                FormCheckIns.Show();
               this.labelPanelTitle.Text = ((Button)i_Sender).Text;
            }
        }

        private void buttonMusicPanelExecute(object i_Sender, EventArgs i_E)
        {
            if (isUserLogged())
            {
                handleControlsPanelSwitch();
                if (FormMusic == null)
                {
                    FormMusic = new FormMusic(DataManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                }

                this.panelForm.Controls.Add(FormMusic);
                FormMusic.Show();
                this.labelPanelTitle.Text = ((Button)i_Sender).Text;
            }
        }

        private void buttonSearchPostsPanelExecute(object i_Sender, EventArgs i_E)
        {
            if(isUserLogged())
            {
                handleControlsPanelSwitch();
                if(FormSearchPosts == null)
                {
                    FormSearchPosts =
                        new FormSearchPosts(DataManager) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                }

                this.panelForm.Controls.Add(FormSearchPosts);
                FormSearchPosts.Show();
                this.labelPanelTitle.Text = ((Button)i_Sender).Text;
            }
        }

        private void buttonAbout_Click(object i_Sender, EventArgs i_E)
        {
            handleControlsPanelSwitch();
            this.labelPanelTitle.Text = "About";
            this.panelForm.Controls.Add(pictureBoxAbout);
        }

        private void listBoxFriends_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            selectedFriendDetails();
        }

        #endregion

        #region  checkbox remember Mouse Hover
        private void checkBoxRememberMe_MouseHover(object i_Sender, EventArgs i_E)
        {
            if (checkBoxRememberMe.Checked)
            {
                toolTip.Show("By  uncheck this , app will forget your login", checkBoxRememberMe);
            }
            else
            {
                toolTip.Show("By checking this , app will remember your login", checkBoxRememberMe);
            }
        }

        #endregion

        #region fetch and utils functions

        private void fetchUserInfo()
        {
            DataManager = new FacadeFbData(LoginManager);
            LoginManager.LoggedInUser = LoginManager.LoggedInResult.LoggedInUser;
            circularPictureBoxProfile.LoadAsync(LoginManager.LoggedInUser.PictureNormalURL);
            checkBoxRememberMe.Invoke(new Action(() => checkBoxRememberMe.Enabled = true));
     
            List<string> personalInfo = DataManager.GetUserPersonalInfo();
            labelFirstName.Invoke(new Action(() => labelFirstName.Text = personalInfo[0]));
            labelLastName.Invoke(new Action(() => labelLastName.Text = personalInfo[1]));
            labelGender.Invoke(new Action(() => labelGender.Text = personalInfo[2]));
            labelBirthDay.Invoke(new Action(() => labelBirthDay.Text = personalInfo[3]));
            labelCity.Invoke(new Action(() => labelCity.Text = personalInfo[4]));
            labelEmail.Invoke(new Action(() => labelEmail.Text = personalInfo[5]));

            // update friends list
            new Thread(fetchFriends).Start();

            this.buttonLogin.Invoke(new Action(() => buttonLogin.Visible = false));
            this.buttonLogout.Invoke(new Action(() => buttonLogout.Visible = true));
        }

        private void fetchFriends()
        {
            FacebookObjectCollection<User> friendList = DataManager.GetUserFriends();

            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
                foreach (User friend in friendList)
                {
                    listBoxFriends.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }));

            if (friendList.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void selectedFriendDetails()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                this.panelSelectedFriend.Visible = true;
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend?.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }

                if (selectedFriend?.Posts != null)
                { // find if the last post from the user is in this month
                    DateTime? createdTime = selectedFriend.Posts[0].CreatedTime;
                    if (createdTime != null && createdTime.Value.Month.Equals(DateTime.Today.Month))
                    {
                        // active user 
                        labelActiveFriend.Text = "Yes";
                        labelActiveFriend.ForeColor = Color.Chartreuse;
                    }
                    else
                    {
                        labelActiveFriend.Text = "No";
                        labelActiveFriend.ForeColor = Color.Red;
                    }

                    labelLastPostDate.Text = createdTime.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    labelActiveFriend.Text = "N/A";
                }
            }
        }

        private bool isUserLogged()
        {
            bool isUserLogged = false;

            if (LoginManager?.LoggedInResult != null)
            {
                isUserLogged = true;
            }
            else
            {
                MessageBox.Show("Login Required for this action.");
            }

            return isUserLogged;
        }

        private void handleControlsPanelSwitch()
        {
            FormMusic?.RestoreWebBrowser();
            this.panelForm.Controls.Clear();
        }

        private void restartApp()
        {
            // reset forms
            FormPosts?.Dispose();
            FormPosts = null;
            FormCheckIns?.Dispose();
            FormCheckIns = null;
            FormMusic?.Dispose();
            FormMusic = null;
            buttonAbout.PerformClick();

            // reset labels
            labelFirstName.Text = "First Name: N/A";
            labelLastName.Text = "Last Name: N/A";
            labelGender.Text = "Gender: N/A";
            labelBirthDay.Text = "BirthDay: N/A";
            labelCity.Text = "City: N/A";
            labelEmail.Text = "Email: N/A";

            // reset profile picture
            this.circularPictureBoxProfile.Image = Properties.Resources.Facebook_no_profile_picture;

            // reset friends list
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));

            // logout
            this.buttonLogin.Visible = true;
            LoginManager = null;
            checkBoxRememberMe.Checked = false;
            checkBoxRememberMe.Enabled = false;
        }

        #endregion
    }
}