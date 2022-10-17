using System;
using System.Collections;
using System.Collections.Generic;

namespace Jarai.CSharp.Interface.Enumerable
{
    internal class Phonebook : IEnumerable<PhonebookEntry>
    {
        private readonly List<PhonebookEntry> _entries = new List<PhonebookEntry>();

        public void Add(PhonebookEntry entry)
        {
            _entries.Add(entry);
        }

        public IEnumerable<PhonebookEntry> FindAll(Predicate<PhonebookEntry> filterPredicate)
        {
            foreach (var phonebookEntry in _entries)
            {
                if (filterPredicate(phonebookEntry))
                    yield return phonebookEntry;
            }
        }

        public IEnumerator<PhonebookEntry> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _entries.GetEnumerator();
        }
    }
}