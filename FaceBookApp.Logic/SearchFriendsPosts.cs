using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public class SearchFriendsPosts : ISearchFriendsPosts
    {
        private FacadeFbData DataManager { get; }

        public SearchFriendsPosts(FacadeFbData i_DataManager)
        {
            DataManager = i_DataManager;
        }

        public Dictionary<User, List<Post>> SearchPosts(string i_SearchText)
        {
            Dictionary<User, List<Post>> friendsPostsDictionary = DataManager.GetFriendsPosts();
            Dictionary<User, List<Post>> filteredFriendsPostsDictionary = new Dictionary<User, List<Post>>();
            List<Post> friendsPostsFound = new List<Post>();
            foreach (KeyValuePair<User, List<Post>> friendPosts in friendsPostsDictionary)
            {
                foreach (Post post in friendPosts.Value)
                {
                    if (post.Message != null && post.Message.ToLower().Contains(i_SearchText))
                    {
                        friendsPostsFound.Add(post);
                    }
                }

                filteredFriendsPostsDictionary.Add(friendPosts.Key, friendsPostsFound);
            }

            return filteredFriendsPostsDictionary;
        }
    }
}