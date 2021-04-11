using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public class FacadeFbData
    {
        private LoginManager LoginManager { get; }

        private ISearchFriendsPosts SearchFriendsPostsService { get; }

        public MusicPagesCollection MusicPages { get; private set; }

        public FacadeFbData(LoginManager i_LoginManager)
        {
            LoginManager = i_LoginManager;
            SearchFriendsPostsService = new SearchFriendsPostsCache(this);
        }

        public void LoadMusicPages()
        {
            MusicPages = new MusicPagesCollection();
        }

        public FacebookObjectFilter<Checkin> GetCheckins()
        {
            return new FacebookObjectFilter<Checkin>(LoginManager.LoggedInUser.Checkins);
        }

        public FacebookObjectFilter<Post> GetPosts()
        {
            return new FacebookObjectFilter<Post>(LoginManager.LoggedInUser.Posts);
        }

        public Status PostStatus(string i_Text)
        {
            return LoginManager.LoggedInUser.PostStatus(i_Text);
        }

        public FacebookObjectCollection<User> GetUserFriends()
        {
            return LoginManager.LoggedInUser.Friends;
        }

        public List<string> GetUserPersonalInfo()
        {
            List<string> personalInfo = new List<string>();

            personalInfo.Add("First Name: " + (LoginManager.LoggedInUser.FirstName ?? "N/A"));
            personalInfo.Add("Last Name: " + (LoginManager.LoggedInUser.LastName ?? "N/A"));
            personalInfo.Add("Gender: " + (LoginManager.LoggedInUser.Gender.ToString() ?? "N/A"));
            personalInfo.Add("BirthDay: " + (LoginManager.LoggedInUser.Birthday ?? "N/A"));
            personalInfo.Add("City: " + (LoginManager.LoggedInUser.Location.Name ?? "N/A"));
            personalInfo.Add("Email: " + (LoginManager.LoggedInUser.Email ?? "N/A"));

            return personalInfo;
        }

        public Dictionary<User, List<Post>> GetFriendsPosts()
        {
            FacebookObjectCollection<User> friendsList = GetUserFriends();
            Dictionary<User, List<Post>> friendsPostsDictionary = new Dictionary<User, List<Post>>();

            foreach (User friend in friendsList)
            {
                friendsPostsDictionary.Add(friend, friend.Posts.ToList());
            }

            return friendsPostsDictionary;
        }

        public Dictionary<User, List<Post>> SearchFriendsPosts(string i_SearchText)
        {
            return SearchFriendsPostsService.SearchPosts(i_SearchText);
        }

        public IEnumerable<T> SortStrategy<T>(FacebookObjectCollection<T> i_ObjectList, IStartegySorter<T> i_StrategySorter)
            where T : Post
        { 
            return i_StrategySorter.Sort(i_ObjectList);
        }
    }
}