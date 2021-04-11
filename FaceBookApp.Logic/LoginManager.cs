using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FaceBookApp.Logic
{
    public sealed class LoginManager
    {
        private const string k_AppId = "316689609471460";
        private static LoginManager s_Instance = null;
        private static object s_LockObj = new object();

        public static LoginManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new LoginManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public LoginResult LoggedInResult { get; set; }

        public User LoggedInUser { get; set; }

        private LoginManager()
        {
            FacebookService.s_CollectionLimit = 50;
            FacebookService.s_FbApiVersion = 2.8f;
        }

        public void ExistConnection(string i_LastAccessToken)
        {
            LoggedInResult = FacebookService.Connect(i_LastAccessToken);
        }

        public void LoginAndInit()
        {
            LoggedInResult = FacebookService.Login(
                k_AppId,
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");
        }

        public bool IsAccessTokenExist()
        {
            return !string.IsNullOrEmpty(LoggedInResult.AccessToken);
        }

        public void LogOutFB()
        {
            FacebookService.Logout(null);
        }
    }
}