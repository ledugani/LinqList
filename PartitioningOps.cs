using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQedList
{
    class PartitioningOps
    {
        public void ExerciseEight()
        {
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            // IEnumerable<int> x = wheresSquaredo.Take();

            foreach(var num in wheresSquaredo)
            {
                var squirt = Math.Sqrt(num);
                if (squirt % 1 == 0)
                {
                    Console.WriteLine(squirt);
                }
            }
        }
    }
}
