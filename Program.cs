using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restriction / Filtering Operations
            var restrictionOperations = new RestrictionOperations();

            Console.WriteLine("Exercise One:");
            restrictionOperations.ExerciseOne();
            Console.WriteLine("");

            Console.WriteLine("Exercise Two:");
            restrictionOperations.ExerciseTwo();
            Console.WriteLine("");

            // Ordering Operations

            var orderingOperations = new OrderingOps();

            Console.WriteLine("Exercise Three:");
            orderingOperations.ExerciseThree();
            Console.WriteLine("");

            Console.WriteLine("Exercise Four:");
            orderingOperations.ExerciseFour();
            Console.WriteLine("");

            // Aggregate Operations
            var aggregateOperations = new AggregateOperations();

            Console.WriteLine("Exercise Five:");
            aggregateOperations.ExerciseFive();
            Console.WriteLine("");

            // Partitioning Operations

            // Using Custom Types

            Console.ReadLine();
        }
    }
}
