using System.Collections;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceBookApp.Logic
{
    public class MusicPagesCollection : IEnumerable<Page>
    {
        private IEnumerator<Page> m_Iter;

        public MusicPagesCollection()
        {
            m_Iter = FacebookService.GetCollection<Page>("music").GetEnumerator();
        }

        public IEnumerator<Page> GetEnumerator()
        {
            return m_Iter;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}