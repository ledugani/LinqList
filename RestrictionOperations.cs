using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQedList
{
    class RestrictionOperations
    {
        public void ExerciseOne()
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

             IEnumerable<string> LFruits =
                from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;

            foreach(var fruit in LFruits)
            {
                if (fruit.StartsWith("L")) 
                {
                    Console.WriteLine(fruit);
                }
            }

            // Console.Write(LFruits);
        }

        public void ExerciseTwo()
        {
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => (num % 4) == 0 || (num % 6) == 0);

            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }
        }
    }
}
