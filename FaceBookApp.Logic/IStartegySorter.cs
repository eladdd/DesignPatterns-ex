using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public interface IStartegySorter<TTT> where TTT : Post
    {
        IEnumerable<TTT> Sort(IEnumerable<TTT> i_Input);
    }
}