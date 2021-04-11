using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public class SearchFriendsPostsCache : ISearchFriendsPosts
    {
        private const int k_MemoryCapacity = 4;

        private SearchFriendsPosts SearchService { get; }

        private Dictionary<string, Dictionary<User, List<Post>>> FriendsPostsCache { get; }

        public SearchFriendsPostsCache(FacadeFbData i_DataManager)
        {
            SearchService = new SearchFriendsPosts(i_DataManager);
            FriendsPostsCache = new Dictionary<string, Dictionary<User, List<Post>>>();
        }

        public Dictionary<User, List<Post>> SearchPosts(string i_SearchText)
        {
            Dictionary<User, List<Post>> searchResult;
            if (FriendsPostsCache.ContainsKey(i_SearchText))
            {
                searchResult = FriendsPostsCache[i_SearchText];

                // update the last used position ( remove it and re add)
                FriendsPostsCache.Remove(i_SearchText);
                FriendsPostsCache.Add(i_SearchText, searchResult);
            }
            else
            {
                // use the searchFriendsPost searchPost method, update the cache (if cache full delete by "last used first out"
                searchResult = SearchService.SearchPosts(i_SearchText);
                if (FriendsPostsCache.Count == k_MemoryCapacity)
                { 
                  // remove from cache the last used(first index) and replace him
                  FriendsPostsCache.Remove(FriendsPostsCache.Keys.First());
                }

                FriendsPostsCache.Add(i_SearchText, searchResult);
            }
            
            return searchResult;
        }
    }
}