using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace Predicates
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<object> primaryKey =
            //var primaryKey=
               (from p in typeof(Predicates.Records.Record).GetProperties()

                from a in p.GetCustomAttributes(typeof(ColumnAttribute), true)
                //where ((ColumnAttribute)a).IsPrimaryKey
                //select p);
                select a);


            Console.WriteLine(primaryKey.Count());
            primaryKey.Cast<dynamic>().ToList().ForEach( p=> Console.WriteLine(p.Name));

             

            //string t = "Mercedes";
            //Expression<Func<Predicates.Cars.Car, bool>> predicate = (p) => p.Make == t;
            //RetrieveAndPrintList(predicate, new Cars.CarCollection());
            //Console.Read();

            //t = "Keith";
            //TimeSpan ts = new TimeSpan(0, 30, 0);
            //Expression<Func<Predicates.Records.Record, bool>> predicate1 = (p) => p.Artist.Contains("Keith");
            //RetrieveAndPrintList(predicate1, new Records());
            Console.Read();
            Console.Read();

            



        }

        private static void RetrieveAndPrintList<T>(Expression<Func<T, bool>> predicate, IGetByPredicate<T> collection) where T: class
        {
           
           
            //properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            //var result = collection.GetResultByPredicate(predicate).ToList();
            //result.ForEach(p=> Console.WriteLine(p.properties[0]));
              
                    
                }
        }

    }
