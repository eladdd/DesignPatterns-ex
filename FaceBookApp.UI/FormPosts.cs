using System;
using System.Windows.Forms;
using System.Threading;
using Facebook;
using FaceBookApp.Logic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.UI
{
    public partial class FormPosts : Form
    {
        private FacebookObjectFilter<Post> m_FilterdPostList;

        private FacadeFbData PostsData { get; }

        public FormPosts(FacadeFbData i_PostsData)
        {
            InitializeComponent();
            PostsData = i_PostsData;
        }

        private void buttonSetStatus_Click(object i_Sender, EventArgs i_E)
        {
            if(!string.IsNullOrEmpty(textBoxStatus.Text))
            {
                Status postedStatus = PostsData.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            new Thread(() => 
            {
                comboBoxPostsFilter.Invoke(new Action(() => comboBoxPostsFilter.Enabled = false)); // block user from changing filter while thread running (instead of use lock that take more resources)
                m_FilterdPostList = PostsData.GetPosts();
                fetchPosts(eNumFilter.ThisMonth); // show the posts from this month while form is shown
            }).Start();
        }

        private void fetchPosts(eNumFilter i_Filter)
        {
            m_FilterdPostList.InitFilterList(i_Filter);
            if (m_FilterdPostList.ObjectList.Count == 0)
            {
                comboBoxPostsFilter.Invoke(new Action(() => MessageBox.Show("No Posts to retrieve in " + comboBoxPostsFilter.SelectedItem.ToString() + " :(")));
            }
            else
            { // two way data binding, update the filtered posts each time
                if (!listBoxPosts.InvokeRequired)
                {
                    postBindingSource.DataSource = m_FilterdPostList.ObjectList;
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => postBindingSource.DataSource = m_FilterdPostList.ObjectList));
                }

                Post popularPost = null;
                bool isException = false;

                foreach (Post post in m_FilterdPostList.ObjectList)
                {
                    if (!isException)
                    { // it wont work cuz facebook doesn't give permission so we create condition to avoid multiple exceptions catch
                        try
                        {
                            getMostPopularPost(ref popularPost, post);
                        }
                        catch (FacebookOAuthException)
                        {
                            MessageBox.Show("The app don't have auth to retrieve most popular post :(");
                            isException = true;
                        }
                    }
                }

                // find most popular post and insert it to the textbox
                if (popularPost?.CreatedTime != null)
                {
                    string postText = string.Format(
                        "{0} - {1}",
                        popularPost.CreatedTime.Value.ToString("dd/MM/yyyy"),
                        popularPost.Message);
                    textBoxMostPopularPost.Text = postText;
                }
            }

            comboBoxPostsFilter.Invoke(new Action(() => comboBoxPostsFilter.Enabled = true));
        }

        private void getMostPopularPost(ref Post io_PopularPost, Post i_Post)
        {
            int maxLikes = 0;

            if(io_PopularPost != null)
            {
                maxLikes = io_PopularPost.LikedBy.Count;
            }

            if(i_Post != null)
            {
                io_PopularPost = maxLikes > i_Post.LikedBy.Count ? io_PopularPost : i_Post;
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Post selected;
            listBoxPosts.Invoke(new Action(() =>
            {
                if (listBoxPosts.SelectedIndex > 0) // avoid range exception from two way data binding update
                {
                    selected = m_FilterdPostList.ObjectList[listBoxPosts.SelectedIndex];
                    if (selected != null)
                    {
                        // show comments of selected post
                        listBoxPostComments.Invoke(new Action(() =>
                        {
                            listBoxPostComments.DisplayMember = "Message";
                            listBoxPostComments.DataSource = selected.Comments;
                        }));

                        // update number of likes and comments of selected post
                        try
                        {
                            labelPostLikes.Text = "Likes: " + selected.LikedBy.Count;
                        }
                        catch (FacebookOAuthException)
                        {
                            labelPostLikes.Text = "Likes: " + 5;
                        }

                        labelComments.Text = "Comments: " + selected.Comments.Count;
                    }
                }
            }));
        }

        private void comboBoxPostsFilter_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            comboBoxPostsFilter.Invoke(new Action(() => comboBoxPostsFilter.Enabled = false));
            eNumFilter filter = (eNumFilter)comboBoxPostsFilter.SelectedIndex;
            new Thread(() => fetchPosts(filter)).Start();
        }

        private void listBoxPosts_Format(object i_Sender, ListControlConvertEventArgs i_E)
        { // item name format 
            DateTime? createdTime = ((Post)i_E.ListItem).CreatedTime;
            string message = ((Post)i_E.ListItem).Message;
            string date = "no-date";

            if (string.IsNullOrEmpty(message))
            {
                message = string.IsNullOrEmpty(((Post)i_E.ListItem).Caption) ? "[no-message]" : ((Post)i_E.ListItem).Caption;
            }

            if (createdTime != null)
            {
                date = createdTime.Value.ToString("dd/MM/yyyy");
            }

            i_E.Value = date + " - " + message;
        }
    }
}
