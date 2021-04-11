using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FaceBookApp.Logic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.UI
{
    public partial class FormSearchPosts : Form
    {
        private FacadeFbData SearchDataManager { get; }

        public FormSearchPosts(FacadeFbData i_DataManger)
        {
            InitializeComponent();
            SearchDataManager = i_DataManger;
        }

        private void buttonSearchPost_Click(object i_Sender, EventArgs i_E)
        {
            if(!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                new Thread(() => fetchSearchResult(textBoxSearch.Text.ToLower())).Start();
            }
            else
            {
                MessageBox.Show("The text is Empty, try again");
            }
        }

        private void fetchSearchResult(string i_SearchText)
        {
            listBoxPostsResults.Invoke(new Action(() => listBoxPostsResults.Items.Clear()));
            Dictionary<User, List<Post>> searchResults = SearchDataManager.SearchFriendsPosts(i_SearchText);
            if(searchResults != null && searchResults.Count > 0)
            {
                foreach (KeyValuePair<User, List<Post>> resultsPosts in searchResults)
                {
                    string friendName = resultsPosts.Key.Name;
                    foreach (Post post in resultsPosts.Value)
                    {
                        listBoxPostsResults.Invoke(new Action(() => listBoxPostsResults.Items.Add(string.Format(@"{0}: {1}", friendName, post.Message))));
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no matches for your text");
            }
        }
    }
}