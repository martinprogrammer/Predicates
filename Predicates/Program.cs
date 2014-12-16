using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "Mercedes";
            Expression<Func<Predicates.Cars.Car, bool>> predicate = (p) => p.Make == t;
            RetrieveAndPrintList(predicate, new Cars.CarCollection());
            Console.Read();

            t = "Keith";
            TimeSpan ts = new TimeSpan(0, 30, 0);
            Expression<Func<Predicates.Records.Record, bool>> predicate1 = (p) => p.Artist.Contains("Keith");
            RetrieveAndPrintList(predicate1, new Records());
            Console.Read();
            Console.Read();

            



        }

        private static void RetrieveAndPrintList<T>(Expression<Func<T, bool>> predicate, IGetByPredicate<T> collection) where T: class
        {
            collection.GetResultByPredicate(predicate).ToList().ForEach(p => Console.WriteLine(
              
                    p.ToString()));
                }
        }

    }
