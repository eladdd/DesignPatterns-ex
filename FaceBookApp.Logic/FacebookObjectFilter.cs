using System;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public class FacebookObjectFilter<TTT> where TTT : Post
    {
        private readonly FacebookObjectCollection<TTT> r_FullObjectList;

        public FacebookObjectCollection<TTT> ObjectList { get; private set; }

        public FacebookObjectFilter(FacebookObjectCollection<TTT> i_FullObjectList)
        {
            this.ObjectList = new FacebookObjectCollection<TTT>();
            this.r_FullObjectList = i_FullObjectList;
            InitFilterList(eNumFilter.ThisMonth);
        }

        public void InitFilterList(eNumFilter i_Filter)
        {
            this.ObjectList.Clear();
            foreach (TTT fbObject in r_FullObjectList)
            {
                if (fbObject.CreatedTime != null && !filterByDate(i_Filter, fbObject.CreatedTime.Value))
                {
                    break;
                }

                ObjectList.Add(fbObject);
            }
        }

        private bool filterByDate(eNumFilter i_FilterDate, DateTime i_Date)
        {
            DateTime now = DateTime.Now;

            switch (i_FilterDate)
            {
                case eNumFilter.AllTime:
                    now = new DateTime(1970, 1, 1);
                    break;
                case eNumFilter.ThisMonth:
                    now = new DateTime(now.Year, now.Month, 1);
                    break;
                case eNumFilter.ThisYear:
                    now = new DateTime(now.Year, 1, 1);
                    break;
                case eNumFilter.Today:
                    break;
            }

            return now.Date <= i_Date.Date;
        }
    }
}