using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FaceBookApp.Logic;

namespace FaceBookApp.UI
{
    public partial class FormMusic : Form
    {
        private const string k_YouTubeUrl = "https://www.youtube.com/results?search_query=";
        private const int k_NumPagesToLoad = 5;
        
        private FacadeFbData MusicData { get; }

        public FormMusic(FacadeFbData i_MusicData)
        {
            InitializeComponent();
            MusicData = i_MusicData;
            i_MusicData.LoadMusicPages();
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            listBoxMusicPages.Items.Clear();
            new Thread(fetchMusic).Start();
        }
        
        private void fetchMusic()
        {
            int pageNum = 0;
            listBoxMusicPages.Invoke(new Action(() => listBoxMusicPages.DisplayMember = "Name"));

            foreach (Page page in MusicData.MusicPages)
            {
                listBoxMusicPages.Invoke(new Action(() => listBoxMusicPages.Items.Add(page)));
                pageNum++;
                if (pageNum >= k_NumPagesToLoad)
                {
                    break;
                }
            }

            if(listBoxMusicPages.Items.Count == 0)
            {
                musicPageHandler("No music pages to retrieve :(");
            }
            else if (pageNum == 0)
            {
                musicPageHandler("No more music pages to retrieve :(");
            }
        }

        private void musicPageHandler(string i_Text)
        {
            MessageBox.Show(i_Text);
            buttonLoad.Invoke(new Action(() => buttonLoad.Enabled = false));
        }

        private void listBoxMusicPages_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxMusicPages.SelectedItems.Count == 1)
            {
                Page selectedMusicPage = listBoxMusicPages.SelectedItem as Page;
                if(selectedMusicPage != null)
                {
                    pictureBoxMusicPage.LoadAsync(selectedMusicPage.PictureNormalURL);
                }
            }
        }

        private void buttonSearchYT_Click(object i_Sender, EventArgs i_E)
        {
            if (listBoxMusicPages.SelectedItems.Count == 1)
            {
                Page selectedMusicPage = listBoxMusicPages.SelectedItem as Page;
                if(selectedMusicPage != null)
                {
                    string url = string.Format("{0}{1}", k_YouTubeUrl, selectedMusicPage.Name);
                    createWebBrowser();
                    webBrowser.ScriptErrorsSuppressed = true;
                    webBrowser.Navigate(url);
                }
            }
        }

        private void createWebBrowser()
        {
            // Recreate WebBrowser to bypass Google automate queries detector.
            this.webBrowser.Dispose();
            this.webBrowser = new WebBrowser();
            this.webBrowser.Location = new Point(this.labelSerachYT.Location.X, this.labelSerachYT.Location.Y + 30);
            this.webBrowser.Margin = new Padding(4, 4, 4, 4);
            this.webBrowser.MinimumSize = new Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new Size(470, 254);
            this.webBrowser.TabIndex = 45;
            this.Controls.Add(this.webBrowser);
        }

        public void RestoreWebBrowser()
        {
            if(webBrowser != null)
            {
                webBrowser.Stop();
                webBrowser.Navigate("about:blank");
                webBrowser.Visible = false;
            }
        }

        private void buttonLoad_Click(object i_Sender, EventArgs i_E)
        {
            new Thread(fetchMusic).Start();
        }
    }
}