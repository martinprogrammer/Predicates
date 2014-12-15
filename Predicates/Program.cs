using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection myCollection = new CarCollection();
            string t = "Mercedes";
            Expression<Func<Car, bool>> predicate = (p) => p.Make == t;
            CarService.GetCarById(predicate).ToList().ForEach(p=>Console.WriteLine(p.Model));
            //myCollection.GetCars().AsQueryable<Car>().Where(predicate).ToList().ForEach(p => Console.WriteLine(p.Model));
            Console.Read();

        }

    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }


    }

    public class CarService
    {
        public static IEnumerable<Car> GetCarById(Expression<Func<Car, bool>> predicate)
        {
            CarCollection collection = new CarCollection();
            return collection.AsQueryable().Where(predicate).ToList();
        }
    }

    public class CarCollection : IEnumerable<Car>
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
            return Cars.GetEnumerator(); ;
        }
    }



}
