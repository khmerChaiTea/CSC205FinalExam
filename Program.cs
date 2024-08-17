using System;
using System.Collections.Generic;
using System.Linq;

namespace CSC205FinalExam
{
    public class Program
    {
        public static void Main()
        {
            // List to store the numbers
            List<int> numbers = new List<int>();

            // Read 10 numbers from the user
            Console.WriteLine("Please enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            // Calculate minimum, maximum, and average
            int min = numbers.Min();
            int max = numbers.Max();
            double avg = numbers.Average();

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Average: " + avg);
        }
    }
}