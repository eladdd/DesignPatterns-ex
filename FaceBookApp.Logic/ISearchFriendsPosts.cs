using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public interface ISearchFriendsPosts
    {
        Dictionary<User, List<Post>> SearchPosts(string i_SearchText);
    }
}