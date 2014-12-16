using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    public class Records : GetByPredicate<Predicates.Records.Record>, IEnumerable<Predicates.Records.Record>
    {
         List<Record> records = new List<Record>();

        public Records()
        {

            records.Add(new Record
            {
                Id = 1,
                Artist = "Keith Jarrett",
                Title = "Requiem",
                RecordingLength = new TimeSpan(0, 17, 33)
            });
            records.Add(new Record
            {
                Id = 2,
                Artist = "Pat Metheny",
                Title = "Full Circle",
                RecordingLength = new TimeSpan(1, 5, 11)
            });
            records.Add(new Record
            {
                Id = 3,
                Artist = "Susanne Sundfor",
                Title = "Bordel",
                RecordingLength = new TimeSpan(1, 12, 01)
            });
            records.Add(new Record
            {
                Id = 4,
                Artist = "Jan Garbarek",
                Title = "Infinitus",
                RecordingLength = new TimeSpan(0, 55, 59)
            });
            records.Add(new Record
            {
                Id = 5,
                Artist = "Eric Burdon War",
                Title = "Why can't we be friends",
                RecordingLength = new TimeSpan(1, 1, 1)
            });
        }




        IEnumerator<Record> IEnumerable<Record>.GetEnumerator()
        {
            return (IEnumerator<Record>)records.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return records.GetEnumerator();

        }
        //public IEnumerable<Record> GetRecordsByPredicate(Expression<Func<Record, bool>> predicate)
        //{
        //    return records.AsQueryable().Where(predicate).ToList();
        //}

        public class Record
        {
            public int Id { get; set; }
            public string Artist { get; set; }
            public string Title { get; set; }
            public TimeSpan RecordingLength { get; set; }
        }






    }
}
