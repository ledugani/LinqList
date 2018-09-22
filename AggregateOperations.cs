using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQedList
{
    class AggregateOperations
    {
        public void ExerciseFive()
        {
            // Output how many numbers are in this list
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int numberOfNumbers = numbers.Count();

            Console.WriteLine(numberOfNumbers);
        }

        public void ExerciseSix()
        {
            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double total = purchases.Sum();

            Console.WriteLine(total);
        }

        public void ExerciseSeven()
        {
            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double highest = prices.Max();

            Console.WriteLine(highest);
        }
    }
}
