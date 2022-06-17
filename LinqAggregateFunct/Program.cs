using System;
using System.Linq;

namespace LinqAggregateFunct
{
    class Program
    {
        static void Main()
        {
            string[] countries = { "India", "USA", "UK" };
            Console.WriteLine("Cel mai lung nume de tara are {0} caractere" ,countries.Max(country => country.Length));
        }
       
    }
}
