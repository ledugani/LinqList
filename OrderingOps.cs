using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQedList
{
    class OrderingOps
    {
        public void ExerciseThree()
        {
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend = names.OrderByDescending(x => x);

            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }
        }

        public void ExerciseFour()
        {
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> ascend = numbers.OrderBy(num => num);

            foreach(int num in ascend)
            {
                Console.WriteLine(num);
            }
        }
    }
}
