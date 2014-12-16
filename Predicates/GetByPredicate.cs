using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    public abstract class GetByPredicate<T> : IGetByPredicate<T>, IEnumerable<T>
    {
        public IEnumerable<T> GetResultByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return this.AsQueryable().Where(predicate).ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)this.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
