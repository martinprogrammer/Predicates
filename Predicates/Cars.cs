using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    public class Cars
    {
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
      }

        //public class CarService
        //{
        //    public static IEnumerable<T> GetCarByPredicate<T>(Expression<Func<T, bool>> predicate, IEnumerable<T> collection)  where T: class
        //    {
        //        var result = collection.AsQueryable().Where(predicate).ToList();
        //        return result;
        //    }
        //}

        public class CarCollection : GetByPredicate<Car>, IEnumerable<Car>
        {
            List<Car> Cars = new List<Car>();

            public CarCollection()
            {
                Cars.Add(new Car
                {
                    Make = "Mercedes",
                    Model = "280GE"
                });
                Cars.Add(new Car
                {
                    Make = "Toyota",
                    Model = "Corolla"
                });
                Cars.Add(new Car
                {
                    Make = "Nissan",
                    Model = "Micra"
                });
                Cars.Add(new Car
                {
                    Make = "Mercedes",
                    Model = "280SE"
                });
                Cars.Add(new Car
                {
                    Make = "Mercedes",
                    Model = "230SL"
                });
            }

            IEnumerator<Car> IEnumerable<Car>.GetEnumerator()
            {
                return (IEnumerator<Car>)Cars.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return Cars.GetEnumerator(); 
            }
        }
    }
}
