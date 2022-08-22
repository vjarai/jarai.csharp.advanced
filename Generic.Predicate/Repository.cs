using System;
using System.Collections.Generic;

namespace Jarai.Generic.Predicate
{
    internal class Repository
    {
        private readonly List<Record> _records = new List<Record>();

        public Repository()
        {
            GenerateRecords();
        }

        public void GenerateRecords()
        {
            var random = new Random();

            for (var i = 0; i < 100; i++)
            {
                _records.Add(new Record { Id = i, Value = random.Next(100) });
            }
        }

        public IEnumerable<Record> GetRecordsWhere(Predicate<Record> filterPredicate)
        {
            foreach (var record in _records)
            {
                if (filterPredicate(record))
                    yield return record; // ermöglicht deferred Execution
            }
        }
    }
}