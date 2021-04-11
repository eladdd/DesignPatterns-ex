using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public class SortByName<TTT> : IStartegySorter<TTT>
        where TTT : Post
    {
        public IEnumerable<TTT> Sort(IEnumerable<TTT> i_Input)
        {
            IEnumerable<TTT> sort = from obj in i_Input orderby obj.Place.Name ascending select obj;

            return sort;
        }
    }
}