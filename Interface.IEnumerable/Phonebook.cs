using System.Collections;
using System.Collections.Generic;

namespace Jarai.CSharp.Interface.IEnumerable
{
    internal class Phonebook : IEnumerable<PhonebookEntry>
    {
        private readonly List<PhonebookEntry> _entries = new List<PhonebookEntry>();

        public void Add(PhonebookEntry entry)
        {
            _entries.Add(entry);
        }

        public IEnumerator<PhonebookEntry> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _entries.GetEnumerator();
        }
    }
}