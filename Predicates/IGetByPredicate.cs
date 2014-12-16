using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    public interface IGetByPredicate<T> : IEnumerable<T>
    {
        IEnumerable<T> GetResultByPredicate(Expression<Func<T, bool>> predicate);
    }
}
